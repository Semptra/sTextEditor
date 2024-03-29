﻿namespace sTextEditor.Views
{
    partial class OpenFromDatabaseView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DbFilesDataGrid = new System.Windows.Forms.DataGridView();
            this.RefreshDbFilesButton = new System.Windows.Forms.Button();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileSizeTextBox = new System.Windows.Forms.TextBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileContentPreview = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DbFilesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DbFilesDataGrid
            // 
            this.DbFilesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DbFilesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DbFilesDataGrid.Location = new System.Drawing.Point(21, 49);
            this.DbFilesDataGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DbFilesDataGrid.MultiSelect = false;
            this.DbFilesDataGrid.Name = "DbFilesDataGrid";
            this.DbFilesDataGrid.ReadOnly = true;
            this.DbFilesDataGrid.Size = new System.Drawing.Size(526, 645);
            this.DbFilesDataGrid.TabIndex = 0;
            // 
            // RefreshDbFilesButton
            // 
            this.RefreshDbFilesButton.Location = new System.Drawing.Point(21, 703);
            this.RefreshDbFilesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshDbFilesButton.Name = "RefreshDbFilesButton";
            this.RefreshDbFilesButton.Size = new System.Drawing.Size(112, 35);
            this.RefreshDbFilesButton.TabIndex = 1;
            this.RefreshDbFilesButton.Text = "Refresh";
            this.RefreshDbFilesButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(912, 5);
            this.OpenFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(196, 35);
            this.OpenFileButton.TabIndex = 9;
            this.OpenFileButton.Text = "Open file";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.AutoSize = true;
            this.FileSizeLabel.Location = new System.Drawing.Point(555, 12);
            this.FileSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(66, 20);
            this.FileSizeLabel.TabIndex = 8;
            this.FileSizeLabel.Text = "File size";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(16, 12);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(78, 20);
            this.FileNameLabel.TabIndex = 7;
            this.FileNameLabel.Text = "File name";
            // 
            // FileSizeTextBox
            // 
            this.FileSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileSizeTextBox.Location = new System.Drawing.Point(629, 9);
            this.FileSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileSizeTextBox.Name = "FileSizeTextBox";
            this.FileSizeTextBox.ReadOnly = true;
            this.FileSizeTextBox.Size = new System.Drawing.Size(275, 26);
            this.FileSizeTextBox.TabIndex = 6;
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameTextBox.Location = new System.Drawing.Point(104, 9);
            this.FileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(443, 26);
            this.FileNameTextBox.TabIndex = 5;
            // 
            // FileContentPreview
            // 
            this.FileContentPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileContentPreview.Location = new System.Drawing.Point(555, 49);
            this.FileContentPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileContentPreview.Name = "FileContentPreview";
            this.FileContentPreview.ReadOnly = true;
            this.FileContentPreview.Size = new System.Drawing.Size(555, 645);
            this.FileContentPreview.TabIndex = 10;
            this.FileContentPreview.Text = "";
            // 
            // OpenFromDatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileContentPreview);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileSizeTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.RefreshDbFilesButton);
            this.Controls.Add(this.DbFilesDataGrid);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpenFromDatabaseView";
            this.Size = new System.Drawing.Size(1120, 752);
            ((System.ComponentModel.ISupportInitialize)(this.DbFilesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbFilesDataGrid;
        private System.Windows.Forms.Button RefreshDbFilesButton;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.TextBox FileSizeTextBox;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.RichTextBox FileContentPreview;
    }
}
