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
            try
            {
                cnx.ConnectionString = "Data source = LAPTOP-9HTNGOSP; initial catalog= Subaya ; integrated Security=true";
                cnx.Open();
                SqlDataAdapter nombre = new SqlDataAdapter("SELECT * FROM Usuarios WHERE IdUsu = " + usuarioID, cnx);
                nombre.Fill(ds, "Usuarios");
                Session["correo"] = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                Session["nombre"] = ds.Tables[0].Rows[0].ItemArray[3].ToString();
                Session["apellido"] = ds.Tables[0].Rows[0].ItemArray[4].ToString();
                Session["edad"] = ds.Tables[0].Rows[0].ItemArray[5].ToString();
                Session["nombreTienda"] = ds.Tables[0].Rows[0].ItemArray[6].ToString();
            }catch(SqlException ex)
            {
                Console.WriteLine("Ha ocurrido un error" + ex);
            }
            finally
            {
                cnx.Close();
            }
            return ds.Tables[0].Rows[0].ItemArray[2].ToString();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("DatosPersonales.aspx");
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