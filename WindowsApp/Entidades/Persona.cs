using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

        public Persona()
        {

        }

    }
}
