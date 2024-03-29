using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryValdezLP2
{
    public class clsPlayer
    {
        private System.Windows.Forms.Timer timerBola = new System.Windows.Forms.Timer();
        private List<PictureBox> listaBolas = new List<PictureBox>(); // Lista para almacenar las bolas

        public clsPlayer()
        {
            timerBola.Interval = 20; // Puedes ajustar el intervalo según la velocidad deseada
            timerBola.Tick += TimerBola_Tick;
        }

        public void Controles(PictureBox nave, KeyEventArgs Tecla, frmJuego frmJuego)
        {
            PictureBox pctNave = nave;

            switch (Tecla.KeyCode)
            {
                case Keys.Right:
                    if (pctNave.Location.X < 710)
                    {
                        pctNave.Left += 30;
                    }
                    break;

                case Keys.Left:
                    if (pctNave.Location.X > -55)
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
            pctBola.Image = pryValdezLP2.Properties.Resources.Disparo;
            pctBola.Size = new Size(36, 43);
            pctBola.SizeMode = PictureBoxSizeMode.Zoom;
            pctBola.Location = new Point(pctNave.Location.X + 112, 385);
            pctBola.Visible = true;
            frmJuego.Controls.Add(pctBola);
            listaBolas.Add(pctBola); // Agrega la bola a la lista

            timerBola.Start();
        }

        private void TimerBola_Tick(object sender, EventArgs e)
        {
            foreach (var pctBola in listaBolas)
            {
                if (pctBola != null)
                {
                    pctBola.Top -= 10;
                }
            }
        }
    }
}
