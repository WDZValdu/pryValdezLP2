﻿namespace pryValdezLP2
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
            ((System.ComponentModel.ISupportInitialize)pctNave).BeginInit();
            SuspendLayout();
            // 
            // pctNave
            // 
            pctNave.Image = Properties.Resources.Nave;
            pctNave.Location = new Point(328, 405);
            pctNave.Name = "pctNave";
            pctNave.Size = new Size(265, 157);
            pctNave.SizeMode = PictureBoxSizeMode.Zoom;
            pctNave.TabIndex = 0;
            pctNave.TabStop = false;
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 550);
            Controls.Add(pctNave);
            Name = "frmJuego";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Juego";
            KeyDown += frmJuego_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pctNave).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctNave;
    }
}