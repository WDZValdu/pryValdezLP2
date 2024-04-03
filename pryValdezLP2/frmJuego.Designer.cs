namespace pryValdezLP2
{
    partial class frmJuego
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
            pctNave = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctNave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pctNave
            // 
            pctNave.BackColor = Color.Transparent;
            pctNave.Image = Properties.Resources.NaveSinFondo;
            pctNave.Location = new Point(387, 405);
            pctNave.Name = "pctNave";
            pctNave.Size = new Size(181, 143);
            pctNave.SizeMode = PictureBoxSizeMode.Zoom;
            pctNave.TabIndex = 0;
            pctNave.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pxsprite_space;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(920, 550);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(920, 550);
            Controls.Add(pctNave);
            Controls.Add(pictureBox1);
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego";
            KeyDown += frmJuego_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctNave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctNave;
        private PictureBox pictureBox1;
    }
}