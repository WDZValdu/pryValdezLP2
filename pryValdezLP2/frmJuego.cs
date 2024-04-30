using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryValdezLP2
{
    public partial class frmJuego : Form
    {
        private System.Windows.Forms.Timer timerEnemigos = new System.Windows.Forms.Timer();
        private System.Windows.Forms.Timer timerBola = new System.Windows.Forms.Timer();

        clsPlayer objPlayer = new clsPlayer();
        clsEnemigos objEnemigos = new clsEnemigos();
        public bool escape = false;
        Int32 Score = 0;
        //Int32 Vel =0;

        public frmJuego()
        {
            InitializeComponent();
            pctNave.BackColor = Color.Transparent;
            timerEnemigos.Interval = 2500;
            timerEnemigos.Tick += timerEnemigos_Tick;
            timerEnemigos.Start();
            timerBola.Start();
            timerBola.Interval = 2;
            timerBola.Tick += TimerBola_Tick;

        }

        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            objEnemigos.Enemigo(this);
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (escape == false)
            {
                objPlayer.Controles(pctNave, e, this);
            }

            if (e.KeyCode == Keys.Escape)
            {
                if (escape == false)
                {
                    panel.Visible = true;
                    panel.BringToFront();
                    timerBola.Stop();
                    timerEnemigos.Stop();
                    objEnemigos.timerEnemigos.Stop();
                    objPlayer.timerBola.Stop();
                    escape = true;
                }
                else
                {
                    btnReanudar_Click(sender, e);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void TimerBola_Tick(object sender, EventArgs e)
        {
            foreach (var Bola in objPlayer.listaBolas.ToList())
            {
                if (Bola != null)
                {
                    Bola.Top -= 10;
                    // Verificar colisión con los enemigos
                    foreach (var Enemigo in objEnemigos.listaEnemigos.ToList())
                    {
                        if (Bola.Bounds.IntersectsWith(Enemigo.Bounds))
                        {

                            // Si hay colisión, ocultar el enemigo
                            Enemigo.Visible = false;
                            Bola.Visible = false;
                            Explosion(Enemigo.Location.X + 30, Enemigo.Location.Y);
                            Score += 1;
                            //Vel += 500;
                            lblScore.Text = "Score: " + Score.ToString();
                            objEnemigos.listaEnemigos.Remove(Enemigo);
                            objPlayer.listaBolas.Remove(Bola);
                        }
                    }
                }
            }
        }

        public void Explosion(Int32 x, Int32 y)
        {
            PictureBox pctExplocion = new PictureBox();
            pctExplocion.Image = pryValdezLP2.Properties.Resources._3iCN;
            pctExplocion.Size = new Size(36, 43);
            pctExplocion.BackColor = Color.Transparent;
            pctExplocion.SizeMode = PictureBoxSizeMode.Zoom;
            pctExplocion.Location = new Point(x, y);
            pctExplocion.Visible = true;

            this.Controls.Add(pctExplocion);
            pctExplocion.BringToFront();

            System.Windows.Forms.Timer timerExplosion = new System.Windows.Forms.Timer();
            timerExplosion.Interval = 300;
            timerExplosion.Tick += (sender, arges) =>
            {
                this.Controls.Remove(pctExplocion);
                pctExplocion.Dispose();

                timerExplosion.Stop();
            };
            timerExplosion.Start();
        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {

            panel.Visible = false;
            timerBola.Start();
            timerEnemigos.Start();
            objEnemigos.timerEnemigos.Start();
            objPlayer.timerBola.Start();
            escape = false;
            this.Focus();

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmJuego frmJuego = new frmJuego();
            frmJuego.ShowDialog();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.ShowDialog();
        }
    }
}
