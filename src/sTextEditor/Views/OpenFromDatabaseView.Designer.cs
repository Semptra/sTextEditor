namespace sTextEditor.Views
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
            ((System.ComponentModel.ISupportInitialize)(this.DbFilesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DbFilesDataGrid
            // 
            this.DbFilesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DbFilesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DbFilesDataGrid.Location = new System.Drawing.Point(14, 32);
            this.DbFilesDataGrid.MultiSelect = false;
            this.DbFilesDataGrid.Name = "DbFilesDataGrid";
            this.DbFilesDataGrid.ReadOnly = true;
            this.DbFilesDataGrid.Size = new System.Drawing.Size(725, 419);
            this.DbFilesDataGrid.TabIndex = 0;
            // 
            // RefreshDbFilesButton
            // 
            this.RefreshDbFilesButton.Location = new System.Drawing.Point(14, 457);
            this.RefreshDbFilesButton.Name = "RefreshDbFilesButton";
            this.RefreshDbFilesButton.Size = new System.Drawing.Size(75, 23);
            this.RefreshDbFilesButton.TabIndex = 1;
            this.RefreshDbFilesButton.Text = "Refresh";
            this.RefreshDbFilesButton.UseVisualStyleBackColor = true;
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(608, 3);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(131, 23);
            this.OpenFileButton.TabIndex = 9;
            this.OpenFileButton.Text = "Open file";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.AutoSize = true;
            this.FileSizeLabel.Location = new System.Drawing.Point(398, 8);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(44, 13);
            this.FileSizeLabel.TabIndex = 8;
            this.FileSizeLabel.Text = "File size";
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(11, 8);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(52, 13);
            this.FileNameLabel.TabIndex = 7;
            this.FileNameLabel.Text = "File name";
            // 
            // FileSizeTextBox
            // 
            this.FileSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileSizeTextBox.Location = new System.Drawing.Point(448, 6);
            this.FileSizeTextBox.Name = "FileSizeTextBox";
            this.FileSizeTextBox.ReadOnly = true;
            this.FileSizeTextBox.Size = new System.Drawing.Size(154, 20);
            this.FileSizeTextBox.TabIndex = 6;
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameTextBox.Location = new System.Drawing.Point(69, 6);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(323, 20);
            this.FileNameTextBox.TabIndex = 5;
            // 
            // OpenFromDatabaseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileSizeTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.RefreshDbFilesButton);
            this.Controls.Add(this.DbFilesDataGrid);
            this.Name = "OpenFromDatabaseView";
            this.Size = new System.Drawing.Size(747, 489);
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
    }
}
