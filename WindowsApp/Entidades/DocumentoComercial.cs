using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
    public abstract class DocumentoComercial
    {

        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIva { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }

        public DocumentoComercial()
        {

        }
    }
}
