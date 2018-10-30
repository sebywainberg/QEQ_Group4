using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace QEQg4.Models
{
    public static class BD
    {
        public static string connectionString = "server=10.128.8.16;Database=QEQC04;User ID=QEQC04;pwd=QEQC04";
        private static SqlConnection conectar()
        {
            SqlConnection conex = new SqlConnection(connectionString);
            conex.Open();
            return conex;
        }

        public static bool loginUsuario(usuario user)
        {
            bool Devuelve = false;
            SqlConnection conex = conectar();
            SqlCommand Consulta = conex.CreateCommand();
            Consulta.CommandText = "LoginUsuario";
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@username", user.Username1);
            Consulta.Parameters.AddWithValue("@password", user.Password1);
            SqlDataReader dataReader = Consulta.ExecuteReader();
            if (dataReader.Read())
            {

                Devuelve = Convert.ToBoolean(dataReader["x"]);
            }
            desconectar(conex);
            return Devuelve;
        }
        public static int registerUsuario(usuario jb)
        {
           jb.Puntos1 = 0;
           jb.EsAdmin1 = false;
            int Devuelve = 0;
            SqlConnection conex = conectar();
            SqlCommand Consulta = conex.CreateCommand();
            Consulta.CommandText = "registerUsuario";
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@username", jb.Username1);
            Consulta.Parameters.AddWithValue("@password", jb.Password1);
            Consulta.Parameters.AddWithValue("@nombre", jb.Nombre1);
            Consulta.Parameters.AddWithValue("@puntos", jb.Puntos1);
            Consulta.Parameters.AddWithValue("@esAdmin", jb.EsAdmin1);
            SqlDataReader dataReader = Consulta.ExecuteReader();
            if (dataReader.Read())
            {

                Devuelve = Convert.ToInt32(dataReader["x"]);
            }
            desconectar(conex);
            return Devuelve;
        }
        public static void desconectar(SqlConnection conex)
        {
            conex.Close();
        }
    }
}