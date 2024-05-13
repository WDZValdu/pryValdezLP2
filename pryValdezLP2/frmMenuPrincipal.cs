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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void firmaDigitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDibujo frmDibujo = new frmDibujo();
            frmDibujo.Show();
        }

        private void juegoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJuego frmMenuJuego = new frmMenuJuego();
            frmMenuJuego.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            clsConexionBD objBD = new clsConexionBD();
            objBD.ConectarBD_Nave(lblStatus);
        }
    }
}
