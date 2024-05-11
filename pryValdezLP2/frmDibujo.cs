using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryValdezLP2
{
    public partial class frmDibujo : Form
    {
        public frmDibujo()
        {
            InitializeComponent();
        }
        public bool Click = false;
        Point previousPoint;

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            pctDibujo.Invalidate();

        }


        private void pctDibujo_MouseDown(object sender, MouseEventArgs e)
        {
            Click = true;
            previousPoint = e.Location;
        }

        private void pctDibujo_MouseUp(object sender, MouseEventArgs e)
        {
            Click = false;
        }

        private void pctDibujo_MouseMove(object sender, MouseEventArgs e)
        {
            if (Click == true)
            {
                using (Graphics g = pctDibujo.CreateGraphics())
                {
                    using (Pen pen = new Pen(Color.Black, 4))
                    {
                        g.DrawLine(pen, previousPoint, e.Location);
                        previousPoint = e.Location;

                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaCarpeta = Application.StartupPath + "Firmas\\";
                string NombreArchivo = "Firma_"+ DateTime.Now.ToString("yy-MM-dd-HH-mm-ss")+".jpg";
                rutaCarpeta += NombreArchivo;

                Bitmap bmp = new Bitmap(pctDibujo.Width, pctDibujo.Height);

                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(pctDibujo.PointToScreen(Point.Empty), Point.Empty, pctDibujo.Size);
                }

                bmp.Save(rutaCarpeta, System.Drawing.Imaging.ImageFormat.Jpeg);

                MessageBox.Show("SU FIRMA SE GUARDO CORRECTAMENTE");
                pctDibujo.Invalidate();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen" + ex.Message);

            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
        }
    }
}
