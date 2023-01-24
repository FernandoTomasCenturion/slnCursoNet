using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
    public class ClienteIndividuo
    {
        public string Nombre;
        public string Apellido;
        public string CUIT;
        public string Email;
        public string Telefono;
        public string Direccion;


        public ClienteIndividuo()
        {
        }

        public string nombreClienteIndividuo()
        {
            return Nombre;
        }       

        public string apellidoClienteIndividuo()
        {
            return Apellido;
        }

        public string cuitClienteIndividuo()
        {
            return CUIT;
        }

        public string emailClienteIndividuo()
        {
            return Email;
        }

        public string telefonoClienteIndividuo()
        {
            return Telefono;
        }

        public string direccionClienteIndividuo()
        {
            return Direccion;
        }

        }

}
