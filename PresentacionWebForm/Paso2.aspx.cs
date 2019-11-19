using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace PresentacionWebForm
{
    public partial class Paso2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEnviar1_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoNegocio productoNegocio = new ProductoNegocio();

            try
            {
                producto.Titulo = "Mochila Notebook";
                producto.Descripcion = "Mochila ideal para Notebooks de gran tamaño";
                producto.URLImagen = "Mochila Notebook";

                productoNegocio.agregarProducto(producto);

                Response.Redirect("~/Paso3.aspx");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        protected void BtnEnviar2_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoNegocio productoNegocio = new ProductoNegocio();

            try
            {
                producto.Titulo = "Auriculares Gamer";
                producto.Descripcion = "Auricular inalambrico";
                producto.URLImagen = "Auriculares Gamer.jpg";

                productoNegocio.agregarProducto(producto);

                Response.Redirect("~/Paso3.aspx");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        protected void BtnEnviar3_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            ProductoNegocio productoNegocio = new ProductoNegocio();

            try
            {
                producto.Titulo = "Mouse Gamer";
                producto.Descripcion = "Mouse inalambrico marca Microsoft que funciona por bluetooth";
                producto.URLImagen = "Mouse Gamer.jpg";

                productoNegocio.agregarProducto(producto);

                Response.Redirect("~/Paso3.aspx");
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}