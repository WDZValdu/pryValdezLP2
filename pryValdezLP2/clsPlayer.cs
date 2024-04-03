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
            
            timerEnemigos.Interval = 20; // Puedes ajustar el intervalo según la velocidad deseada
            timerEnemigos.Tick += timerEnemigos_Tick;
        }

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

        private void TimerBola_Tick(object sender, EventArgs e)
        {
            List<PictureBox> enemigosAEliminar = new List<PictureBox>(); // Lista temporal para almacenar los enemigos que deben eliminarse

            foreach (var pctBola in listaBolas)
            {
                if (pctBola != null)
                {
                    pctBola.Top -= 10;
                    // Verificar colisión con los enemigos
                    foreach (var pctEnemigo in listaEnemigos)
                    {
                        if (pctBola.Bounds.IntersectsWith(pctEnemigo.Bounds))
                        {
                            // Si hay colisión, ocultar el enemigo
                            pctEnemigo.Visible = false;
                            pctBola.Visible = false;
                            // También puedes eliminarlo de la lista si lo deseas
                            // Si hay colisión, agregar el enemigo a la lista de enemigos a eliminar
                            enemigosAEliminar.Add(pctEnemigo);
                        }
                    }
                }
            }
            // Eliminar los enemigos de la lista principal después de completar el bucle foreach
            foreach (var enemigo in enemigosAEliminar)
            {
                listaEnemigos.Remove(enemigo);
                listaBolas.Remove(enemigo);
                //frmJuego.Controls.Remove(enemigo); // Además, si los eliminas visualmente del formulario, asegúrate de quitarlos también de los controles del formulario
            }
        }

        private System.Windows.Forms.Timer timerEnemigos = new System.Windows.Forms.Timer();
        public List<PictureBox> listaEnemigos = new List<PictureBox>(); // Lista para almacenar los enemigos       

        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            foreach (var pctEnemigo in listaEnemigos)
            {
                if (pctEnemigo != null)
                {
                    pctEnemigo.Top += 4;
                }
            }
        }

        public void Enemigo(frmJuego frmJuego)
        {
            PictureBox pctEnemigo = new PictureBox();
            Random random = new Random();
            int rndX = random.Next(0, 821);

            pctEnemigo.Image = pryValdezLP2.Properties.Resources.Enemigo;
            pctEnemigo.SizeMode = PictureBoxSizeMode.Zoom;
            pctEnemigo.BackColor = Color.Transparent;
            pctEnemigo.Location = new Point(rndX, 0);
            pctEnemigo.Visible = true;
            frmJuego.Controls.Add(pctEnemigo);
            listaEnemigos.Add(pctEnemigo);
            pctEnemigo.BringToFront();

            timerEnemigos.Start();

        }
    }
}
