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
        String id;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnx = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        SqlDataAdapter data1 = new SqlDataAdapter();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            verificarSesion();
            //cnx.ConnectionString = "Data source = DESKTOP-RB041FV; initial catalog= Subaya ; integrated Security=true";
            cnx.ConnectionString = "Data source = DESKTOP-RORGF8I; initial catalog= Subaya ; integrated Security=true";
            id = Request.QueryString["id"];
            cmd.CommandText = "SELECT * FROM Usuarios WHERE IdUsu ='" + id + "'";
            cmd.Connection = cnx;
            data.SelectCommand = cmd;
            data.Fill(ds, "Usuarios");

            lblNombre.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString() +" "+ ds.Tables[0].Rows[0].ItemArray[4].ToString();
            lblEdad.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();

            lblCorreo.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            lblNombreTienda.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
        }

        private void verificarSesion()
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/Login.aspx");
        }
    }
}