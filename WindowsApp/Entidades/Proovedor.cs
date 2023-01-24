using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
   public class Proovedor
    {
        public string Nombre {get; set;}
        public string CUIT {get; set;}
        public string Contacto {get; set;}
        public string Email {get; set;}
        public string Telefono {get; set;}
        public string Direccion { get; set; }


        public Proovedor (string Nombre, string CUIT, string Contacto, string Email, string Telefono, string Direccion)
        {
            this.Nombre    = Nombre;
            this.CUIT      = CUIT;
            this.Contacto  = Contacto;
            this.Email     = Email;
            this.Telefono  = Telefono;
            this.Direccion = Direccion;
        }

    }
}
