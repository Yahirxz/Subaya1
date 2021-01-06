using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subaya
{
    public partial class Contactos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            verificarSesion();
            lblTelefono.Text = "<strong>Telefono:</strong>" + (string)Session["Telefono"];
            lblCorreo.Text = "<strong>Correo</strong>" + (string)Session["Correo"];
        }

        private void verificarSesion()
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/Login.aspx");
        }
    }
}