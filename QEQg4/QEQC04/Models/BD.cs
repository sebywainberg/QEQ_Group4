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
            SqlConnection conex = conectar();
            SqlCommand Consulta = conex.CreateCommand();
            Consulta.CommandText = "LoginUsuario";
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@username", user.Username1);
            Consulta.Parameters.AddWithValue("@password", user.Password1);
            SqlDataReader dataReader = Consulta.ExecuteReader();
            bool Devuelve = dataReader.Read();
            desconectar(conex);
            return Devuelve;
        }
        public static bool registerUsuario(usuario jb)
        {
            jb.Puntos1 = 1000000;
            jb.EsAdmin1 = false;
            SqlConnection conex = conectar();
            SqlCommand Consulta = conex.CreateCommand();
            Consulta.CommandText = "registerUsuario";
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@username", jb.Username1);
            Consulta.Parameters.AddWithValue("@password", jb.Password1);
            Consulta.Parameters.AddWithValue("@nombre", jb.Nombre1);
            Consulta.Parameters.AddWithValue("@puntos", jb.Puntos1);
            Consulta.Parameters.AddWithValue("@esAdmin", jb.EsAdmin1);
            bool Devuelve = Convert.ToBoolean(Consulta.ExecuteScalar());
            desconectar(conex);
            return Devuelve;
        }
        public static void desconectar(SqlConnection conex)
        {
            conex.Close();
        }
    }
}