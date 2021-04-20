using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace controlEscolar.Datos
{
    public class ConectaBD
    {
        private SqlConnection con;
        private SqlDataReader lec;
        private SqlCommand comQry;

        private string cadConexion = "Data Source=PC-LUIS; Initial Catalog=DB7CV23; Trusted_Connection=True";

        public ConectaBD()
        {
            con = new SqlConnection(cadConexion);
        }

        public void ConBD()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar abrir la base de datos"+ ex.ToString());
            }
        }
    }
}