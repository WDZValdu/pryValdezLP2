namespace pryValdezLP2
{
    partial class frmMenuJuego
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
            btnJugar = new Button();
            btnBestiario = new Button();
            btnMenuPrincipal = new Button();
            lblPlayer = new Label();
            txtPlayer = new TextBox();
            btnScores = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.Black;
            btnJugar.FlatStyle = FlatStyle.Flat;
            btnJugar.ForeColor = Color.White;
            btnJugar.Location = new Point(257, 218);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(287, 50);
            btnJugar.TabIndex = 5;
            btnJugar.Text = "Jugar";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // btnBestiario
            // 
            btnBestiario.BackColor = Color.Black;
            btnBestiario.FlatStyle = FlatStyle.Flat;
            btnBestiario.ForeColor = Color.White;
            btnBestiario.Location = new Point(257, 372);
            btnBestiario.Name = "btnBestiario";
            btnBestiario.Size = new Size(287, 50);
            btnBestiario.TabIndex = 4;
            btnBestiario.Text = "Bestiario";
            btnBestiario.UseVisualStyleBackColor = false;
            btnBestiario.Click += btnBestiario_Click;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.BackColor = Color.Black;
            btnMenuPrincipal.FlatStyle = FlatStyle.Flat;
            btnMenuPrincipal.ForeColor = Color.White;
            btnMenuPrincipal.Location = new Point(257, 449);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(287, 50);
            btnMenuPrincipal.TabIndex = 3;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = false;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // lblPlayer
            // 
            lblPlayer.AutoSize = true;
            lblPlayer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPlayer.ForeColor = Color.White;
            lblPlayer.Location = new Point(293, 149);
            lblPlayer.Name = "lblPlayer";
            lblPlayer.Size = new Size(68, 25);
            lblPlayer.TabIndex = 6;
            lblPlayer.Text = "Player:";
            // 
            // txtPlayer
            // 
            txtPlayer.Location = new Point(367, 151);
            txtPlayer.Name = "txtPlayer";
            txtPlayer.Size = new Size(132, 23);
            txtPlayer.TabIndex = 7;
            // 
            // btnScores
            // 
            btnScores.BackColor = Color.Black;
            btnScores.FlatStyle = FlatStyle.Flat;
            btnScores.ForeColor = Color.White;
            btnScores.Location = new Point(257, 295);
            btnScores.Name = "btnScores";
            btnScores.Size = new Size(287, 50);
            btnScores.TabIndex = 8;
            btnScores.Text = "Mejores Jugadores";
            btnScores.UseVisualStyleBackColor = false;
            btnScores.Click += btnScores_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fxVE;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 507);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // frmMenuJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 531);
            Controls.Add(btnScores);
            Controls.Add(txtPlayer);
            Controls.Add(lblPlayer);
            Controls.Add(btnJugar);
            Controls.Add(btnBestiario);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(pictureBox1);
            Name = "frmMenuJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Juego";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJugar;
        private Button btnBestiario;
        private Button btnMenuPrincipal;
        private Label lblPlayer;
        private TextBox txtPlayer;
        private Button btnScores;
        private PictureBox pictureBox1;
    }
}