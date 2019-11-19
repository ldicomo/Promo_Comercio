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
    public partial class Paso3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            List<Cliente> listado = new List<Cliente>();

            try
            {
                listado = clienteNegocio.listarCliente();
                foreach (Cliente lista in listado)
                {
                    if (lista.Dni == Convert.ToInt64(TxtDni.Text))
                    {
                        TxtNombre.Text = lista.Nombre;
                        TxtApellido.Text = lista.Apellido;
                        TxtEmail.Text = lista.Email;
                        TxtDomicilio.Text = lista.Domicilio;
                        TxtCiudad.Text = lista.Ciudad;
                        TxtCp.Text = lista.CodigoPostal;
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("No se pudo enviar", ex);
            }
        }

        protected void BtnParticipar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            try
            {
                cliente.Dni = Convert.ToInt64(TxtDni.Text);
                cliente.Nombre = TxtNombre.Text;
                cliente.Apellido = TxtApellido.Text;
                cliente.Email = TxtEmail.Text;
                cliente.Domicilio = TxtDomicilio.Text;
                cliente.Ciudad = TxtCiudad.Text;
                cliente.CodigoPostal = TxtCp.Text;

                clienteNegocio.agregarCliente(cliente);
                Response.Write("<script language='JavaScript'>alert('El envío se realizó correctamente')</script>");
            }
            catch (Exception ex)
            {
                Session.Add("No se pudo enviar", ex);
                Response.Write("<script language='JavaScript'>alert('No se pudo enviar')</script>");
            }
        }
    }
}