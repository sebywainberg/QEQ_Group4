﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using QEQg4.Models;
using QEQC04.Models;
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
            user.Nombre1 = dataReader["Nombre"].ToString();
            user.EsAdmin1 = Convert.ToBoolean(dataReader["EsAdmin"]);
            user.Puntos1 = Convert.ToInt32(dataReader["puntos"]);
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
        //en la tabla caracteristicasxpersonaje
        public static bool ListarxCategoria(int id)
        {
            SqlConnection conexion = conectar();
            SqlCommand Consulta = conexion.CreateCommand();
            Consulta.CommandText = "ListarxCat";
            Consulta.Parameters.AddWithValue("@idcat",id);
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            bool Devuelve = Convert.ToBoolean(Consulta.ExecuteScalar());

            return Devuelve;
        }
        //en la tabla personaje
        public static bool ListarxCaracteristica( int id)
        {
            SqlConnection conexion = conectar();
            SqlCommand Consulta = conexion.CreateCommand();
            Consulta.CommandText = "ListarXCar";
            Consulta.Parameters.AddWithValue("@idcar",id);
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            bool Devuelve = Convert.ToBoolean(Consulta.ExecuteScalar());

            return Devuelve;
        }
        //en la tabla caracteristicasxpersonaje
        public static bool ListarxPersonaje(int id)
        {
            SqlConnection conexion = conectar();
            SqlCommand Consulta = conexion.CreateCommand();
            Consulta.CommandText = "ListarxPersonaje";
            Consulta.Parameters.AddWithValue("@idper",id);
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            bool Devuelve = Convert.ToBoolean(Consulta.ExecuteScalar());

            return Devuelve;
        }
        public static bool AltaPersonaje (Personaje a)
        {
            SqlConnection conexion = conectar();
            SqlCommand Consulta = conexion.CreateCommand();
            Consulta.CommandText = "Personajes_AM";
            Consulta.Parameters.AddWithValue("@Nombre", a.Nombre1);
            Consulta.Parameters.AddWithValue("@Sexo", a.Sexo1);
            Consulta.Parameters.AddWithValue("@Categoria", a.Categoria1);
          Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            bool Devuelve = Convert.ToBoolean(Consulta.ExecuteScalar());
            return Devuelve;
        }
        public static bool ModPersonaje (Personaje j)
        {
            SqlConnection conexion = conectar();
            SqlCommand Consulta = conexion.CreateCommand();
            Consulta.CommandText = "Personajes_AM";
            Consulta.Parameters.AddWithValue("@id", j.Id1);
            Consulta.Parameters.AddWithValue("@Nombre", j.Nombre1);
            Consulta.Parameters.AddWithValue("@Sexo", j.Sexo1);
            Consulta.Parameters.AddWithValue("@Categoria", j.Categoria1);
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            bool Devuelve = Convert.ToBoolean(Consulta.ExecuteScalar());
            return Devuelve;
        }
        public static bool BajaPersonaje(int id)
        {
            SqlConnection conexion = conectar();
            SqlCommand Consulta = conexion.CreateCommand();
            Consulta.CommandText = "Personajes_B";
            Consulta.Parameters.AddWithValue("@id", id);
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            bool Devuelve = Convert.ToBoolean(Consulta.ExecuteScalar());
            return Devuelve;
        }
        public static List<usuario> RankingJug()
        {

            List<usuario> listUs = new List<usuario>();
            
            SqlConnection conexion = conectar();
            SqlCommand Consulta = conexion.CreateCommand();
            Consulta.CommandText = "RankingJug";
            Consulta.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dataReader = Consulta.ExecuteReader();
            while (dataReader.Read())
            {
                usuario a = new usuario();
                a.Nombre1 = dataReader["Nombre"].ToString();
                a.Username1 = dataReader["username"].ToString();
                a.Puntos1 = Convert.ToInt32(dataReader["puntos"]);
                a.Password1 = dataReader["contra"].ToString();
                a.EsAdmin1 = Convert.ToBoolean(dataReader["EsAdmin"]);
                a.Id1 = Convert.ToInt32(dataReader["id"]);
                listUs.Add(a);
            }
            return listUs;
        }
    }
}