namespace pryValdezLP2
{
    partial class frmBestiario
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
            dgvBestiario = new DataGridView();
            btnVer = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBestiario).BeginInit();
            SuspendLayout();
            // 
            // dgvBestiario
            // 
            dgvBestiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBestiario.Location = new Point(259, 12);
            dgvBestiario.Name = "dgvBestiario";
            dgvBestiario.RowTemplate.Height = 25;
            dgvBestiario.Size = new Size(529, 426);
            dgvBestiario.TabIndex = 0;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(22, 12);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(155, 47);
            btnVer.TabIndex = 1;
            btnVer.Text = "Ver Bestias";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(22, 391);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(155, 47);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmBestiario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnVer);
            Controls.Add(dgvBestiario);
            Name = "frmBestiario";
            Text = "Bestiario";
            ((System.ComponentModel.ISupportInitialize)dgvBestiario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBestiario;
        private Button btnVer;
        private Button btnVolver;
    }
}