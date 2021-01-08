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
    public partial class Busqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection cnx = new SqlConnection();
            SqlDataAdapter data = new SqlDataAdapter();
            DataTable dt = new DataTable();

            cnx.ConnectionString = "Data source = EDWIN-C\\SQLEXPRESS; initial catalog= Subaya ; integrated Security=true";
            cmd.CommandText = "SELECT [NombreP], [Descripcion], [Caracteristicas] FROM [Publicaciones] WHERE [NombreP] LIKE '" + txtBuscar.Text + "%'";
            cmd.Connection = cnx;
            data.SelectCommand = cmd;
            data.Fill(dt);
            ListView1.DataSource = dt;
            ListView1.DataBind();
        }
    }
}