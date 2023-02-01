using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public double Margen { get; set;}
        public double PrecioCosto { get; set; }
        public decimal PrecioBruto { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Proovedor { get; set; }
        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
        public decimal IVA { get; set; }
        public string Subcategoria { get; internal set; }

        public Producto()
        {

        }

        public string nombreProducto()
        {
            return Nombre;
        }

        public string descripcionProducto()
        {
            return Descripcion;
        }

        public double margenProducto()
        {
            return Margen;
        }

        public double precioCostoProducto()
        {
            return PrecioCosto;
        }

        public decimal precioBrutoProducto()
        {
            return (Convert.ToDecimal(this.PrecioCosto + this.Margen));
        }

        public decimal precioVentaProducto()
        {
            return this.PrecioBruto + Convert.ToDecimal(1 + this.IVA);
        }

        public string proveedorProducto()
        {
            return Proovedor;
        }

    }
}
