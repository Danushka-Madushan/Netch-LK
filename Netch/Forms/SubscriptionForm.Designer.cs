﻿namespace Netch.Forms
{
    partial class SubscriptionForm
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
            this.components = new System.ComponentModel.Container();
            this.AddSubscriptionBox = new System.Windows.Forms.GroupBox();
            this.RemarkLabel = new System.Windows.Forms.Label();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.LinkTextBox = new System.Windows.Forms.TextBox();
            this.UserAgentLabel = new System.Windows.Forms.Label();
            this.UserAgentTextBox = new System.Windows.Forms.TextBox();
            this.UnselectButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SubscriptionLinkListView = new System.Windows.Forms.ListView();
            this.EnableColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.RemarkColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.LinkColumnHeader = new System.Windows.Forms.ColumnHeader();
            this.UserAgentHeader = new System.Windows.Forms.ColumnHeader();
            this.pContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteServersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AddSubscriptionBox.SuspendLayout();
            this.pContextMenuStrip.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddSubscriptionBox
            // 
            this.AddSubscriptionBox.Controls.Add(this.RemarkLabel);
            this.AddSubscriptionBox.Controls.Add(this.RemarkTextBox);
            this.AddSubscriptionBox.Controls.Add(this.LinkLabel);
            this.AddSubscriptionBox.Controls.Add(this.LinkTextBox);
            this.AddSubscriptionBox.Controls.Add(this.UserAgentLabel);
            this.AddSubscriptionBox.Controls.Add(this.UserAgentTextBox);
            this.AddSubscriptionBox.Controls.Add(this.UnselectButton);
            this.AddSubscriptionBox.Controls.Add(this.AddButton);
            this.AddSubscriptionBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddSubscriptionBox.Location = new System.Drawing.Point(8, 248);
            this.AddSubscriptionBox.Name = "AddSubscriptionBox";
            this.AddSubscriptionBox.Size = new System.Drawing.Size(668, 135);
            this.AddSubscriptionBox.TabIndex = 1;
            this.AddSubscriptionBox.TabStop = false;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Location = new System.Drawing.Point(11, 19);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(53, 17);
            this.RemarkLabel.TabIndex = 1;
            this.RemarkLabel.Text = "Remark";
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Location = new System.Drawing.Point(109, 16);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(545, 23);
            this.RemarkTextBox.TabIndex = 2;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(11, 48);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(31, 17);
            this.LinkLabel.TabIndex = 3;
            this.LinkLabel.Text = "Link";
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.Location = new System.Drawing.Point(109, 45);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(545, 23);
            this.LinkTextBox.TabIndex = 4;
            // 
            // UserAgentLabel
            // 
            this.UserAgentLabel.AutoSize = true;
            this.UserAgentLabel.Location = new System.Drawing.Point(11, 77);
            this.UserAgentLabel.Name = "UserAgentLabel";
            this.UserAgentLabel.Size = new System.Drawing.Size(74, 17);
            this.UserAgentLabel.TabIndex = 5;
            this.UserAgentLabel.Text = "User-Agent";
            // 
            // UserAgentTextBox
            // 
            this.UserAgentTextBox.Location = new System.Drawing.Point(109, 74);
            this.UserAgentTextBox.Name = "UserAgentTextBox";
            this.UserAgentTextBox.Size = new System.Drawing.Size(545, 23);
            this.UserAgentTextBox.TabIndex = 6;
            // 
            // UnselectButton
            // 
            this.UnselectButton.Location = new System.Drawing.Point(448, 103);
            this.UnselectButton.Name = "UnselectButton";
            this.UnselectButton.Size = new System.Drawing.Size(87, 26);
            this.UnselectButton.TabIndex = 7;
            this.UnselectButton.Text = "Unselect";
            this.UnselectButton.UseVisualStyleBackColor = true;
            this.UnselectButton.Click += new System.EventHandler(this.UnselectButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(541, 103);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(113, 26);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SubscriptionLinkListView
            // 
            this.SubscriptionLinkListView.AllowColumnReorder = true;
            this.SubscriptionLinkListView.CheckBoxes = true;
            this.SubscriptionLinkListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EnableColumnHeader,
            this.RemarkColumnHeader,
            this.LinkColumnHeader,
            this.UserAgentHeader});
            this.SubscriptionLinkListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubscriptionLinkListView.FullRowSelect = true;
            this.SubscriptionLinkListView.HideSelection = false;
            this.SubscriptionLinkListView.Location = new System.Drawing.Point(8, 8);
            this.SubscriptionLinkListView.MultiSelect = false;
            this.SubscriptionLinkListView.Name = "SubscriptionLinkListView";
            this.SubscriptionLinkListView.Size = new System.Drawing.Size(668, 234);
            this.SubscriptionLinkListView.TabIndex = 0;
            this.SubscriptionLinkListView.UseCompatibleStateImageBehavior = false;
            this.SubscriptionLinkListView.View = System.Windows.Forms.View.Details;
            this.SubscriptionLinkListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.SubscriptionLinkListView_ItemChecked);
            this.SubscriptionLinkListView.SelectedIndexChanged += new System.EventHandler(this.SubscriptionLinkListView_SelectedIndexChanged);
            this.SubscriptionLinkListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SubscriptionLinkListView_MouseUp);
            // 
            // EnableColumnHeader
            // 
            this.EnableColumnHeader.Text = "Status";
            // 
            // RemarkColumnHeader
            // 
            this.RemarkColumnHeader.Text = "Remark";
            this.RemarkColumnHeader.Width = 120;
            // 
            // LinkColumnHeader
            // 
            this.LinkColumnHeader.Text = "Link";
            this.LinkColumnHeader.Width = 364;
            // 
            // UserAgentHeader
            // 
            this.UserAgentHeader.Text = "User-Agent";
            this.UserAgentHeader.Width = 120;
            // 
            // pContextMenuStrip
            // 
            this.pContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteToolStripMenuItem,
            this.DeleteServersToolStripMenuItem,
            this.CopyLinkToolStripMenuItem});
            this.pContextMenuStrip.Name = "pContextMenuStrip";
            this.pContextMenuStrip.Size = new System.Drawing.Size(161, 70);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // DeleteServersToolStripMenuItem
            // 
            this.DeleteServersToolStripMenuItem.Name = "DeleteServersToolStripMenuItem";
            this.DeleteServersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.DeleteServersToolStripMenuItem.Text = "Delete Servers";
            this.DeleteServersToolStripMenuItem.Click += new System.EventHandler(this.DeleteServersToolStripMenuItem_Click);
            // 
            // CopyLinkToolStripMenuItem
            // 
            this.CopyLinkToolStripMenuItem.Name = "CopyLinkToolStripMenuItem";
            this.CopyLinkToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.CopyLinkToolStripMenuItem.Text = "Copy link";
            this.CopyLinkToolStripMenuItem.Click += new System.EventHandler(this.CopyLinkToolStripMenuItem_Click);
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayoutPanel.Controls.Add(this.SubscriptionLinkListView, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.AddSubscriptionBox, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.99213F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.00787F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(684, 391);
            this.MainTableLayoutPanel.TabIndex = 11;
            // 
            // SubscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SubscriptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subscription";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubscriptionForm_FormClosing);
            this.AddSubscriptionBox.ResumeLayout(false);
            this.AddSubscriptionBox.PerformLayout();
            this.pContextMenuStrip.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.ColumnHeader EnableColumnHeader;

        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Button UnselectButton;
        private System.Windows.Forms.GroupBox AddSubscriptionBox;
        private System.Windows.Forms.Label RemarkLabel;
        private System.Windows.Forms.TextBox LinkTextBox;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListView SubscriptionLinkListView;
        private System.Windows.Forms.ColumnHeader RemarkColumnHeader;
        private System.Windows.Forms.ColumnHeader LinkColumnHeader;
        private System.Windows.Forms.ContextMenuStrip pContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyLinkToolStripMenuItem;
        private System.Windows.Forms.Label UserAgentLabel;
        private System.Windows.Forms.TextBox UserAgentTextBox;
        private System.Windows.Forms.ColumnHeader UserAgentHeader;

        #endregion

        private System.Windows.Forms.ToolStripMenuItem DeleteServersToolStripMenuItem;
    }
}