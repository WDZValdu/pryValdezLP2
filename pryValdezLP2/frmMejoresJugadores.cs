using MySql.Data.MySqlClient;
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
    public partial class frmMejoresJugadores : Form
    {
        public frmMejoresJugadores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuJuego frmMenuJuego = new frmMenuJuego();
            frmMenuJuego.ShowDialog();
        }

        private void frmMejoresJugadores_Load(object sender, EventArgs e)
        {
            
        }

        private void btnMostrarScores_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection ConexionBD = clsConexionBD.conex();
                ConexionBD.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = ConexionBD;
                cmd.CommandText = ("SELECT * FROM Scores;");
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.SelectCommand = cmd;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgvMJugadores.DataSource = tabla;

                ConexionBD.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("error"+ex);
            }
        }
    }
}
