using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace QEQg4.Models
{
    public static class BD
    {
        public static string connectionString = "sever=10.128.8.16;Database=QEQC04;User ID=QEQC04;pwd=QEQC04";
        private static SqlConnection conectar()
        {
            SqlConnection conex = new SqlConnection(connectionString);
          conex.Open();
          return conex;
        }

        public static string loginUsuario(string Username, string password)
        {
            string Devuelve = "";
            SqlConnection conex = conectar();
            SqlCommand Consulta = conex.CreateCommand();
            Consulta.CommandText = "LoginUsuario";
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@username", Username);
            Consulta.Parameters.AddWithValue("@password", password);
            SqlDataReader dataReader = Consulta.ExecuteReader();
            if(dataReader.Read())
            {
                Devuelve = dataReader["username"].ToString();
            }
            desconectar(conex);
            return Devuelve;
        }
        public static void desconectar( SqlConnection conex)
        {
            conex.Close();
        }
    }
}