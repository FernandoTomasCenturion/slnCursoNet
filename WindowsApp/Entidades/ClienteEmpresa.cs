using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
   public class ClienteEmpresa
    {
        public string Nombre;
        public string CUIT;
        public string Contacto;
        public string Email;
        public string Telefono;
        public string Direccion;


        public ClienteEmpresa(string Nombre, string CUIT, string Contacto, string Email, string Telefono, string Direccion)
        {
            this.Nombre = Nombre;
            this.CUIT = CUIT;
            this.Contacto = Contacto;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }

    }
}
