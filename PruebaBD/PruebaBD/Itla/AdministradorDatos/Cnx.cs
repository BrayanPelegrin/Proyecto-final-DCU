using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace PruebaBD.Itla.AdministradorDatos
{
    class Cnx
    {

        private static OleDbConnection cnnx = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=estudiantes.accbd;");

        private static string[] Nombre;
        private static string[] Apellido;
        private static string[] Matricula;
        private static string[] contraseña;
        private static byte[] Rostros;
        private static List<byte[]> ListadoRostros = new List<byte[]>();
        public static int totalRostros;

        public static bool GuardarImagen(string Nombres, string Apellido, string Matricula, byte[] Captura, string Contraseña)     
        {
            cnnx.Open();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO ESTUDIANTES (NOMBRE, APELLIDO, MATRICULA, CAPTURA, CONTRASEÑA) VALUES('" + Nombre + "','" + Apellido + "','" + Matricula + "',?,'" + contraseña + "';");
            OleDbParameter parRostros = new OleDbParameter(@"Captura", OleDbType.VarBinary, Captura.Length);
            parRostros.Value = Rostros;
            cmd.Parameters.Add(Rostros);
            int Resultado = cmd.ExecuteNonQuery();
            cnnx.Close();
            return Convert.ToBoolean(Resultado);
        }

        public static DataTable Consultar(DataGridView DATA)
        {

            cnnx.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM ESTUDIANTES", cnnx);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DATA.DataSource = dt;
            int Cont = dt.Rows.Count;
            Apellido = new string[Cont];
            Matricula = new string[Cont];
            contraseña = new string[Cont];

            for (int i = 0; i < Cont; i++)
            {

                Nombre[i] = dt.Rows[i]["Nombre"].ToString();
                Apellido[i] = dt.Rows[i]["Apellido"].ToString();
                Matricula[i] = dt.Rows[i]["Matricula"].ToString();
                Rostros = (byte[])dt.Rows[i]["Captura"];
                contraseña[i] = dt.Rows[i]["Contraseña"].ToString();
                ListadoRostros.Add(Rostros);

            }
            try
            {
                DATA.Columns[0].Width = 60;
                DATA.Columns[0].Width = 160;
                DATA.Columns[0].Width = 160;
                for (int i = 0; i < Cont; i++)
                {

                    DATA.Rows[i].Height = 110;
                }
            }
            catch(Exception) 
            {

                throw;

            }
            totalRostros = Cont;
            cnnx.Close();
            return dt;
        }


        public static byte[] ConvertImgToBinary(Image img)
        {

            Bitmap bmp = new Bitmap(img);
            MemoryStream Memoria = new MemoryStream();
            bmp.Save(Memoria, ImageFormat.Bmp);

            byte[] Imagen = Memoria.ToArray();

            return Imagen;
        }

        public static Image ConvertBinary(int c)
        {

            Image Imagen;
            byte[] img = ListadoRostros[c];
            MemoryStream Memoria = new MemoryStream(img);
            Imagen = Image.FromStream(Memoria);
            Memoria.Close();
            return Imagen;

        }
    }
}
