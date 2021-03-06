﻿// Written by Joe Zachary for CS 3500, September 2011.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Concurrent;

namespace SS
{
    /// <summary>
    /// The type of delegate used to register for SelectionChanged events
    /// </summary>
    /// <param name="sender"></param>

    public delegate void SelectionChangedHandler(SpreadsheetPanel sender);

    /// <summary>
    /// The type of delegate used to register for CellEditEnter events
    /// Triggered when the enter button is pressed while cell editor text box is selected.
    /// </summary>
    /// <param name="sender"></param>

    public delegate void CellInputHandler(SpreadsheetPanel sender);

    /// <summary>
    /// The type of delegate used to register for CellEditEnter events
    /// Triggered when the enter button is pressed while cell editor text box is selected.
    /// </summary>
    /// <param name="sender"></param>

    public delegate void CellMovementHandler(SpreadsheetPanel sender);

    /// <summary>
    /// A panel that displays a spreadsheet with 26 columns (labeled A-Z) and 99 rows
    /// (labeled 1-99).  Each cell on the grid can display a non-editable string.  One
    /// of the cells is always selected (and highlighted).  When the selection changes, a
    /// SelectionChanged event is fired.  Clients can register to be notified of
    /// such events.
    ///
    /// Cells are editable (for 3505 final project).
    /// </summary>

    public partial class SpreadsheetPanel : UserControl
    {
        // The SpreadsheetPanel is composed of a DrawingPanel (where the grid is drawn),
        // a horizontal scroll bar, and a vertical scroll bar.
        private DrawingPanel drawingPanel;

        private HScrollBar hScroll;
        private VScrollBar vScroll;

        /// Text box within a cell being edited
        public TextBox cellInputTextBox;

        // These constants control the layout of the spreadsheet grid.  The height and
        // width measurements are in pixels.
        private const int DATA_COL_WIDTH = 80;

        private const int DATA_ROW_HEIGHT = 20;
        private const int LABEL_COL_WIDTH = 30;
        private const int LABEL_ROW_HEIGHT = 30;
        private const int PADDING = 2;
        private const int SCROLLBAR_WIDTH = 20;
        private const int COL_COUNT = 26;
        private const int ROW_COUNT = 99;

        private static Color[] USER_COLORS = new Color[] { Color.FromArgb(100, 255, 179, 186), Color.FromArgb(100, 255, 223, 186), Color.FromArgb(100, 255, 255, 186), Color.FromArgb(100, 186, 255, 201), Color.FromArgb(100, 186, 225, 255) };

        /// <summary>
        /// Used for random color selection for Focus display.
        /// </summary>
        private Random rnd;

        /// <summary>
        /// Tracks which cells are being edited, and maps them by name to the user editing them.
        /// </summary>
        public ConcurrentDictionary<string, string> focusedCells
        {
            private set;
            get;
        }

        /// <summary>
        /// Determines if this spreadsheet can be edited or not.
        /// </summary>
        public bool ReadOnly
        {
            get => cellInputTextBox.ReadOnly;
            set => cellInputTextBox.ReadOnly = value;
        }

        /// <summary>
        /// Creates an empty SpreadsheetPanel
        /// </summary>

        public SpreadsheetPanel()
        {
            InitializeComponent();

            // The DrawingPanel is quite large, since it has 26 columns and 99 rows.  The
            // SpreadsheetPanel itself will usually be smaller, which is why scroll bars
            // are necessary.
            drawingPanel = new DrawingPanel(this);
            drawingPanel.Location = new Point(0, 0);
            drawingPanel.AutoScroll = false;

            // A custom vertical scroll bar.  It is designed to scroll in multiples of rows.
            vScroll = new VScrollBar();
            vScroll.SmallChange = 1;
            vScroll.Maximum = ROW_COUNT;

            // A custom horizontal scroll bar.  It is designed to scroll in multiples of columns.
            hScroll = new HScrollBar();
            hScroll.SmallChange = 1;
            hScroll.Maximum = COL_COUNT;

            // Add the drawing panel and the scroll bars to the SpreadsheetPanel.
            Controls.Add(drawingPanel);
            Controls.Add(vScroll);
            Controls.Add(hScroll);

            // Arrange for the drawing panel to be notified when it needs to scroll itself.
            hScroll.Scroll += drawingPanel.HandleHScroll;
            vScroll.Scroll += drawingPanel.HandleVScroll;

            // Cell input box is same size as a cell and starts out in the first cell
            cellInputTextBox = new TextBox
            {
                Location = new Point(LABEL_COL_WIDTH, LABEL_ROW_HEIGHT),
                Size = new Size(DATA_COL_WIDTH, DATA_ROW_HEIGHT)
            };
            // Event handler for when enter is pressed while cell is being edited
            cellInputTextBox.KeyPress += new KeyPressEventHandler(cellInputTextBox_KeyPress);
            cellInputTextBox.KeyDown += new KeyEventHandler(cellInputTextBox_KeyUp);

            Controls.Add(cellInputTextBox);
            cellInputTextBox.BringToFront();

            // initializing Random generator
            rnd = new Random(8008137);

            // initializing focused cells map and user map
            focusedCells = new ConcurrentDictionary<string, string>();
        }

        /// <summary>
        /// Clears the display.
        /// </summary>

        public void Clear()
        {
            drawingPanel.Clear();

            // clearing cell focus display
            focusedCells.Clear();
            drawingPanel.Redraw();
        }

        /// <summary>
        /// If the zero-based column and row are in range, sets the value of that
        /// cell and returns true.  Otherwise, returns false.
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <param name="value"></param>
        /// <returns></returns>

        public bool SetValue(int col, int row, string value)
        {
            return drawingPanel.SetValue(col, row, value);
        }

        /// <summary>
        /// If the zero-based column and row are in range, assigns the value
        /// of that cell to the out parameter and returns true.  Otherwise,
        /// returns false.
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <param name="value"></param>
        /// <returns></returns>

        public bool GetValue(int col, int row, out string value)
        {
            return drawingPanel.GetValue(col, row, out value);
        }

        private void GetCellName(int row, int col, out string cellName)
        {
            cellName = (char)('A' + col) + (++row).ToString();
        }

        /// <summary>
        /// If the zero-based column and row are in range, uses them to set
        /// the current selection and returns true.  Otherwise, returns false.
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>
        /// <returns></returns>

        public bool SetSelection(int col, int row)
        {
            return drawingPanel.SetSelection(col, row);
        }

        /// <summary>
        /// Assigns the column and row of the current selection to the
        /// out parameters.
        /// </summary>
        /// <param name="col"></param>
        /// <param name="row"></param>

        public void GetSelection(out int col, out int row)
        {
            drawingPanel.GetSelection(out col, out row);
        }

        /// <summary>
        /// When the SpreadsheetPanel is resized, we set the size and locations of the three
        /// components that make it up.
        /// </summary>
        /// <param name="eventargs"></param>

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            if (FindForm() == null || FindForm().WindowState != FormWindowState.Minimized)
            {
                drawingPanel.Size = new Size(Width - SCROLLBAR_WIDTH, Height - SCROLLBAR_WIDTH);
                vScroll.Location = new Point(Width - SCROLLBAR_WIDTH, 0);
                vScroll.Size = new Size(SCROLLBAR_WIDTH, Height - SCROLLBAR_WIDTH);
                vScroll.LargeChange = (Height - SCROLLBAR_WIDTH) / DATA_ROW_HEIGHT;
                hScroll.Location = new Point(0, Height - SCROLLBAR_WIDTH);
                hScroll.Size = new Size(Width - SCROLLBAR_WIDTH, SCROLLBAR_WIDTH);
                hScroll.LargeChange = (Width - SCROLLBAR_WIDTH) / DATA_COL_WIDTH;
            }
        }

        /// <summary>
        /// The event used to send notifications of a selection change
        /// </summary>

        public event SelectionChangedHandler SelectionChanged;

        /// <summary>
        /// The event used when the Enter button is pressed while the cell editor is in use
        /// </summary>
        public event CellInputHandler CellEditEnter;

        /// <summary>
        /// The event used when the down arrow key is pressed while the cell editor is in use
        /// </summary>
        public event CellMovementHandler CellEditDown;

        /// <summary>
        /// The event used when the up arrow key is pressed while the cell editor is in use
        /// </summary>
        public event CellMovementHandler CellEditUp;

        /// <summary>
        /// The event used when the right arrow key is pressed while the cell editor is in use
        /// </summary>
        public event CellMovementHandler CellEditRight;

        /// <summary>
        /// The event used when the left arrow key is pressed while the cell editor is in use
        /// </summary>
        public event CellMovementHandler CellEditLeft;

        /// <summary>
        /// Called when a key is pressed while the cell content text box is focused.
        /// Saves/displays the contents when the enter key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cellInputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Invokes event handler for when the a value should be input into spreadsheet
                CellEditEnter(this);

                e.Handled = true;
            }
        }

        /// <summary>
        /// Called when a key is pressed while the cell content text box is focused.
        /// Saves/displays the contents when the enter key is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cellInputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                CellEditDown(this);
            }
            if (e.KeyCode == Keys.Up)
            {
                CellEditUp(this);
            }
            if (e.KeyCode == Keys.Right)
            {
                CellEditRight(this);
            }
            if (e.KeyCode == Keys.Left)
            {
                CellEditLeft(this);
            }
        }

        /// <summary>
        /// Used internally to keep track of cell addresses
        /// </summary>

        private class Address
        {
            public int Col { get; set; }
            public int Row { get; set; }

            public Address(int c, int r)
            {
                Col = c;
                Row = r;
            }

            public override int GetHashCode()
            {
                return Col.GetHashCode() ^ Row.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if ((obj == null) || !(obj is Address))
                {
                    return false;
                }
                Address a = (Address)obj;
                return Col == a.Col && Row == a.Row;
            }
        }

        /// <summary>
        /// Adds cell to focusedCells map, indicating that another client is editing it.
        ///
        /// The OnPaint method will fill cell in with the color it's mapped to.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="cell"></param>
        public void Focus(string cell, string user)
        {
            // Unfocus any cell the user was editing before
            Unfocus(user);

            // if the cell isn't in focusedCells, add it
            if (!focusedCells.TryGetValue(cell, out var u))
            {
                focusedCells.TryAdd(cell, user);
            }
            // redrawing cells panel to reflect focus/unfocuses
            drawingPanel.Redraw();
        }

        /// <summary>
        /// Makes colored text box at the location of the cell indicating that
        /// another client is editing it invisible.
        /// </summary>
        /// <param name="user"></param>
        public void Unfocus(string user)
        {
          
            // getting the cell to be unfocused (key corresponding to the value that is user in the focusedCells map)
            string cell = focusedCells.FirstOrDefault(x => x.Value.Contains(user)).Key;
            if (cell != null)
            {
                focusedCells.TryRemove(cell, out var u);
            }
           
            // redrawing cells panel to reflect focus/unfocuses
            drawingPanel.Redraw();
        }

        /// <summary>
        /// From a cell name, determines the column and row of the cell in the spreadsheet panel.
        /// </summary>
        /// <param name="cellName">The name of the cell.</param>
        /// <param name="col">The variable to store the column in.</param>
        /// <param name="row">The variable to store the row in.</param>
        private static void GetColumnAndRowFromCellName(string cellName, out int col, out int row)
        {
            // Column
            col = cellName[0] - 'A';

            // Row
            int.TryParse(cellName.Substring(1), out row);
            row = row - 1;
        }

        /// <summary>
        /// The panel where the spreadsheet grid is drawn.  It keeps track of the
        /// current selection as well as what is supposed to be drawn in each cell.
        /// </summary>

        private class DrawingPanel : Panel
        {
            // Columns and rows are numbered beginning with 0.  This is the coordinate
            // of the selected cell.
            private int _selectedCol;

            private int _selectedRow;

            // Coordinate of cell in upper-left corner of display
            private int _firstColumn = 0;

            private int _firstRow = 0;

            // The strings contained by the spreadsheet
            private Dictionary<Address, String> _values;

            // The containing panel
            private SpreadsheetPanel _ssp;

            public DrawingPanel(SpreadsheetPanel ss)
            {
                DoubleBuffered = true;
                _values = new Dictionary<Address, String>();
                _ssp = ss;
            }

            private bool InvalidAddress(int col, int row)
            {
                return col < 0 || row < 0 || col >= COL_COUNT || row >= ROW_COUNT;
            }

            public void Clear()
            {
                _values.Clear();
                Invalidate();
            }

            public bool SetValue(int col, int row, string c)
            {
                if (InvalidAddress(col, row))
                {
                    return false;
                }

                Address a = new Address(col, row);
                if (c == null || c == "")
                {
                    _values.Remove(a);
                }
                else
                {
                    _values[a] = c;
                }
                Invalidate();
                return true;
            }

            public bool GetValue(int col, int row, out string c)
            {
                if (InvalidAddress(col, row))
                {
                    c = null;
                    return false;
                }
                if (!_values.TryGetValue(new Address(col, row), out c))
                {
                    c = "";
                }
                return true;
            }

            /// <summary>
            /// Sets selected cell to row and col location in parameters.
            /// Also sets the location of the cell editor text box to the selected cell.
            /// </summary>
            /// <param name="col"></param>
            /// <param name="row"></param>
            /// <returns></returns>
            public bool SetSelection(int col, int row)
            {
                // getting cell name
                _ssp.GetCellName(col, row, out var cellName);
                // if cell address is invalid 
                if (InvalidAddress(col, row) )
                {
                    return false;
                }
                _selectedCol = col;
                _selectedRow = row;

                UpdateCellInputTextBoxLocation();
                
                Invalidate();
                return true;
            }

            /// <summary>
            /// Updates the position of the cell input text box.
            /// </summary>
            private void UpdateCellInputTextBoxLocation()
            {
                int cell_x = ((_selectedCol - _firstColumn) * DATA_COL_WIDTH) + LABEL_COL_WIDTH;
                int cell_y = ((_selectedRow - _firstRow) * DATA_ROW_HEIGHT) + LABEL_ROW_HEIGHT;
                _ssp.cellInputTextBox.Location = new Point(cell_x, cell_y);
            }

            private void UpdateCellFocusLocations()
            {

            }

            public void GetSelection(out int col, out int row)
            {
                col = _selectedCol;
                row = _selectedRow;
            }

            public void HandleHScroll(Object sender, ScrollEventArgs args)
            {
                _firstColumn = args.NewValue;
                UpdateCellInputTextBoxLocation();
                Invalidate();
            }

            public void HandleVScroll(Object sender, ScrollEventArgs args)
            {
                _firstRow = args.NewValue;
                UpdateCellInputTextBoxLocation();
                Invalidate();
            }

            /// <summary>
            /// Allows spreasheet to call OnPaint on drawing panel.
            /// </summary>
            internal void Redraw()
            {
                this.Invalidate();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                // Clip based on what needs to be refreshed.
                Region clip = new Region(e.ClipRectangle);
                e.Graphics.Clip = clip;

                // Color the background of the data area white
                e.Graphics.FillRectangle(
                    new SolidBrush(Color.White),
                    LABEL_COL_WIDTH,
                    LABEL_ROW_HEIGHT,
                    (COL_COUNT - _firstColumn) * DATA_COL_WIDTH,
                    (ROW_COUNT - _firstRow) * DATA_ROW_HEIGHT);

                // Pen, brush, and fonts to use
                Brush brush = new SolidBrush(Color.Black);
                Pen pen = new Pen(brush);
                Font regularFont = Font;
                Font boldFont = new Font(regularFont, FontStyle.Bold);

                // Draw the column lines
                int bottom = LABEL_ROW_HEIGHT + (ROW_COUNT - _firstRow) * DATA_ROW_HEIGHT;
                e.Graphics.DrawLine(pen, new Point(0, 0), new Point(0, bottom));
                for (int x = 0; x <= (COL_COUNT - _firstColumn); x++)
                {
                    e.Graphics.DrawLine(
                        pen,
                        new Point(LABEL_COL_WIDTH + x * DATA_COL_WIDTH, 0),
                        new Point(LABEL_COL_WIDTH + x * DATA_COL_WIDTH, bottom));
                }

                // Draw the column labels
                for (int x = 0; x < COL_COUNT - _firstColumn; x++)
                {
                    Font f = (_selectedCol - _firstColumn == x) ? boldFont : Font;
                    DrawColumnLabel(e.Graphics, x, f);
                }

                // Draw the row lines
                int right = LABEL_COL_WIDTH + (COL_COUNT - _firstColumn) * DATA_COL_WIDTH;
                e.Graphics.DrawLine(pen, new Point(0, 0), new Point(right, 0));
                for (int y = 0; y <= ROW_COUNT - _firstRow; y++)
                {
                    e.Graphics.DrawLine(
                        pen,
                        new Point(0, LABEL_ROW_HEIGHT + y * DATA_ROW_HEIGHT),
                        new Point(right, LABEL_ROW_HEIGHT + y * DATA_ROW_HEIGHT));
                }

                // Draw the row labels
                for (int y = 0; y < (ROW_COUNT - _firstRow); y++)
                {
                    Font f = (_selectedRow - _firstRow == y) ? boldFont : Font;
                    DrawRowLabel(e.Graphics, y, f);
                }

                // Highlight the selection, if it is visible
                if ((_selectedCol - _firstColumn >= 0) && (_selectedRow - _firstRow >= 0))
                {
                    e.Graphics.DrawRectangle(
                        pen,
                        new Rectangle(LABEL_COL_WIDTH + (_selectedCol - _firstColumn) * DATA_COL_WIDTH + 1,
                                      LABEL_ROW_HEIGHT + (_selectedRow - _firstRow) * DATA_ROW_HEIGHT + 1,
                                      DATA_COL_WIDTH - 2,
                                      DATA_ROW_HEIGHT - 2));
                }

                //// Draw the text
                foreach (KeyValuePair<Address, String> address in _values)
                {
                    String text = address.Value;
                    int x = address.Key.Col - _firstColumn;
                    int y = address.Key.Row - _firstRow;
                    float height = e.Graphics.MeasureString(text, regularFont).Height;
                    float width = e.Graphics.MeasureString(text, regularFont).Width;
                    if (x >= 0 && y >= 0)
                    {
                        Region cellClip = new Region(new Rectangle(LABEL_COL_WIDTH + x * DATA_COL_WIDTH + PADDING,
                                                                   LABEL_ROW_HEIGHT + y * DATA_ROW_HEIGHT,
                                                                   DATA_COL_WIDTH - 2 * PADDING,
                                                                   DATA_ROW_HEIGHT));
                        cellClip.Intersect(clip);
                        e.Graphics.Clip = cellClip;
                        e.Graphics.DrawString(
                            text,
                            regularFont,
                            brush,
                            LABEL_COL_WIDTH + x * DATA_COL_WIDTH + PADDING,
                            LABEL_ROW_HEIGHT + y * DATA_ROW_HEIGHT + (DATA_ROW_HEIGHT - height) / 2);
                    }
                }

                // Fill in all focused cells
                FillFocusedCells(e.Graphics, clip);
            }

            /// <summary>
            /// Fills cells that are focused by other clients with color specific to each user.
            /// </summary>
            private void FillFocusedCells(Graphics g, Region clip)
            {
                // for all focused cells, fill them in with their user/editor's specific color
                foreach (KeyValuePair<string, string> entry in _ssp.focusedCells)
                {
                    // Determine the user's color
                    int uniqueUserId = Math.Abs(entry.Value.GetHashCode());
                    Brush brush = new SolidBrush(USER_COLORS[uniqueUserId % 5]);

                    // getting cell's location based on name
                    GetColumnAndRowFromCellName(entry.Key, out int col, out int row);

                        Region focusClip = new Region(new Rectangle(((col - _firstColumn) * DATA_COL_WIDTH) + LABEL_COL_WIDTH,
                                      ((row - _firstRow) * DATA_ROW_HEIGHT) + LABEL_ROW_HEIGHT,
                                      DATA_COL_WIDTH,
                                      DATA_ROW_HEIGHT));

                    focusClip.Intersect(clip);
                    g.Clip = focusClip;

                    // Color in cell
                    g.FillRectangle(
                        brush,
                        new Rectangle(((col - _firstColumn) * DATA_COL_WIDTH) + LABEL_COL_WIDTH,
                                      ((row - _firstRow) * DATA_ROW_HEIGHT) + LABEL_ROW_HEIGHT,
                                      DATA_COL_WIDTH,
                                      DATA_ROW_HEIGHT));
                }
            }

            /// <summary>
            /// Draws a column label.  The columns are indexed beginning with zero.
            /// </summary>
            /// <param name="g"></param>
            /// <param name="x"></param>
            /// <param name="f"></param>
            private void DrawColumnLabel(Graphics g, int x, Font f)
            {
                String label = ((char)('A' + x + _firstColumn)).ToString();
                float height = g.MeasureString(label, f).Height;
                float width = g.MeasureString(label, f).Width;
                g.DrawString(
                      label,
                      f,
                      new SolidBrush(Color.Black),
                      LABEL_COL_WIDTH + x * DATA_COL_WIDTH + (DATA_COL_WIDTH - width) / 2,
                      (LABEL_ROW_HEIGHT - height) / 2);
            }

            /// <summary>
            /// Draws a row label.  The rows are indexed beginning with zero.
            /// </summary>
            /// <param name="g"></param>
            /// <param name="y"></param>
            /// <param name="f"></param>
            private void DrawRowLabel(Graphics g, int y, Font f)
            {
                String label = (y + 1 + _firstRow).ToString();
                float height = g.MeasureString(label, f).Height;
                float width = g.MeasureString(label, f).Width;
                g.DrawString(
                    label,
                    f,
                    new SolidBrush(Color.Black),
                    LABEL_COL_WIDTH - width - PADDING,
                    LABEL_ROW_HEIGHT + y * DATA_ROW_HEIGHT + (DATA_ROW_HEIGHT - height) / 2);
            }

            /// <summary>
            /// Determines which cell, if any, was clicked.  Generates a SelectionChanged event.  All of
            /// the indexes are zero based.
            /// Also activates the input text box in the position of the selected cell.
            /// </summary>
            /// <param name="e"></param>

            protected override void OnMouseClick(MouseEventArgs e)
            {
                base.OnClick(e);

                // computes the column and row index
                int x = (e.X - LABEL_COL_WIDTH) / DATA_COL_WIDTH;
                int y = (e.Y - LABEL_ROW_HEIGHT) / DATA_ROW_HEIGHT;

                // getting cell name
                _ssp.GetCellName(y, x, out string name);

                _ssp.cellInputTextBox.Clear();
                _ssp.cellInputTextBox.Focus();
                if (e.X > LABEL_COL_WIDTH && e.Y > LABEL_ROW_HEIGHT && (x + _firstColumn < COL_COUNT) && (y + _firstRow < ROW_COUNT))
                {
                    _selectedCol = x + _firstColumn;
                    _selectedRow = y + _firstRow;

                    // computing location the cell text input box should be placed at (top left corner point)
                    int cell_x = (x * DATA_COL_WIDTH) + LABEL_COL_WIDTH;
                    int cell_y = (y * DATA_ROW_HEIGHT) + LABEL_ROW_HEIGHT;
                    _ssp.cellInputTextBox.Location = new Point(cell_x, cell_y);

                    _ssp.SelectionChanged?.Invoke(_ssp);
                }

                Invalidate();
            }
        }
    }
}