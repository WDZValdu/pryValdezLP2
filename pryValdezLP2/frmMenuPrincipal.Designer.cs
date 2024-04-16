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
            MenuStripPrincipal = new MenuStrip();
            juegoLibroToolStripMenuItem = new ToolStripMenuItem();
            juegoToolStripMenuItem = new ToolStripMenuItem();
            firmaDigitalToolStripMenuItem = new ToolStripMenuItem();
            lblStatus = new Label();
            MenuStripPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStripPrincipal
            // 
            MenuStripPrincipal.BackColor = Color.White;
            MenuStripPrincipal.Items.AddRange(new ToolStripItem[] { juegoLibroToolStripMenuItem });
            MenuStripPrincipal.Location = new Point(0, 0);
            MenuStripPrincipal.Name = "MenuStripPrincipal";
            MenuStripPrincipal.Size = new Size(597, 24);
            MenuStripPrincipal.TabIndex = 0;
            MenuStripPrincipal.Text = "MenuStripPrincipal";
            // 
            // juegoLibroToolStripMenuItem
            // 
            juegoLibroToolStripMenuItem.BackColor = Color.White;
            juegoLibroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { juegoToolStripMenuItem, firmaDigitalToolStripMenuItem });
            juegoLibroToolStripMenuItem.Name = "juegoLibroToolStripMenuItem";
            juegoLibroToolStripMenuItem.Size = new Size(50, 20);
            juegoLibroToolStripMenuItem.Text = "Menu";
            // 
            // juegoToolStripMenuItem
            // 
            juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            juegoToolStripMenuItem.Size = new Size(141, 22);
            juegoToolStripMenuItem.Text = "Juego";
            juegoToolStripMenuItem.Click += juegoToolStripMenuItem_Click;
            // 
            // firmaDigitalToolStripMenuItem
            // 
            firmaDigitalToolStripMenuItem.Name = "firmaDigitalToolStripMenuItem";
            firmaDigitalToolStripMenuItem.Size = new Size(141, 22);
            firmaDigitalToolStripMenuItem.Text = "Firma Digital";
            firmaDigitalToolStripMenuItem.Click += firmaDigitalToolStripMenuItem_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 283);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "label1";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 307);
            Controls.Add(lblStatus);
            Controls.Add(MenuStripPrincipal);
            MainMenuStrip = MenuStripPrincipal;
            Name = "frmMenuPrincipal";
            Text = "Menu Principal";
            Load += frmMenuPrincipal_Load;
            MenuStripPrincipal.ResumeLayout(false);
            MenuStripPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuStripPrincipal;
        private ToolStripMenuItem juegoLibroToolStripMenuItem;
        private ToolStripMenuItem juegoToolStripMenuItem;
        private ToolStripMenuItem firmaDigitalToolStripMenuItem;
        private Label lblStatus;
    }
}