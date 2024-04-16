using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryValdezLP2
{
    public class clsPlayer
    {
        public System.Windows.Forms.Timer timerBola = new System.Windows.Forms.Timer();
        public List<PictureBox> listaBolas = new List<PictureBox>(); // Lista para almacenar las bolas
        public clsEnemigos objEnemigos = new clsEnemigos();

        public void Controles(PictureBox nave, KeyEventArgs Tecla, frmJuego frmJuego)
        {
            PictureBox pctNave = nave;

            switch (Tecla.KeyCode)
            {
                case Keys.Right:
                    if (pctNave.Location.X < 720)
                    {
                        pctNave.Left += 30;
                    }
                    break;

                case Keys.Left:
                    if (pctNave.Location.X > -3)
                    {
                        pctNave.Left -= 30;
                    }
                    break;
            }

            if (Tecla.KeyCode == Keys.Space)
            {
                Disparo(pctNave, frmJuego);
            }
        }

        public void Disparo(PictureBox nave, frmJuego frmJuego)
        {
            PictureBox pctNave = nave;

            PictureBox pctBola = new PictureBox(); // Crea una nueva instancia de PictureBox para la bola
            pctBola.Image = pryValdezLP2.Properties.Resources.Disparo__2_;
            pctBola.Size = new Size(36, 43);
            pctBola.BackColor = Color.Transparent;
            pctBola.SizeMode = PictureBoxSizeMode.Zoom;
            pctBola.Location = new Point(pctNave.Location.X + 72, 385);
            pctBola.Visible = true;
            frmJuego.Controls.Add(pctBola);
            listaBolas.Add(pctBola); // Agrega la bola a la lista
            pctBola.BringToFront();
            timerBola.Start();
        }        
    }
}
