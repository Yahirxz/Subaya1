using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subaya
{
    public partial class DatosPersonales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            verificarSesion();
            lblNombre.Text = (string)Session["nombre"] + " " + (string)Session["apellido"];
            lblEdad.Text = "<strong>Edad: </strong>" + (string)Session["edad"];
            lblCorreo.Text = "<strong>Correo electronico: </strong>" + (string)Session["correo"];
            lblNombreTienda.Text = "<strong>Nombre de la tienda: </strong>" + (string)Session["nombreTienda"];
        }

        private void verificarSesion()
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/Login.aspx");
        }
    }
}