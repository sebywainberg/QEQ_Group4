using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QEQC04.Models
{
    public class Caracteristica
    {
        private int _IdCarac;
        private string _Nombre;
        private string _PreguntaTexto;

        [Required(ErrorMessage = "el campo id es obligatorio*")]
        public int IdCarac { get => _IdCarac; set => _IdCarac = value; }
        [Required(ErrorMessage = "el campo Nombre es obligatorio*")]
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        [Required(ErrorMessage = "el campo Pregunta es obligatorio*")]
        public string PreguntaTexto { get => _PreguntaTexto; set => _PreguntaTexto = value; }
    }
}