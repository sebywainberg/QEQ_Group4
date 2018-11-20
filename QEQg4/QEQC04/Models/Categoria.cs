using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QEQC04.Models
{
    public class Categoria
    {
        private int _IdCategoria;
        private string _Nombre;

        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}