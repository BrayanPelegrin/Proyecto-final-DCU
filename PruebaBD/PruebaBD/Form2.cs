using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using PruebaBD.Itla.AdministradorDatos;

namespace PruebaBD
{
    public partial class frmRegistrar : Form
    {
        int con = 0;
        Image<Bgr, byte> currentFrame;
        Capture Grabar;
        HaarCascade face;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.4d, 0.4d);
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NombePersona = new List<string>();
        List<string> ApellidoPersona = new List<string>();
        List<string> Matricula = new List<string>();
        List<string> Contraseña = new List<string>();
        int ConTrain, numLabels, t;
        string Nombre;
        DataGridView d = new DataGridView();

        public frmRegistrar()
        {
            InitializeComponent();
            face = new HaarCascade("HearCascade_frontalface_default.xml");
            try
            {
                Cnx.Consultar(d);
                string[] Labels = Itla.AdministradorDatos.Cnx.Nombre;
                numLabels = Cnx.totalRostros;
                ConTrain = numLabels;

                for (int i = 0; i < numLabels; i++)
                {
                    con = i;
                    Bitmap bmp = new Bitmap(Cnx.ConvertImgToBinary(con));

                    trainingImages.Add(new Image<Gray, byte>(bmp));
                    labels.Add(Labels[i]);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Sin Rostro para Cargar");
                throw;
            }
        }

        private void FrameGrabar(object sender, EventArgs e) 
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
