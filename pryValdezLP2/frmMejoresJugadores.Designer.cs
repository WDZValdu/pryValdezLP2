namespace pryValdezLP2
{
    partial class frmMejoresJugadores
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
            dgvMJugadores = new DataGridView();
            btnVolver = new Button();
            btnMostrarScores = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMJugadores).BeginInit();
            SuspendLayout();
            // 
            // dgvMJugadores
            // 
            dgvMJugadores.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvMJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMJugadores.GridColor = SystemColors.ControlText;
            dgvMJugadores.Location = new Point(289, 12);
            dgvMJugadores.Name = "dgvMJugadores";
            dgvMJugadores.RowTemplate.Height = 25;
            dgvMJugadores.Size = new Size(499, 426);
            dgvMJugadores.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(61, 391);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(155, 47);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnMostrarScores
            // 
            btnMostrarScores.Location = new Point(61, 12);
            btnMostrarScores.Name = "btnMostrarScores";
            btnMostrarScores.Size = new Size(155, 47);
            btnMostrarScores.TabIndex = 4;
            btnMostrarScores.Text = "Ver Puntajes";
            btnMostrarScores.UseVisualStyleBackColor = true;
            btnMostrarScores.Click += btnMostrarScores_Click;
            // 
            // frmMejoresJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarScores);
            Controls.Add(btnVolver);
            Controls.Add(dgvMJugadores);
            Name = "frmMejoresJugadores";
            Text = "Mejores Jugadores";
            Load += frmMejoresJugadores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMJugadores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMJugadores;
        private Button btnVolver;
        private Button btnMostrarScores;
    }
}