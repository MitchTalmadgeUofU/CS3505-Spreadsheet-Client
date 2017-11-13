﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Networking;

namespace SpaceWars
{
    /// <summary>
    /// The main controller for the SpaceWars game.
    /// Uses the networking library to maintain a connection with the game server and notify listeners of changes to game components.
    /// </summary>
    /// <authors>Jiahui Chen, Mitch Talmadge</authors>
    public class SpaceWars
    {
        /// <summary>
        /// This delegate is called when a connection to SpaceWars was established.
        /// May be called on another thread.
        /// </summary>
        /// <param name="spaceWars">The connected SpaceWars client.</param>
        public delegate void ConnectionEstablished(SpaceWars spaceWars);

        /// <summary>
        /// This delegate is called when a connection to SpaceWars failed.
        /// </summary>
        /// <param name="reason">Why the connection failed.</param>
        public delegate void ConnectionFailed(string reason);

        /// <summary>
        /// The provided ConnectionEstablished delegate implementation.
        /// </summary>
        private readonly ConnectionEstablished _establishedCallback;

        /// <summary>
        /// This delegate handles cases where any game component is updated (a ship, projectile, etc.)
        /// </summary>
        public delegate void GameComponentsListener();

        /// <summary>
        /// This event is fired whenever a game component (ship, projectile, etc.) is updated from the server.
        /// </summary>
        public event GameComponentsListener OnGameComponentsUpdated;

        /// <summary>
        /// Socket that the connection is made through.
        /// </summary>
        private SocketState _socketState;

        /// <summary>
        /// The dimensions of the game world (both sides use same length).
        /// </summary>
        public int WorldSize { get; private set; }

        /// <summary>
        /// The current ship that the player controls. 
        /// May be null if there is no established connection.
        /// </summary>
        public Ship PlayerShip => _ships[PlayerId];

        /// <summary>
        /// The nickname of the current player.
        /// </summary>
        public string PlayerNickname { get; }

        /// <summary>
        /// The ID of the current player.
        /// </summary>
        public int PlayerId { get; private set; } = -1;

        /// <summary>
        /// A mapping of each known ship in the game to that ship's ID.
        /// </summary>
        private readonly Dictionary<int, Ship> _ships = new Dictionary<int, Ship>();

        /// <summary>
        /// All known ships in the game.
        /// </summary>
        public IEnumerable<Ship> Ships => _ships.Values.ToList().AsReadOnly();

        //TODO: Projectiles, etc.

        /// <summary>
        /// Creates a new SpaceWars instance that has not been connected.
        /// Attempts to establish a connection to the given game server, using the given nickname.
        /// If a connection cannot be established, an exception is thrown. 
        /// </summary>
        /// <param name="hostName">The server address, excluding the port.</param>
        /// <param name="nickname">The nickname to use for the player connecting.</param>
        /// <param name="established">The callback for when a connection is established.</param>
        /// <param name="failed">The callback for when a connection has failed.</param>
        internal SpaceWars(string hostName, string nickname, ConnectionEstablished established, ConnectionFailed failed)
        {
            PlayerNickname = nickname;

            _establishedCallback = established;

            // Connect to the server.
            Networking.Networking.ConnectToServer(
                hostName,
                state =>
                {
                    _socketState = state;
                    // Start the thread that continually receives data.
                    new Thread(() =>
                    {
                        // Send the nickname of the user.
                        Networking.Networking.Send(state, nickname + '\n');

                        // Wait for data.
                        Networking.Networking.GetData(state);
                    }).Start();
                },
                reason => failed(reason),
                DataReceived
            );
        }

        /// <summary>
        /// Disconnects from the server. 
        /// This game instance should no longer be used once this method is called.
        /// </summary>
        public void Disconnect()
        {
            Networking.Networking.DisconnectFromServer(_socketState);
        }

        /// <summary>
        /// Called when data is received on the socket.
        /// </summary>
        /// <param name="data">The data that was received.</param>
        public void DataReceived(string data)
        {
            // When PlayerId is -1, the first packet containing the player id and world size has not been received.
            if (PlayerId == -1)
            {
                // Parse the first packet, containing our player id and the world size.
                var splitData = data.Split('\n');
                PlayerId = int.Parse(splitData[0]);
                WorldSize = int.Parse(splitData[1]);

                // Notify the listener that the connection was established and the world is ready.
                _establishedCallback(this);
            }

            //TODO: parse data as json

            // Get new data.
            Networking.Networking.GetData(_socketState);
        }
    }
}