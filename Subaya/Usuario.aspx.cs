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
        string nombre1 = "";
        string id = "";
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnx = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            nombre1 = Request.QueryString["usuario"];
            id = Request.QueryString["id"];

            if (!IsPostBack)
            {
                verificarSesion();
                string nombre = buscarId(id);
                lblNombre.Text = "Buen dia" + " " + nombre;
            }
        }
        private void verificarSesion()
        {
            if (id == null)
                Response.Redirect("~/Login.aspx");
        }

        private string buscarId(string usuarioID)
        {
            SqlConnection cnx = new SqlConnection();
            DataSet ds = new DataSet();

            cnx.ConnectionString = "Data source = DESKTOP-RB041FV; initial catalog= Subaya ; integrated Security=true";
            cmd.CommandText = "select Usuario from Login where ID = '" + id + "'";
            cmd.Connection = cnx;
            data.SelectCommand = cmd;
            data.Fill(ds, "Login");
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
            Response.Redirect("Contactos.aspx?id=" + id);
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Publicaciones.aspx?id=" + id);
        }
    }
}
