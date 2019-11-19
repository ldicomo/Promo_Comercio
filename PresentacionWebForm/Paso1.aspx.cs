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
    public partial class Paso1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSiguiente_Click(object sender, EventArgs e)
        {  
            VoucherNegocio voucherNegocio = new VoucherNegocio();
            List<Voucher> listado = new List<Voucher>();
            bool coincidencia = false;

            try
            { 
                listado = voucherNegocio.listarVoucher();
                foreach (Voucher lista in listado)
                {
                    if (lista.CodigoVoucher == TxtVoucher.Text)
                    {
                        coincidencia = true;
                    }
                }
                if (coincidencia)
                {
                    Response.Redirect("~/Paso2.aspx");
                }
                else
                {
                    Response.Write("<script language='JavaScript'>alert('El código no se encontró')</script>");
                }
                /*
                Voucher voucher = new Voucher();
                for (var index=0; index<listado.Count; index++)
                {
                    if (voucher.CodigoVoucher == TxtVoucher.Text)
                    {
                        coincidencia = true;
                    }
                }
                if (coincidencia)
                {
                    Response.Redirect("~/Paso2.aspx");
                }
                */
            }
            catch (Exception ex)
            {
                Session.Add("El código no se encontró", ex);
                Response.Write("<script language='JavaScript'>alert('El código no se encontró')</script>");
            }           
        }
    }
}