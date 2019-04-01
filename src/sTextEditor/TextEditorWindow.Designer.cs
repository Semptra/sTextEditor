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
            this.FormattingGroupBox.SuspendLayout();
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
            // TextEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.FormattingGroupBox);
            this.Controls.Add(this.TextEditorRichTextBox);
            this.Name = "TextEditorWindow";
            this.Text = "sTextEditor";
            this.FormattingGroupBox.ResumeLayout(false);
            this.FormattingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox TextEditorRichTextBox;
        private System.Windows.Forms.RadioButton FormatAsNoneRadioButton;
        private System.Windows.Forms.RadioButton FormatAsJsonRadioButton;
        private System.Windows.Forms.RadioButton FormatAsXmlRadioButton;
        private System.Windows.Forms.GroupBox FormattingGroupBox;
    }
}

