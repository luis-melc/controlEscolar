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
            /*try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar abrir la base de datos"+ ex.ToString());
            }*/
        }

        public void ActualizaDatosSP(Int16 alu_id, string alu_bol, string alu_nom, string alu_apa, string alu_ama, string alu_sex, string alu_fnac, string alu_email, string alu_tel, Int16 alu_tipsan, Int16 alu_car, float alu_prom, Int16 oper)
        {
            bool exito = false;

            try{
                con.Open();
            }
            catch (Exception ex){
                Console.WriteLine("Error al intentar abrir la base de datos" + ex.ToString());
            }
            SqlTransaction trans = con.BeginTransaction(System.Data.IsolationLevel.Serializable);
            try
            {
                comQry = new SqlCommand("sp_ActualizaDatos", con, trans);
                comQry.CommandType = CommandType.StoredProcedure;
                comQry.Parameters.Clear();
                comQry.Parameters.AddWithValue("@id_alu", alu_id);
                comQry.Parameters.AddWithValue("@bol_alu", alu_bol);
                comQry.Parameters.AddWithValue("@nom_alu", alu_nom);
                comQry.Parameters.AddWithValue("@apa_alu", alu_apa);
                comQry.Parameters.AddWithValue("@ama_alu", alu_ama);
                comQry.Parameters.AddWithValue("@sex_alu", alu_sex);
                comQry.Parameters.AddWithValue("@fnac_alu", Convert.ToDateTime(alu_fnac));
                comQry.Parameters.AddWithValue("@email_alu", alu_email);
                comQry.Parameters.AddWithValue("@tel_alu", alu_tel);
                comQry.Parameters.AddWithValue("@tipsan_alu", alu_tipsan);
                comQry.Parameters.AddWithValue("@car_alu", alu_car);
                comQry.Parameters.AddWithValue("@prom_alu", alu_prom);
                comQry.Parameters.AddWithValue("@tipOper", oper);

                comQry.ExecuteNonQuery();
                exito = true;
                Console.WriteLine("La transacción fue exitosa");
            }
            catch(Exception ex){
                Console.WriteLine("La transacción NO exitosa --> "+ ex.ToString());
            }

            finally{
                if (exito)
                {
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            con.Close();
        }
        public string RegresaDatosSP(Int16 alu_id, Int16 tipOper)
        {
            string cadReg = "";
            DataTable tablaReg = new DataTable();
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al intentar abrir la base de datos" + ex.ToString());
            }

            try
            {
                SqlDataAdapter datos = new SqlDataAdapter("sp_RegresarDatos",con);
                datos.SelectCommand.CommandType = CommandType.StoredProcedure;
                datos.SelectCommand.Parameters.Add("@id_alu", alu_id);
                datos.SelectCommand.Parameters.Add("@tipOper", alu_id);

                datos.Fill(tablaReg);

                for(int ren=0; ren<tablaReg.Rows.Count; ren++)
                {
                    for (int col=0; col < tablaReg.Columns.Count; col++)
                    {
                        cadReg += tablaReg.Rows[ren][col].ToString() + "|";
                    }
                    cadReg += "$";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error de recuperación de datos -->" + ex.ToString());
            }
            con.Close();
            return cadReg;
        }
    }
}