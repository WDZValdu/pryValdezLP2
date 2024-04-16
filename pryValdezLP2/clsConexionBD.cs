using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace pryValdezLP2
{
    internal class clsConexionBD
    {
        string CadenaConexion = "Server = LocalHost; Database = JuegoRol; Uid = root; Pwd =";
        MySqlConnection conn = new MySqlConnection();
        public string EstadoConexion = "";



        public void ConectarBD(Label lblStatus)
        {
            try
            {

                string CadenaConexion = "Server = LocalHost;" + "Database = JuegoRol;"+ "Uid = root;" + "Pwd = ;";
               
                MySqlConnection conn = new MySqlConnection(CadenaConexion);
                conn.Open();               
                lblStatus.Text = "Conecatdo";

            }
            catch (Exception ex)
            {
                lblStatus.Text = "Error " + ex.Message;
            }
        }

    }
}
