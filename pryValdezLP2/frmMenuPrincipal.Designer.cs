namespace pryValdezLP2
{
    partial class frmMenuPrincipal
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
            this.MenuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.juegoLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripPrincipal
            // 
            this.MenuStripPrincipal.BackColor = System.Drawing.Color.White;
            this.MenuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juegoLibroToolStripMenuItem});
            this.MenuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuStripPrincipal.Name = "MenuStripPrincipal";
            this.MenuStripPrincipal.Size = new System.Drawing.Size(597, 24);
            this.MenuStripPrincipal.TabIndex = 0;
            this.MenuStripPrincipal.Text = "MenuStripPrincipal";
            // 
            // juegoLibroToolStripMenuItem
            // 
            this.juegoLibroToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.juegoLibroToolStripMenuItem.Name = "juegoLibroToolStripMenuItem";
            this.juegoLibroToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.juegoLibroToolStripMenuItem.Text = "Juego (Libro)";
            this.juegoLibroToolStripMenuItem.Click += new System.EventHandler(this.juegoLibroToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 307);
            this.Controls.Add(this.MenuStripPrincipal);
            this.MainMenuStrip = this.MenuStripPrincipal;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.MenuStripPrincipal.ResumeLayout(false);
            this.MenuStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip MenuStripPrincipal;
        private ToolStripMenuItem juegoLibroToolStripMenuItem;
    }
}