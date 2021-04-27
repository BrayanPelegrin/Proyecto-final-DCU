using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace PruebaBD.Itla.Datos
{
    class Estudiantes
    {
        public Int32 ID;
        public string Nombre;
        public string Apellido;
        public string Matricula;
        public string Contraseña;


        public Estudiantes(DataRow dr) {


            if (dr["Id"] != DBNull.Value) 
            {
                this.ID = Int32.Parse(dr["ID"].ToString());

            }
            if (dr["Nombre"] != DBNull.Value)
            {
                this.Nombre = dr["Nombre"].ToString();

            }
            if (dr["Apellido"] != DBNull.Value)
            {
                this.Apellido = dr["Apellido"].ToString();

            }
            if (dr["Matricula"] != DBNull.Value)
            {
                this.Matricula = dr["Matricula"].ToString();

            }
            if (dr["Contraseña"] != DBNull.Value)
            {
                this.Contraseña = dr["Contraseña"].ToString();

            }

        }
 
    }
}
