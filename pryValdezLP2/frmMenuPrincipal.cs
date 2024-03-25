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

        private void juegoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDibujo frmDibujo = new frmDibujo();
            frmDibujo.Show();
        }
    }
}
