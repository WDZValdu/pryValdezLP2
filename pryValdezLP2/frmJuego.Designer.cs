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
            lblScore = new Label();
            panel = new Panel();
            lblPlayer = new Label();
            lblPausa = new Label();
            btnReanudar = new Button();
            btnReiniciar = new Button();
            btnMenuPrincipal = new Button();
            lblDificultad = new Label();
            pctVida1 = new PictureBox();
            pctVida2 = new PictureBox();
            pctVida3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctNave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctVida1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVida2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctVida3).BeginInit();
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
            pictureBox1.Image = Properties.Resources.pxsprite_space;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(920, 550);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblScore.ForeColor = Color.White;
            lblScore.Location = new Point(11, 9);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(49, 20);
            lblScore.TabIndex = 2;
            lblScore.Text = "Score:";
            // 
            // panel
            // 
            panel.BackColor = Color.Black;
            panel.Controls.Add(lblPlayer);
            panel.Controls.Add(lblPausa);
            panel.Controls.Add(btnReanudar);
            panel.Controls.Add(btnReiniciar);
            panel.Controls.Add(btnMenuPrincipal);
            panel.Location = new Point(309, 100);
            panel.Name = "panel";
            panel.Size = new Size(342, 392);
            panel.TabIndex = 3;
            panel.Visible = false;
            // 
            // lblPlayer
            // 
            lblPlayer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(29, 90);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(287, 25);
            lblPlayer.TabIndex = 4;
            lblPlayer.Text = "Player:";
            lblPlayer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPausa
            // 
            lblPausa.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblPausa.ForeColor = Color.White;
            lblPausa.Location = new Point(3, 13);
            lblPausa.Name = "lblPausa";
            lblPausa.Size = new Size(336, 65);
            lblPausa.TabIndex = 3;
            lblPausa.Text = "PAUSA";
            lblPausa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReanudar
            // 
            btnReanudar.BackColor = Color.Black;
            btnReanudar.FlatStyle = FlatStyle.Flat;
            btnReanudar.ForeColor = Color.White;
            btnReanudar.Location = new Point(29, 147);
            btnReanudar.Name = "btnReanudar";
            btnReanudar.Size = new Size(287, 50);
            btnReanudar.TabIndex = 2;
            btnReanudar.Text = "Reanudar";
            btnReanudar.UseVisualStyleBackColor = false;
            btnReanudar.Click += btnReanudar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.Black;
            btnReiniciar.FlatStyle = FlatStyle.Flat;
            btnReiniciar.ForeColor = Color.White;
            btnReiniciar.Location = new Point(29, 228);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(287, 50);
            btnReiniciar.TabIndex = 1;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.BackColor = Color.Black;
            btnMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnMenuPrincipal.ForeColor = Color.White;
            btnMenuPrincipal.Location = new Point(29, 309);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(287, 50);
            btnMenuPrincipal.TabIndex = 0;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // lblDificultad
            // 
            lblDificultad.AutoSize = true;
            lblDificultad.BackColor = Color.Transparent;
            lblDificultad.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDificultad.ForeColor = Color.IndianRed;
            lblDificultad.Location = new Point(777, 9);
            lblDificultad.Name = "lblDificultad";
            lblDificultad.Size = new Size(131, 20);
            lblDificultad.TabIndex = 4;
            lblDificultad.Text = "Maxima Dificultad";
            lblDificultad.Visible = false;
            // 
            // pctVida1
            // 
            pctVida1.BackColor = Color.Transparent;
            pctVida1.Image = Properties.Resources.pixel_heart;
            pctVida1.Location = new Point(409, 4);
            pctVida1.Name = "pctVida1";
            pctVida1.Size = new Size(41, 40);
            pctVida1.SizeMode = PictureBoxSizeMode.Zoom;
            pctVida1.TabIndex = 6;
            pctVida1.TabStop = false;
            // 
            // pctVida2
            // 
            pctVida2.BackColor = Color.Transparent;
            pctVida2.Image = Properties.Resources.pixel_heart;
            pctVida2.Location = new Point(456, 4);
            pctVida2.Name = "pctVida2";
            pctVida2.Size = new Size(41, 40);
            pctVida2.SizeMode = PictureBoxSizeMode.Zoom;
            pctVida2.TabIndex = 7;
            pctVida2.TabStop = false;
            // 
            // pctVida3
            // 
            pctVida3.BackColor = Color.Transparent;
            pctVida3.Image = Properties.Resources.pixel_heart;
            pctVida3.Location = new Point(503, 4);
            pctVida3.Name = "pctVida3";
            pctVida3.Size = new Size(41, 40);
            pctVida3.SizeMode = PictureBoxSizeMode.Zoom;
            pctVida3.TabIndex = 8;
            pctVida3.TabStop = false;
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackgroundImage = Properties.Resources.fondo;
            ClientSize = new Size(920, 550);
            Controls.Add(pctVida3);
            Controls.Add(pctVida2);
            Controls.Add(pctVida1);
            Controls.Add(lblDificultad);
            Controls.Add(panel);
            Controls.Add(lblScore);
            Controls.Add(pctNave);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego";
            KeyDown += frmJuego_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctNave).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctVida1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVida2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctVida3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctNave;
        private PictureBox pictureBox1;
        private Label lblScore;
        private Panel panel;
        private Button btnMenuPrincipal;
        private Button btnReanudar;
        private Button btnReiniciar;
        private Label lblPausa;
        private Label lblPlayer;
        private Label lblDificultad;
        private PictureBox pctVida1;
        private PictureBox pctVida2;
        private PictureBox pctVida3;
    }
}