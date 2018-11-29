using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace QEQC04.Models
{
    public class CaracteristicaXPersonaje
    {
        private int _Personaje;
        private int _IdCaracteristica;

        [Required(ErrorMessage = "el campo Personaje es obligatorio*")]
        public int Personaje { get => _Personaje; set => _Personaje = value; }
        [Required(ErrorMessage = "el campo Id es obligatorio*")]
        public int IdCaracteristica { get => _IdCaracteristica; set => _IdCaracteristica = value; }
    }
}