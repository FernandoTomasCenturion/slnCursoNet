using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
    public class Vendedor
    {
        public string Nombre;
        public string Apellido;
        public string DNI;
        public string Email;
        public string Telefono;
        public string Direccion;

        public Vendedor (string Nombre, string Apellido, string DNI, string Email, string Telefono, string Direccion)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.DNI = DNI;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        } 
    }
}
