using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
    public class Factura
    {
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIva { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }

        public Factura(string Tipo, string Numero, DateTime Fecha, string Cliente, string Direccion, 
                       string CondicionIva, string CondicionVenta, string Detalle, decimal Total)
        {
            this.Tipo = Tipo;
            this.Numero = Numero;
            this.Fecha = Fecha;
            this.Cliente = Cliente;
            this.Direccion = Direccion;
            this.CondicionIva = CondicionIva;
            this.CondicionIva = CondicionVenta;
            this.Detalle = Detalle;
            this.Total = Total;
        }
    }
}
