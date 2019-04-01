namespace sTextEditor
{
    partial class TextEditorWindow
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
            this.TextEditorRichTextBox = new System.Windows.Forms.RichTextBox();
            this.FormatAsNoneRadioButton = new System.Windows.Forms.RadioButton();
            this.FormatAsJsonRadioButton = new System.Windows.Forms.RadioButton();
            this.FormatAsXmlRadioButton = new System.Windows.Forms.RadioButton();
            this.FormattingGroupBox = new System.Windows.Forms.GroupBox();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenFromFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenFromDbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveToDbMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormattingGroupBox.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextEditorRichTextBox
            // 
            this.TextEditorRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextEditorRichTextBox.Location = new System.Drawing.Point(12, 65);
            this.TextEditorRichTextBox.Name = "TextEditorRichTextBox";
            this.TextEditorRichTextBox.Size = new System.Drawing.Size(776, 454);
            this.TextEditorRichTextBox.TabIndex = 1;
            this.TextEditorRichTextBox.Text = "";
            // 
            // FormatAsNoneRadioButton
            // 
            this.FormatAsNoneRadioButton.AutoSize = true;
            this.FormatAsNoneRadioButton.Checked = true;
            this.FormatAsNoneRadioButton.Location = new System.Drawing.Point(6, 19);
            this.FormatAsNoneRadioButton.Name = "FormatAsNoneRadioButton";
            this.FormatAsNoneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.FormatAsNoneRadioButton.TabIndex = 2;
            this.FormatAsNoneRadioButton.TabStop = true;
            this.FormatAsNoneRadioButton.Text = "None";
            this.FormatAsNoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormatAsJsonRadioButton
            // 
            this.FormatAsJsonRadioButton.AutoSize = true;
            this.FormatAsJsonRadioButton.Location = new System.Drawing.Point(63, 19);
            this.FormatAsJsonRadioButton.Name = "FormatAsJsonRadioButton";
            this.FormatAsJsonRadioButton.Size = new System.Drawing.Size(53, 17);
            this.FormatAsJsonRadioButton.TabIndex = 3;
            this.FormatAsJsonRadioButton.Text = "JSON";
            this.FormatAsJsonRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormatAsXmlRadioButton
            // 
            this.FormatAsXmlRadioButton.AutoSize = true;
            this.FormatAsXmlRadioButton.Location = new System.Drawing.Point(122, 19);
            this.FormatAsXmlRadioButton.Name = "FormatAsXmlRadioButton";
            this.FormatAsXmlRadioButton.Size = new System.Drawing.Size(47, 17);
            this.FormatAsXmlRadioButton.TabIndex = 4;
            this.FormatAsXmlRadioButton.Text = "XML";
            this.FormatAsXmlRadioButton.UseVisualStyleBackColor = true;
            // 
            // FormattingGroupBox
            // 
            this.FormattingGroupBox.Controls.Add(this.FormatAsNoneRadioButton);
            this.FormattingGroupBox.Controls.Add(this.FormatAsXmlRadioButton);
            this.FormattingGroupBox.Controls.Add(this.FormatAsJsonRadioButton);
            this.FormattingGroupBox.Location = new System.Drawing.Point(616, 12);
            this.FormattingGroupBox.Name = "FormattingGroupBox";
            this.FormattingGroupBox.Size = new System.Drawing.Size(172, 47);
            this.FormattingGroupBox.TabIndex = 5;
            this.FormattingGroupBox.TabStop = false;
            this.FormattingGroupBox.Text = "FormattingBox";
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MainMenuStrip.TabIndex = 6;
            this.MainMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenMenuItem,
            this.FileSaveMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "File";
            // 
            // FileOpenMenuItem
            // 
            this.FileOpenMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileOpenFromFileMenuItem,
            this.FileOpenFromDbMenuItem});
            this.FileOpenMenuItem.Name = "FileOpenMenuItem";
            this.FileOpenMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FileOpenMenuItem.Text = "Open";
            // 
            // FileOpenFromFileMenuItem
            // 
            this.FileOpenFromFileMenuItem.Name = "FileOpenFromFileMenuItem";
            this.FileOpenFromFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FileOpenFromFileMenuItem.Text = "From file";
            // 
            // FileOpenFromDbMenuItem
            // 
            this.FileOpenFromDbMenuItem.Name = "FileOpenFromDbMenuItem";
            this.FileOpenFromDbMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FileOpenFromDbMenuItem.Text = "From database";
            // 
            // FileSaveMenuItem
            // 
            this.FileSaveMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileSaveToFileMenuItem,
            this.FileSaveToDbMenuItem});
            this.FileSaveMenuItem.Name = "FileSaveMenuItem";
            this.FileSaveMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FileSaveMenuItem.Text = "Save";
            // 
            // FileSaveToFileMenuItem
            // 
            this.FileSaveToFileMenuItem.Name = "FileSaveToFileMenuItem";
            this.FileSaveToFileMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FileSaveToFileMenuItem.Text = "To file";
            // 
            // FileSaveToDbMenuItem
            // 
            this.FileSaveToDbMenuItem.Name = "FileSaveToDbMenuItem";
            this.FileSaveToDbMenuItem.Size = new System.Drawing.Size(180, 22);
            this.FileSaveToDbMenuItem.Text = "To database";
            // 
            // TextEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.FormattingGroupBox);
            this.Controls.Add(this.TextEditorRichTextBox);
            this.Controls.Add(this.MainMenuStrip);
            this.MainMenuStrip = this.MainMenuStrip;
            this.Name = "TextEditorWindow";
            this.Text = "sTextEditor";
            this.FormattingGroupBox.ResumeLayout(false);
            this.FormattingGroupBox.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox TextEditorRichTextBox;
        private System.Windows.Forms.RadioButton FormatAsNoneRadioButton;
        private System.Windows.Forms.RadioButton FormatAsJsonRadioButton;
        private System.Windows.Forms.RadioButton FormatAsXmlRadioButton;
        private System.Windows.Forms.GroupBox FormattingGroupBox;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenFromFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenFromDbMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveToFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveToDbMenuItem;
    }
}

