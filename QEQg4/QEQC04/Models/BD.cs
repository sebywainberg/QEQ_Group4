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

        public static bool loginUsuario(string Username, string password)
        {
            bool Devuelve = false;
            SqlConnection conex = conectar();
            SqlCommand Consulta = conex.CreateCommand();
            Consulta.CommandText = "LoginUsuario";
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@username", Username);
            Consulta.Parameters.AddWithValue("@password", password);
            SqlDataReader dataReader = Consulta.ExecuteReader();
            if (dataReader.Read())
            {

                Devuelve = Convert.ToBoolean(dataReader["x"]);
            }
            desconectar(conex);
            return Devuelve;
        }
        public static int registerUsuario(string Username, string password, string nombre, bool EsAdmin = false, int puntos = 0)
        {
            int Devuelve = 0;
            SqlConnection conex = conectar();
            SqlCommand Consulta = conex.CreateCommand();
            Consulta.CommandText = "registerUsuario";
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            Consulta.Parameters.AddWithValue("@username", Username);
            Consulta.Parameters.AddWithValue("@password", password);
            Consulta.Parameters.AddWithValue("@nombre", nombre);
            Consulta.Parameters.AddWithValue("@puntos", puntos);
            Consulta.Parameters.AddWithValue("@esAdmin", EsAdmin);
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