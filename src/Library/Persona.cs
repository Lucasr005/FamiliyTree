using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona (string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public int ObtenerLargoNombre ()
        {
            return this.Nombre.Length;
        }
    }
}