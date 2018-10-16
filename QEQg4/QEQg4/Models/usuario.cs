using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QEQg4.Models
{
    public class usuario
    {
        private int _id;
        private string _username;
        private string _password;
        private string _Nombre;
        private int _puntos;
        private bool _EsAdmin;

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Puntos { get => _puntos; set => _puntos = value; }
        public bool EsAdmin { get => _EsAdmin; set => _EsAdmin = value; }
    }
}