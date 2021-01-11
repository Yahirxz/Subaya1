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
    public partial class DatosTienda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            verificarSesion();
            SqlConnection cnx = new SqlConnection();
            DataSet ds = new DataSet();
            try
            {
                cnx.ConnectionString = "Data source = LAPTOP-9HTNGOSP; initial catalog= Subaya ; integrated Security=true";
                cnx.Open();
                SqlDataAdapter nombre = new SqlDataAdapter("SELECT * FROM Tiendas WHERE idTienda = ", cnx);
                nombre.Fill(ds, "Tiendas");
                lblNombreTienda.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
                lblDireccionTienda.Text = "<strong> Direccion de la tienda: </strong>" + ds.Tables[0].Rows[0].ItemArray[2].ToString();
                lblTipoArtesanias.Text = "<strong> Tipo de artesanias: </strong>" + ds.Tables[0].Rows[0].ItemArray[3].ToString();
                lblNombreDueño.Text = "<strong> Nombre del dueño: </strong>" + ds.Tables[0].Rows[0].ItemArray[4].ToString();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Ha ocurrido un error" + ex);
            }
            finally
            {
                cnx.Close();
            }
        }

        private void verificarSesion()
        {
            if (Session["usuario"] == null)
                Response.Redirect("~/Login.aspx");
        }
    }
}