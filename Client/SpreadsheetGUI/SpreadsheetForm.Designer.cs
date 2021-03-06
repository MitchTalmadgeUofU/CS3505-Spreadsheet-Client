﻿using System.Windows.Forms;

namespace SpreadsheetGUI
{
    partial class SpreadsheetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpreadsheetForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professionalVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.connectedServerTextBox = new System.Windows.Forms.TextBox();
            this.documentNameDropdown = new System.Windows.Forms.ComboBox();
            this.connectedServerLabel = new System.Windows.Forms.TextBox();
            this.documentNameLabel = new System.Windows.Forms.TextBox();
            this.cellNameLabel = new System.Windows.Forms.TextBox();
            this.editorNameTextBox = new System.Windows.Forms.TextBox();
            this.editorValueTextBox = new System.Windows.Forms.TextBox();
            this.cellValueLabel = new System.Windows.Forms.TextBox();
            this.spreadsheetPanel = new SS.SpreadsheetPanel();
            this.undoButton = new System.Windows.Forms.Button();
            this.revertButton = new System.Windows.Forms.Button();
            this.serverConnect_backgroundworker = new System.ComponentModel.BackgroundWorker();
            this.menuStrip.SuspendLayout();
            this.topTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.topTableLayoutPanel.SetColumnSpan(this.menuStrip, 6);
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.upgradeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1618, 32);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // upgradeToolStripMenuItem
            // 
            this.upgradeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.professionalVersionToolStripMenuItem});
            this.upgradeToolStripMenuItem.Name = "upgradeToolStripMenuItem";
            this.upgradeToolStripMenuItem.Size = new System.Drawing.Size(93, 28);
            this.upgradeToolStripMenuItem.Text = "Upgrade";
            // 
            // professionalVersionToolStripMenuItem
            // 
            this.professionalVersionToolStripMenuItem.Name = "professionalVersionToolStripMenuItem";
            this.professionalVersionToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.professionalVersionToolStripMenuItem.Text = "Professional Version";
            this.professionalVersionToolStripMenuItem.Click += new System.EventHandler(this.professionalVersionToolStripMenuItem_Click);
            // 
            // topTableLayoutPanel
            // 
            this.topTableLayoutPanel.AutoSize = true;
            this.topTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topTableLayoutPanel.ColumnCount = 6;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.Controls.Add(this.textBox2, 5, 1);
            this.topTableLayoutPanel.Controls.Add(this.textBox1, 4, 1);
            this.topTableLayoutPanel.Controls.Add(this.connectedServerTextBox, 3, 2);
            this.topTableLayoutPanel.Controls.Add(this.documentNameDropdown, 2, 2);
            this.topTableLayoutPanel.Controls.Add(this.connectedServerLabel, 3, 1);
            this.topTableLayoutPanel.Controls.Add(this.documentNameLabel, 2, 1);
            this.topTableLayoutPanel.Controls.Add(this.cellNameLabel, 0, 1);
            this.topTableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.editorNameTextBox, 0, 2);
            this.topTableLayoutPanel.Controls.Add(this.editorValueTextBox, 1, 2);
            this.topTableLayoutPanel.Controls.Add(this.cellValueLabel, 1, 1);
            this.topTableLayoutPanel.Controls.Add(this.spreadsheetPanel, 0, 3);
            this.topTableLayoutPanel.Controls.Add(this.undoButton, 4, 2);
            this.topTableLayoutPanel.Controls.Add(this.revertButton, 5, 2);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 4;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(1618, 892);
            this.topTableLayoutPanel.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(1416, 34);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "Revert:";
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(1214, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(198, 26);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Undo:";
            // 
            // connectedServerTextBox
            // 
            this.connectedServerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedServerTextBox.Location = new System.Drawing.Point(729, 66);
            this.connectedServerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.connectedServerTextBox.Name = "connectedServerTextBox";
            this.connectedServerTextBox.Size = new System.Drawing.Size(481, 26);
            this.connectedServerTextBox.TabIndex = 11;
            this.connectedServerTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.connectedServerTextBox_KeyUp);
            // 
            // documentNameDropdown
            // 
            this.documentNameDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentNameDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.documentNameDropdown.Location = new System.Drawing.Point(406, 66);
            this.documentNameDropdown.Margin = new System.Windows.Forms.Padding(2);
            this.documentNameDropdown.Name = "documentNameDropdown";
            this.documentNameDropdown.Size = new System.Drawing.Size(319, 28);
            this.documentNameDropdown.TabIndex = 10;
            this.documentNameDropdown.SelectedIndexChanged += new System.EventHandler(this.documentNameDropdown_SelectedIndexChanged);
            // 
            // connectedServerLabel
            // 
            this.connectedServerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedServerLabel.Location = new System.Drawing.Point(729, 34);
            this.connectedServerLabel.Margin = new System.Windows.Forms.Padding(2);
            this.connectedServerLabel.Name = "connectedServerLabel";
            this.connectedServerLabel.ReadOnly = true;
            this.connectedServerLabel.Size = new System.Drawing.Size(481, 26);
            this.connectedServerLabel.TabIndex = 9;
            this.connectedServerLabel.Text = "Connected Server:";
            // 
            // documentNameLabel
            // 
            this.documentNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentNameLabel.Location = new System.Drawing.Point(406, 34);
            this.documentNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.documentNameLabel.Name = "documentNameLabel";
            this.documentNameLabel.ReadOnly = true;
            this.documentNameLabel.Size = new System.Drawing.Size(319, 26);
            this.documentNameLabel.TabIndex = 8;
            this.documentNameLabel.Text = "Document Name:";
            // 
            // cellNameLabel
            // 
            this.cellNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellNameLabel.Location = new System.Drawing.Point(2, 34);
            this.cellNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.cellNameLabel.Name = "cellNameLabel";
            this.cellNameLabel.ReadOnly = true;
            this.cellNameLabel.Size = new System.Drawing.Size(198, 26);
            this.cellNameLabel.TabIndex = 5;
            this.cellNameLabel.Text = "Cell Name:";
            // 
            // editorNameTextBox
            // 
            this.editorNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorNameTextBox.Location = new System.Drawing.Point(2, 66);
            this.editorNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.editorNameTextBox.Name = "editorNameTextBox";
            this.editorNameTextBox.ReadOnly = true;
            this.editorNameTextBox.Size = new System.Drawing.Size(198, 26);
            this.editorNameTextBox.TabIndex = 2;
            // 
            // editorValueTextBox
            // 
            this.editorValueTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editorValueTextBox.Location = new System.Drawing.Point(204, 66);
            this.editorValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.editorValueTextBox.Name = "editorValueTextBox";
            this.editorValueTextBox.ReadOnly = true;
            this.editorValueTextBox.Size = new System.Drawing.Size(198, 26);
            this.editorValueTextBox.TabIndex = 4;
            // 
            // cellValueLabel
            // 
            this.cellValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellValueLabel.Location = new System.Drawing.Point(204, 34);
            this.cellValueLabel.Margin = new System.Windows.Forms.Padding(2);
            this.cellValueLabel.Name = "cellValueLabel";
            this.cellValueLabel.ReadOnly = true;
            this.cellValueLabel.Size = new System.Drawing.Size(198, 26);
            this.cellValueLabel.TabIndex = 7;
            this.cellValueLabel.Text = "Cell Value:";
            // 
            // spreadsheetPanel
            // 
            this.topTableLayoutPanel.SetColumnSpan(this.spreadsheetPanel, 6);
            this.spreadsheetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetPanel.Location = new System.Drawing.Point(0, 96);
            this.spreadsheetPanel.Margin = new System.Windows.Forms.Padding(0);
            this.spreadsheetPanel.Name = "spreadsheetPanel";
            this.spreadsheetPanel.ReadOnly = false;
            this.spreadsheetPanel.Size = new System.Drawing.Size(1618, 796);
            this.spreadsheetPanel.TabIndex = 0;
            this.spreadsheetPanel.SelectionChanged += new SS.SelectionChangedHandler(this.SpreadsheetPanel_SelectionChanged);
            this.spreadsheetPanel.CellEditEnter += new SS.CellInputHandler(this.SpreadsheetPanel_CellEditEnter);
            this.spreadsheetPanel.CellEditDown += new SS.CellMovementHandler(this.SpreadsheetPanel_CellEditDown);
            this.spreadsheetPanel.CellEditUp += new SS.CellMovementHandler(this.SpreadsheetPanel_CellEditUp);
            this.spreadsheetPanel.CellEditRight += new SS.CellMovementHandler(this.SpreadsheetPanel_CellEditRight);
            this.spreadsheetPanel.CellEditLeft += new SS.CellMovementHandler(this.SpreadsheetPanel_CellEditLeft);
            // 
            // undoButton
            // 
            this.undoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.undoButton.Location = new System.Drawing.Point(1213, 65);
            this.undoButton.Margin = new System.Windows.Forms.Padding(1);
            this.undoButton.Name = "undoButton";
            this.undoButton.Size = new System.Drawing.Size(200, 30);
            this.undoButton.TabIndex = 14;
            this.undoButton.Text = "Undo";
            this.undoButton.UseVisualStyleBackColor = true;
            this.undoButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.undoButton_MouseClick);
            // 
            // revertButton
            // 
            this.revertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revertButton.Location = new System.Drawing.Point(1415, 65);
            this.revertButton.Margin = new System.Windows.Forms.Padding(1);
            this.revertButton.Name = "revertButton";
            this.revertButton.Size = new System.Drawing.Size(202, 30);
            this.revertButton.TabIndex = 15;
            this.revertButton.Text = "Revert";
            this.revertButton.UseVisualStyleBackColor = true;
            this.revertButton.Click += new System.EventHandler(this.revertButton_Click);
            // 
            // SpreadsheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1618, 892);
            this.Controls.Add(this.topTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SpreadsheetForm";
            this.Text = "Untitled - Spreadsheet 3505";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseSpreadsheet);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.topTableLayoutPanel.ResumeLayout(false);
            this.topTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SS.SpreadsheetPanel spreadsheetPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.TextBox editorValueTextBox;
        private System.Windows.Forms.TextBox editorNameTextBox;
        private System.Windows.Forms.TextBox cellNameLabel;
        private System.Windows.Forms.TextBox cellValueLabel;
        private System.Windows.Forms.ToolStripMenuItem upgradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professionalVersionToolStripMenuItem;
        private System.Windows.Forms.TextBox connectedServerTextBox;
        private System.Windows.Forms.ComboBox documentNameDropdown;
        private System.Windows.Forms.TextBox connectedServerLabel;
        private System.Windows.Forms.TextBox documentNameLabel;
        private System.ComponentModel.BackgroundWorker serverConnect_backgroundworker;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button undoButton;
        private Button revertButton;
    }
}

