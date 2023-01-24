using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsApp.Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            Producto producto = new Producto();
            InitializeComponent();
        }

        private void producto_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = "Nombre1";
            producto.Descripcion = "Descripción 1";
            producto.Margen = 2.22;
            producto.PrecioCosto = 2.21;
            producto.PrecioBruto = 2.1m;
            producto.PrecioVenta = 2.2m;
            producto.Categoria = "Categoria1";
            producto.SubCategoria = "SubCategoria1";
            producto.IVA = 0.21m;

            MessageBox.Show(producto.Nombre + "" + producto.Descripcion + "" + producto.Margen.ToString() + ""
                            + producto.PrecioCosto.ToString() + "" + producto.PrecioBruto.ToString() + "" + 
                            producto.PrecioVenta.ToString() + "" + producto.Categoria + "" + producto.SubCategoria + "" 
                            + producto.IVA.ToString());
        }

        private void clienteIndividuo_Click(object sender, EventArgs e)
        {
            ClienteIndividuo clienteIndividuo = new ClienteIndividuo();
            clienteIndividuo.Nombre   = "Tomas";
            clienteIndividuo.Apellido = "Centurion";
            clienteIndividuo.CUIT = "201234560";
            clienteIndividuo.Email = "ferc721@gmail.com";
            clienteIndividuo.Telefono = "12345678";
            clienteIndividuo.Direccion = "av. siempre viva 1234";

            MessageBox.Show(clienteIndividuo.Nombre + " " + clienteIndividuo.Apellido + " " + clienteIndividuo.CUIT + " " +
                            clienteIndividuo.CUIT + " " + clienteIndividuo.Telefono + " " + clienteIndividuo.Direccion
                            );
        }
    }
}
