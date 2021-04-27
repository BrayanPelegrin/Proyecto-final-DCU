using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;
namespace PruebaBD.Itla.AdministradorDatos
{
    class AdministradorEstudiante
    {

        public static Double VerificarUsuario(System.String txtUsuario, System.String txtClave)
        {

            int Verificador;
            OleDbDataReader Lector;
            string connectionString = String.Format(PruebaBD.Properties.Settings.Default.ConexionBD);
            String query = "SELECT * FROM ESTUDIANTES WHERE MATRICULA = '" + txtUsuario + "' And Contraseña = '" + txtClave + "'";

            OleDbConnection myConnection = new OleDbConnection(connectionString);
            try
            {
                myConnection.Open();
                OleDbCommand command = new OleDbCommand(query, myConnection);
                Lector = command.ExecuteReader();
                if (Lector.Read() == true)
                {
                    Verificador = 1;
                    MessageBox.Show("Has Iniciado Sesion");
                    Menu MN = new Menu();
                    MN.Show();
                    Login LG = new Login();
                    LG.Hide();

                }
                else
                {
                    MessageBox.Show("Matricula o Contraseña Incorrecto");
                    Verificador = -1;
                }

            }
            catch (Exception ex)
            {
                string message = ex.Message;
                MessageBox.Show(message);
                throw ex;
            }
            finally
            {
                if(myConnection.State == ConnectionState.Open)
                {
                    myConnection.Close();
                }
            }
            return Verificador;
        }
    }
}
