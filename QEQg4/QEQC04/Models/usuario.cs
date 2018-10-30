using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

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




        public int Id1
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        [Required(ErrorMessage ="El campo nombre de usuario es obligatorio*")]
        public string Username1
        {
            get
            {
                return _username;
            }

            set
            {
                _username = value;
            }
        }

        [Required(ErrorMessage = "el campo contraseña es obligatorio*")]
        public string Password1
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        [Required(ErrorMessage ="el campo nombre es obligatorio*")]
        public string Nombre1
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public int Puntos1
        {
            get
            {
                return _puntos;
            }

            set
            {
                _puntos = value;
            }
        }

        public bool EsAdmin1
        {
            get
            {
                return _EsAdmin;
            }

            set
            {
                _EsAdmin = value;
            }
        }

        public usuario(int idd, string user, string pass, string Nomb, int punto, bool EsAdm)
        {
            _id = idd;
            _username = user;
            _password = pass;
            _Nombre = Nomb;
            _puntos = punto;
            _EsAdmin = EsAdm;
        }

        public usuario()
        {
            _id = 0;
            _username = "";
            _password = "";
            _Nombre = "";
            _puntos = 0;
            _EsAdmin = false;
        }
    }

}