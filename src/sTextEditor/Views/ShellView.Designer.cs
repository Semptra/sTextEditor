namespace sTextEditor.Views
{
    partial class ShellView
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
            this.RoutedControlHost = new ReactiveUI.Winforms.RoutedControlHost();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFromFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFromDatabaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToDatabaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileEditorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoutedControlHost
            // 
            this.RoutedControlHost.DefaultContent = null;
            this.RoutedControlHost.Location = new System.Drawing.Point(11, 26);
            this.RoutedControlHost.Margin = new System.Windows.Forms.Padding(2);
            this.RoutedControlHost.Name = "RoutedControlHost";
            this.RoutedControlHost.Router = null;
            this.RoutedControlHost.Size = new System.Drawing.Size(778, 494);
            this.RoutedControlHost.TabIndex = 4;
            this.RoutedControlHost.ViewLocator = null;
            // 
            // MenuStrip
            // 
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.OpenFileEditorMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 6;
            this.MenuStrip.Text = "menuStrip1";
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
            this.OpenFromFileMenuItem,
            this.OpenFromDatabaseMenuItem});
            this.FileOpenMenuItem.Name = "FileOpenMenuItem";
            this.FileOpenMenuItem.Size = new System.Drawing.Size(103, 22);
            this.FileOpenMenuItem.Text = "Open";
            // 
            // OpenFromFileMenuItem
            // 
            this.OpenFromFileMenuItem.Name = "OpenFromFileMenuItem";
            this.OpenFromFileMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenFromFileMenuItem.Text = "From file";
            // 
            // OpenFromDatabaseMenuItem
            // 
            this.OpenFromDatabaseMenuItem.Name = "OpenFromDatabaseMenuItem";
            this.OpenFromDatabaseMenuItem.Size = new System.Drawing.Size(152, 22);
            this.OpenFromDatabaseMenuItem.Text = "From database";
            // 
            // FileSaveMenuItem
            // 
            this.FileSaveMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToFileMenuItem,
            this.SaveToDatabaseMenuItem});
            this.FileSaveMenuItem.Name = "FileSaveMenuItem";
            this.FileSaveMenuItem.Size = new System.Drawing.Size(103, 22);
            this.FileSaveMenuItem.Text = "Save";
            // 
            // SaveToFileMenuItem
            // 
            this.SaveToFileMenuItem.Name = "SaveToFileMenuItem";
            this.SaveToFileMenuItem.Size = new System.Drawing.Size(137, 22);
            this.SaveToFileMenuItem.Text = "To file";
            // 
            // SaveToDatabaseMenuItem
            // 
            this.SaveToDatabaseMenuItem.Name = "SaveToDatabaseMenuItem";
            this.SaveToDatabaseMenuItem.Size = new System.Drawing.Size(137, 22);
            this.SaveToDatabaseMenuItem.Text = "To database";
            // 
            // OpenFileEditorMenuItem
            // 
            this.OpenFileEditorMenuItem.Name = "OpenFileEditorMenuItem";
            this.OpenFileEditorMenuItem.Size = new System.Drawing.Size(101, 20);
            this.OpenFileEditorMenuItem.Text = "Open file editor";
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.RoutedControlHost);
            this.Name = "ShellView";
            this.Text = "sTextEditor";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReactiveUI.Winforms.RoutedControlHost RoutedControlHost;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileOpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFromFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFromDatabaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileSaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToDatabaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileEditorMenuItem;
    }
}