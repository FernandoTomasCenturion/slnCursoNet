using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
    public class Remito
    {
        public string Numero;
        public DateTime Fecha;
        public string Cliente;
        public string Direccion;
        public string CondicionIva;
        public string CondicionVenta;
        public string Detalle;
        public DateTime FechaEntrega;
        public decimal Total;

        public Remito(string Numero, DateTime Fecha, string Cliente, string Direccion, 
                      string CondicionIva, string CondicionVenta, string Detalle, 
                      DateTime FechaEntrega, decimal Total)
        {
            this.Numero = Numero;
            this.Fecha = Fecha;
            this.Cliente = Cliente;
            this.Direccion = Direccion;
            this.CondicionIva = CondicionIva;
            this.CondicionVenta = CondicionVenta;
            this.Detalle = Detalle;
            this.FechaEntrega = FechaEntrega;
            this.Total = Total;
        }

    }
}
