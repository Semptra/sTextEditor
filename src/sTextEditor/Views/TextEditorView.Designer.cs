namespace sTextEditor.Views
{
    partial class TextEditorView
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
            this.TextEditor = new ScintillaNET.Scintilla();
            this.ClearFormattingButton = new System.Windows.Forms.Button();
            this.FormatAsJsonButton = new System.Windows.Forms.Button();
            this.FormatAsXmlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextEditor
            // 
            this.TextEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextEditor.Lexer = ScintillaNET.Lexer.Null;
            this.TextEditor.Location = new System.Drawing.Point(4, 54);
            this.TextEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(1102, 621);
            this.TextEditor.TabIndex = 0;
            // 
            // ClearFormattingButton
            // 
            this.ClearFormattingButton.Location = new System.Drawing.Point(4, 11);
            this.ClearFormattingButton.Name = "ClearFormattingButton";
            this.ClearFormattingButton.Size = new System.Drawing.Size(149, 35);
            this.ClearFormattingButton.TabIndex = 1;
            this.ClearFormattingButton.Text = "Clear formatting";
            this.ClearFormattingButton.UseVisualStyleBackColor = true;
            // 
            // FormatAsJsonButton
            // 
            this.FormatAsJsonButton.Location = new System.Drawing.Point(314, 11);
            this.FormatAsJsonButton.Name = "FormatAsJsonButton";
            this.FormatAsJsonButton.Size = new System.Drawing.Size(149, 35);
            this.FormatAsJsonButton.TabIndex = 2;
            this.FormatAsJsonButton.Text = "Format as JSON";
            this.FormatAsJsonButton.UseVisualStyleBackColor = true;
            // 
            // FormatAsXmlButton
            // 
            this.FormatAsXmlButton.Location = new System.Drawing.Point(159, 11);
            this.FormatAsXmlButton.Name = "FormatAsXmlButton";
            this.FormatAsXmlButton.Size = new System.Drawing.Size(149, 35);
            this.FormatAsXmlButton.TabIndex = 3;
            this.FormatAsXmlButton.Text = "Format as XML";
            this.FormatAsXmlButton.UseVisualStyleBackColor = true;
            // 
            // TextEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FormatAsXmlButton);
            this.Controls.Add(this.FormatAsJsonButton);
            this.Controls.Add(this.ClearFormattingButton);
            this.Controls.Add(this.TextEditor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextEditorView";
            this.Size = new System.Drawing.Size(1110, 680);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla TextEditor;
        private System.Windows.Forms.Button ClearFormattingButton;
        private System.Windows.Forms.Button FormatAsJsonButton;
        private System.Windows.Forms.Button FormatAsXmlButton;
    }
}
