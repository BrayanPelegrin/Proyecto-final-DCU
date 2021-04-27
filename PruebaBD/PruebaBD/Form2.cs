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
        List<string> NombrePersona = new List<string>();
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
                    Bitmap bmp = new Bitmap(Cnx.ConvertBinary(con));

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
            
            try {
                currentFrame = Grabar.QueryFrame().Resize(436, 339, INTER.CV_INTER_CUBIC);
                gray = currentFrame.Convert<Gray, Byte>();
                MCvAvgComp[][] RostrosDetectados = gray.DetectHaarCascade(face, 1.5, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(272, 205));

                foreach (MCvAvgComp R in RostrosDetectados[0])
                {
                    t = t + 1;
                    result = currentFrame.Copy(R.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                    currentFrame.Draw(R.rect, new Bgr(Color.Blue), 1);

                    if (trainingImages.ToArray().Length != 0)
                    {
                        MCvTermCriteria Criterio = new MCvTermCriteria(ConTrain, 0.88);
                        EigenObjectRecognizer recogida = new EigenObjectRecognizer(trainingImages.ToArray(), label.ToArray(), ref Criterio);
                        var fa = new Image<Gray, byte>[trainingImages.Count];

                        Nombre = recogida.Recognize(result);

                        currentFrame.Draw(Nombre, ref font, new Point(R.rect.X - 2, R.rect.Y - 2), new Bgr(Color.Green));

                    }
                    NombrePersona[t - 1] = Nombre;
                    NombrePersona.Add("");

                    
                }
                t = 0;
                imageBox1.Image= currentFrame;
                Nombre = "";
                NombrePersona.Clear();
            }
            catch(Exception Error)
            {
                MessageBox.Show(Error.Message);
            }

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
