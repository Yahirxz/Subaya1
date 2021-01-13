using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Subaya
{
    public partial class Registrarse : System.Web.UI.Page
    {
        string id = "";
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnx = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            //cnx.ConnectionString = "Data source = DESKTOP-RB041FV; initial catalog= Subaya ; integrated Security=true";
           cnx.ConnectionString = "Data source = DESKTOP-RORGF8I; initial catalog= Subaya ; integrated Security=true";

        }

        protected void entrar_Click(object sender, EventArgs e)
        {
           

           
                cmd.CommandText = "select * from Usuarios where usuario = '" + txtusuario.Text + "' or correo = '" + txtcorreo.Text + "'";
                cmd.Connection = cnx;
                data.SelectCommand = cmd;
                data.Fill(ds, "Usuarios");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (txtusuario.Text == ds.Tables[0].Rows[0].ItemArray[2].ToString())
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El usuario ya existe');", true);
                    }
                    if (txtcorreo.Text == ds.Tables[0].Rows[0].ItemArray[1].ToString())
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El correo ya esta registrado');", true);
                    }


                }
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    cmd.CommandText = "INSERT INTO Usuarios (correo, usuario, nombre, apellido, edad, tienda) VALUES (@correo, @usuario, @nombre, @apellido, @edad, @tienda) ";
                    cnx.Open();
                    cmd.Connection = cnx;
                    cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                    cmd.Parameters.AddWithValue("@usuario", txtusuario.Text);
                    cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtapellido.Text);
                    cmd.Parameters.AddWithValue("@edad", txtedad.Text);
                    cmd.Parameters.AddWithValue("@tienda", txttienda.Text);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "INSERT INTO Login (Usuario, Contrasena) VALUES (@usu, @Contra) ";
                    cmd.Connection = cnx;
                    cmd.Parameters.AddWithValue("@usu", txtusuario.Text);
                    cmd.Parameters.AddWithValue("@Contra", txtcontra.Text);
                    cmd.ExecuteNonQuery();
                    cnx.Close();

                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('El usuario registrado con exito');", true);
                    Response.Redirect("Login.aspx");
                }
            

        }
    }
}