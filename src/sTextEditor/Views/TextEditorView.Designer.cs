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
            this.SuspendLayout();
            // 
            // TextEditor
            // 
            this.TextEditor.Location = new System.Drawing.Point(4, 5);
            this.TextEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(1102, 670);
            this.TextEditor.TabIndex = 0;
            // 
            // TextEditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextEditor);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TextEditorView";
            this.Size = new System.Drawing.Size(1110, 680);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNET.Scintilla TextEditor;
    }
}
