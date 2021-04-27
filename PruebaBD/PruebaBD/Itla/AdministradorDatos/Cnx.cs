using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

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

        public static bool GuardarImagen(string Nombres, string Apellido, string Matricula, string Contraseña, byte[] Imagen);        
        {
            cnnx.Open();
           OleDbCommand cmd = new OleDbCommand("INSERT INTO ESTUDIANTES (NOMBRE, APELLIDO, MATRICULA, CAPTURA, CONTRASEÑA) VALUES('"+Nombre+"','"+Apellido+"','"+Matricula+"','"+Rostros+"','"+contraseña+"';");


        } 
    }
}
