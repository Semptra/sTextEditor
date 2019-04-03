namespace sTextEditor.Views
{
    partial class SaveToFileView
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
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.FileContentPreview = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileNameTextBox.Location = new System.Drawing.Point(100, 15);
            this.FileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(484, 26);
            this.FileNameTextBox.TabIndex = 0;
            // 
            // FileSizeTextBox
            // 
            this.FileSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileSizeTextBox.Location = new System.Drawing.Point(669, 15);
            this.FileSizeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileSizeTextBox.Name = "FileSizeTextBox";
            this.FileSizeTextBox.ReadOnly = true;
            this.FileSizeTextBox.Size = new System.Drawing.Size(230, 26);
            this.FileSizeTextBox.TabIndex = 1;
            // 
            // FileNameLabel
            // 
            this.FileNameLabel.AutoSize = true;
            this.FileNameLabel.Location = new System.Drawing.Point(14, 18);
            this.FileNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileNameLabel.Name = "FileNameLabel";
            this.FileNameLabel.Size = new System.Drawing.Size(78, 20);
            this.FileNameLabel.TabIndex = 2;
            this.FileNameLabel.Text = "File name";
            // 
            // FileSizeLabel
            // 
            this.FileSizeLabel.AutoSize = true;
            this.FileSizeLabel.Location = new System.Drawing.Point(594, 18);
            this.FileSizeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileSizeLabel.Name = "FileSizeLabel";
            this.FileSizeLabel.Size = new System.Drawing.Size(66, 20);
            this.FileSizeLabel.TabIndex = 3;
            this.FileSizeLabel.Text = "File size";
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(909, 11);
            this.SaveFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(196, 35);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.Text = "Save file";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            // 
            // FileContentPreview
            // 
            this.FileContentPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileContentPreview.Location = new System.Drawing.Point(4, 51);
            this.FileContentPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileContentPreview.Name = "FileContentPreview";
            this.FileContentPreview.ReadOnly = true;
            this.FileContentPreview.Size = new System.Drawing.Size(1100, 629);
            this.FileContentPreview.TabIndex = 7;
            this.FileContentPreview.Text = "";
            // 
            // SaveToFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FileContentPreview);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.FileSizeLabel);
            this.Controls.Add(this.FileNameLabel);
            this.Controls.Add(this.FileSizeTextBox);
            this.Controls.Add(this.FileNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaveToFileView";
            this.Size = new System.Drawing.Size(1110, 680);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.TextBox FileSizeTextBox;
        private System.Windows.Forms.Label FileNameLabel;
        private System.Windows.Forms.Label FileSizeLabel;
        private System.Windows.Forms.Button SaveFileButton;
        private System.Windows.Forms.RichTextBox FileContentPreview;
    }
}
