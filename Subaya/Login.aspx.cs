using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;

namespace Subaya
{
    public partial class Login : System.Web.UI.Page
    {

        SqlCommand cmd = new SqlCommand();
        SqlConnection cnx = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string id;

        protected void Page_Load(object sender, EventArgs e)
        {

            //cnx.ConnectionString = "Data source = DESKTOP-RB041FV; initial catalog= Subaya ; integrated Security=true";
            cnx.ConnectionString = "Data source = DESKTOP-RORGF8I; initial catalog= Subaya ; integrated Security=true";
            //Cambiar esto por los parametros de su computadora la mia es esta pero la de ustedes es la de sus computadoras en la ventana que les sale cuando inician sqlServer 2014


        }



        protected void Entrar_Click(object sender, EventArgs e)
        {

           

            cmd.CommandText = "select* from Login where Usuario = '" + Usuario.Text + "' and Contrasena = '"+Contra.Text+"'";
            cmd.Connection = cnx;
            data.SelectCommand = cmd;
            data.Fill(ds, "Login");


            if (ds.Tables[0].Rows.Count > 0)
            {
                cmd.CommandText = "select ID from Login where Usuario = '" + Usuario.Text + "' and Contrasena = '" + Contra.Text + "'";
                cmd.Connection = cnx;
                data.SelectCommand = cmd;
                data.Fill(ds, "Login");


                Response.Redirect("Default.aspx?id=" + ds.Tables[0].Rows[0].ItemArray[0].ToString() +"&usuario="+Usuario.Text); 
               


            }
            else {

                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Credenciales Incorrectas');", true);
                
            }

        }

        protected void Regisatarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registrarse.aspx");
        }
    }
}