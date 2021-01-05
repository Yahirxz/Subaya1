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
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                verificarSesion();
                string nombre = buscarId(Session["usuario"].ToString());
                lblNombre.Text = "Buen dia" + " " + nombre;
            }
        }
    private void verificarSesion()
    {
        if (Session["usuario"] == null)
            Response.Redirect("~/Login.aspx");
    }

        private string buscarId(string usuarioID)
        {
            SqlConnection cnx = new SqlConnection();
            DataSet ds = new DataSet();
            cnx.ConnectionString = "Data source = LAPTOP-9HTNGOSP; initial catalog= Subaya ; integrated Security=true";
            cnx.Open();
            SqlDataAdapter nombre = new SqlDataAdapter("SELECT Usuario FROM Login WHERE ID = " + usuarioID, cnx);
            nombre.Fill(ds, "Login");
            cnx.Close();
            return ds.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Perfil.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("DatosTienda.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Contactos.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Publicaciones.aspx");
        }
    }

}