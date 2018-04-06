﻿namespace SpreadsheetGUI
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
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutSpreadsheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professionalVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.connectedServerTextBox = new System.Windows.Forms.TextBox();
            this.documentNameTextBox = new System.Windows.Forms.TextBox();
            this.connectedServerLabel = new System.Windows.Forms.TextBox();
            this.documentNameLabel = new System.Windows.Forms.TextBox();
            this.cellNameLabel = new System.Windows.Forms.TextBox();
            this.editorNameTextBox = new System.Windows.Forms.TextBox();
            this.editorValueTextBox = new System.Windows.Forms.TextBox();
            this.cellValueLabel = new System.Windows.Forms.TextBox();
            this.spreadsheetPanel = new SS.SpreadsheetPanel();
            this.menuStrip.SuspendLayout();
            this.topTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.topTableLayoutPanel.SetColumnSpan(this.menuStrip, 4);
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
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
            this.openToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.DisconnectToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutSpreadsheetToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutSpreadsheetToolStripMenuItem
            // 
            this.aboutSpreadsheetToolStripMenuItem.Name = "aboutSpreadsheetToolStripMenuItem";
            this.aboutSpreadsheetToolStripMenuItem.Size = new System.Drawing.Size(249, 30);
            this.aboutSpreadsheetToolStripMenuItem.Text = "About Spreadsheet";
            this.aboutSpreadsheetToolStripMenuItem.Click += new System.EventHandler(this.AboutSpreadsheetToolStripMenuItem_Click);
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
            this.topTableLayoutPanel.ColumnCount = 4;
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.topTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.topTableLayoutPanel.Controls.Add(this.connectedServerTextBox, 3, 2);
            this.topTableLayoutPanel.Controls.Add(this.documentNameTextBox, 2, 2);
            this.topTableLayoutPanel.Controls.Add(this.connectedServerLabel, 3, 1);
            this.topTableLayoutPanel.Controls.Add(this.documentNameLabel, 2, 1);
            this.topTableLayoutPanel.Controls.Add(this.cellNameLabel, 0, 1);
            this.topTableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.topTableLayoutPanel.Controls.Add(this.editorNameTextBox, 0, 2);
            this.topTableLayoutPanel.Controls.Add(this.editorValueTextBox, 1, 2);
            this.topTableLayoutPanel.Controls.Add(this.cellValueLabel, 1, 1);
            this.topTableLayoutPanel.Controls.Add(this.spreadsheetPanel, 0, 3);
            this.topTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.topTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topTableLayoutPanel.Name = "topTableLayoutPanel";
            this.topTableLayoutPanel.RowCount = 4;
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.topTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.topTableLayoutPanel.Size = new System.Drawing.Size(1618, 892);
            this.topTableLayoutPanel.TabIndex = 3;
            // 
            // connectedServerTextBox
            // 
            this.connectedServerTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedServerTextBox.Location = new System.Drawing.Point(911, 66);
            this.connectedServerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.connectedServerTextBox.Name = "connectedServerTextBox";
            this.connectedServerTextBox.Size = new System.Drawing.Size(705, 26);
            this.connectedServerTextBox.TabIndex = 11;
            // 
            // documentNameTextBox
            // 
            this.documentNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.documentNameTextBox.Location = new System.Drawing.Point(406, 66);
            this.documentNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.documentNameTextBox.Name = "documentNameTextBox";
            this.documentNameTextBox.Size = new System.Drawing.Size(501, 26);
            this.documentNameTextBox.TabIndex = 10;
            // 
            // connectedServerLabel
            // 
            this.connectedServerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectedServerLabel.Location = new System.Drawing.Point(911, 34);
            this.connectedServerLabel.Margin = new System.Windows.Forms.Padding(2);
            this.connectedServerLabel.Name = "connectedServerLabel";
            this.connectedServerLabel.ReadOnly = true;
            this.connectedServerLabel.Size = new System.Drawing.Size(705, 26);
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
            this.documentNameLabel.Size = new System.Drawing.Size(501, 26);
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
            this.topTableLayoutPanel.SetColumnSpan(this.spreadsheetPanel, 4);
            this.spreadsheetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheetPanel.Location = new System.Drawing.Point(0, 94);
            this.spreadsheetPanel.Margin = new System.Windows.Forms.Padding(0);
            this.spreadsheetPanel.Name = "spreadsheetPanel";
            this.spreadsheetPanel.Size = new System.Drawing.Size(1618, 798);
            this.spreadsheetPanel.TabIndex = 0;
            this.spreadsheetPanel.SelectionChanged += new SS.SelectionChangedHandler(this.SpreadsheetPanel_SelectionChanged);
            this.spreadsheetPanel.CellEditEnter += new SS.CellInputHandler(this.SpreadsheetPanel_CellEditEnter);
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
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutSpreadsheetToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel topTableLayoutPanel;
        private System.Windows.Forms.TextBox editorValueTextBox;
        private System.Windows.Forms.TextBox editorNameTextBox;
        private System.Windows.Forms.TextBox cellNameLabel;
        private System.Windows.Forms.TextBox cellValueLabel;
        private System.Windows.Forms.ToolStripMenuItem upgradeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professionalVersionToolStripMenuItem;
        private System.Windows.Forms.TextBox connectedServerTextBox;
        private System.Windows.Forms.TextBox documentNameTextBox;
        private System.Windows.Forms.TextBox connectedServerLabel;
        private System.Windows.Forms.TextBox documentNameLabel;
    }
}

