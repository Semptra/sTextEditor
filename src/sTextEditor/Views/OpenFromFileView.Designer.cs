namespace sTextEditor.Views
{
    partial class OpenFromFileView
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.FileSizeTextBox = new System.Windows.Forms.TextBox();
            this.FileNameLabel = new System.Windows.Forms.Label();
            this.FileSizeLabel = new System.Windows.Forms.Label();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.FileContentPreviewLabel = new System.Windows.Forms.Label();
            this.FileContentPreview = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameTextBox.Location = new System.Drawing.Point(67, 10);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(323, 20);
            this.FileNameTextBox.TabIndex = 0;
            // 
            // FileSizeTextBox
            // 
            this.FileSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileSizeTextBox.Location = new System.Drawing.Point(446, 10);
            this.FileSizeTextBox.Name = "FileSizeTextBox";
            this.FileSizeTextBox.ReadOnly = true;
            this.FileSizeTextBox.Size = new System.Drawing.Size(154, 20);
            this.FileSizeTextBox.TabIndex = 1;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(9, 12);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(52, 13);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "File name";
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.AutoSize = true;
            this.FileSizeLabel.Location = new System.Drawing.Point(396, 12);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(44, 13);
            this.FileSizeLabel.TabIndex = 3;
            this.FileSizeLabel.Text = "File size";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(606, 7);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(131, 23);
            this.OpenFileButton.TabIndex = 4;
            this.OpenFileButton.Text = "Open file";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            // 
            // FileContentPreviewLabel
            // 
            this.FileContentPreviewLabel.AutoSize = true;
            this.FileContentPreviewLabel.Location = new System.Drawing.Point(9, 36);
            this.FileContentPreviewLabel.Name = "FileContentPreviewLabel";
            this.FileContentPreviewLabel.Size = new System.Drawing.Size(63, 13);
            this.FileContentPreviewLabel.TabIndex = 6;
            this.FileContentPreviewLabel.Text = "File preview";
            // 
            // FileContentPreview
            // 
            this.FileContentPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileContentPreview.Location = new System.Drawing.Point(3, 52);
            this.FileContentPreview.Name = "FileContentPreview";
            this.FileContentPreview.ReadOnly = true;
            this.FileContentPreview.Size = new System.Drawing.Size(734, 387);
            this.FileContentPreview.TabIndex = 7;
            this.FileContentPreview.Text = "";
            // 
            // OpenFromFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileContentPreview);
            this.Controls.Add(this.FileContentPreviewLabel);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileSizeTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Name = "OpenFromFileView";
            this.Size = new System.Drawing.Size(740, 442);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox FileSizeTextBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Label FileContentPreviewLabel;
        private System.Windows.Forms.RichTextBox FileContentPreview;
    }
}
