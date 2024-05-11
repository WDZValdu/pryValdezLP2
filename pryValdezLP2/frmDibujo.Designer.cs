namespace pryValdezLP2
{
    partial class frmDibujo
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
            pctDibujo = new PictureBox();
            btnGuardar = new Button();
            lblTitulo = new Label();
            btnLimpiar = new Button();
            btnMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)pctDibujo).BeginInit();
            SuspendLayout();
            // 
            // pctDibujo
            // 
            pctDibujo.BackColor = Color.White;
            pctDibujo.Location = new Point(184, 110);
            pctDibujo.Name = "pctDibujo";
            pctDibujo.Size = new Size(304, 296);
            pctDibujo.TabIndex = 1;
            pctDibujo.TabStop = false;
            pctDibujo.MouseDown += pctDibujo_MouseDown;
            pctDibujo.MouseMove += pctDibujo_MouseMove;
            pctDibujo.MouseUp += pctDibujo_MouseUp;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(29, 366);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(105, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.Location = new Point(166, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(185, 32);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Ingrese su firma";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(29, 110);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 40);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnDibujar_Click;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Location = new Point(29, 308);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(105, 40);
            btnMenuPrincipal.TabIndex = 4;
            btnMenuPrincipal.Text = "Menu Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = true;
            btnMenuPrincipal.Click += btnMenuPrincipal_Click;
            // 
            // frmDibujo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 445);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(lblTitulo);
            Controls.Add(btnGuardar);
            Controls.Add(pctDibujo);
            Controls.Add(btnLimpiar);
            Name = "frmDibujo";
            Text = "Dibujo";
            ((System.ComponentModel.ISupportInitialize)pctDibujo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pctDibujo;
        private Button btnGuardar;
        private Label lblTitulo;
        private Button btnLimpiar;
        private Button btnMenuPrincipal;
    }
}