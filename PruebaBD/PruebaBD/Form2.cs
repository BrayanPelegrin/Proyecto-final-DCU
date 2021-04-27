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

namespace PruebaBD
{
    public partial class frmRegistrar : Form
    {
        int con = 0;
        Image<Bgr, byte> currentFrame;
        Capture Grabar;
        HaarCascade face;
        MCvFont font=new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.4d, 0.4d);
        Image<Gray, byte> result = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NombePersona = new List<string>();
        List<string> ApellidoPersona = new List<string>();
        List<string> Matricula = new List<string>();
        List<string> Contraseña = new List<string>();
        int ContTrain, numLabels, t;
        string Nombre;

        public frmRegistrar()
        {
            InitializeComponent();
            face = new HaarCascade("HearCascade_frontalface_default.xml");
            
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
