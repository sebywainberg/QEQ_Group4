using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace QEQC04.Models
{
    public class Categoria
    {
        private int _IdCategoria;
        private string _Nombre;
        [Required(ErrorMessage = "el campo id es obligatorio*")]
        public int IdCategoria { get => _IdCategoria; set => _IdCategoria = value; }
        [Required(ErrorMessage = "el campo Nombre es obligatorio*")]
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}