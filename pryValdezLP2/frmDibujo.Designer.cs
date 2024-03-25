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
            this.btnDibujar = new System.Windows.Forms.Button();
            this.pctDibujo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctDibujo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDibujar
            // 
            this.btnDibujar.Location = new System.Drawing.Point(24, 63);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(105, 40);
            this.btnDibujar.TabIndex = 0;
            this.btnDibujar.Text = "Dibujar";
            this.btnDibujar.UseVisualStyleBackColor = true;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click);
            // 
            // pctDibujo
            // 
            this.pctDibujo.BackColor = System.Drawing.Color.White;
            this.pctDibujo.Location = new System.Drawing.Point(195, 63);
            this.pctDibujo.Name = "pctDibujo";
            this.pctDibujo.Size = new System.Drawing.Size(262, 296);
            this.pctDibujo.TabIndex = 1;
            this.pctDibujo.TabStop = false;
            this.pctDibujo.Click += new System.EventHandler(this.pctDibujo_Click);
            // 
            // frmDibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 445);
            this.Controls.Add(this.pctDibujo);
            this.Controls.Add(this.btnDibujar);
            this.Name = "frmDibujo";
            this.Text = "Dibujo";
            ((System.ComponentModel.ISupportInitialize)(this.pctDibujo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnDibujar;
        private PictureBox pctDibujo;
    }
}