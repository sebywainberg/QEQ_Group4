using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;



namespace QEQC04.Models
{
    public class Personaje
    {
        private int Id;
        private string Nombre;
        private bool Sexo;
        private int Categoria;

        [Required(ErrorMessage = "el campo id es obligatorio*")]
        public int Id1 { get => Id; set => Id = value; }

        [Required(ErrorMessage = "el campo Nombre es obligatorio*")]
        public string Nombre1 { get => Nombre; set => Nombre = value; }

        [Required(ErrorMessage = "el campo Sexo es obligatorio*")]
        public bool Sexo1 { get => Sexo; set => Sexo = value; }

        [Required(ErrorMessage = "el campo Categoria es obligatorio*")]
        public int Categoria1 { get => Categoria; set => Categoria = value; }

        public Personaje()
        {
            Id1 = 0;
            Nombre1 = "";
            Sexo1 = false;
            Categoria1 = 0;

        }
        public Personaje(int idd, string name, bool sex, int cat)
        {
            Id1 = idd;
            Nombre1 = name;
            Sexo1 = sex;
            Categoria1 = cat;

        }
    }
}