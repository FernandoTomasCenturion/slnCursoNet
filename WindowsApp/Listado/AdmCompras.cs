using WindowsApp.Entidades;

namespace Negocio.Listado
{
    public static class AdmCompras
    {
        public static void Agregar(Producto p, int cantidad)
        {
            AdmProductos.productos.Add(p);
        }
        public static void Modificar(int cantidad) { }        
        public static void Eliminar(string nombre) { }
        public static void Confirmar(Vendedor v) { }
        public static void Cancelar() { }
    }
}
