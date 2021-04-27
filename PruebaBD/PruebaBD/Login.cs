using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = false;
            


            }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            txtClave.UseSystemPasswordChar = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Double Verificador;
            Verificador = PruebaBD.Itla.AdministradorDatos.AdministradorEstudiante.VerificarUsuario(txtUsuario.Text, txtClave.Text);
            this.Hide();
        }
    }
    }

