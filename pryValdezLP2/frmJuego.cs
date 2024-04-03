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
        clsPlayer objPlayer = new clsPlayer();       
        clsEnemigos objEnemigos = new clsEnemigos();
        
        public frmJuego()
        {
            InitializeComponent();
            pctNave.BackColor = Color.Transparent;
            timerEnemigos.Interval = 3000; // Puedes ajustar el intervalo según la velocidad deseada
            timerEnemigos.Tick += timerEnemigos_Tick;
            timerEnemigos.Start();
        }

        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            objPlayer.Enemigo(this);
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {

            objPlayer.Controles(pctNave, e, this);

        }

    }
}
