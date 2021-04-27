using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaBD
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
           
            this.Hide();
             Login FRM3 = new Login();
            FRM3.Show();
        }

        private void abrirFormInPanel(Object formHijo) {

            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            abrirFormInPanel(new Form2());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void icoCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icoMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            icoRestaurar.Visible = true;
            icoMaximizar.Visible = false;
         
        }

        private void icoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            icoRestaurar.Visible = false;
            icoMaximizar.Visible = true;
        }

        private void icoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
