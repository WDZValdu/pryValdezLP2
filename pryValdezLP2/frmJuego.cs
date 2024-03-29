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
        clsPlayer objPlayer = new clsPlayer();       
        public frmJuego()
        {
            InitializeComponent();
        }


        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {

            objPlayer.Controles(pctNave, e, this);

        }

    }
}
