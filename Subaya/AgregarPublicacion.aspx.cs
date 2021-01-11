using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace Subaya
{
    public partial class AgregarPublicacion : System.Web.UI.Page
    {
        string id = "";
        
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnx = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
          

            cnx.ConnectionString = "Data source = DESKTOP-RB041FV; initial catalog= Subaya ; integrated Security=true";
            verificarSesion(); 


        }
        private void verificarSesion()
        {
            if (id == null)
                Response.Redirect("~/Login.aspx");
        }
        protected void agregarPub(object sender, EventArgs e)
        {


          
           

            if ( imagen.PostedFile.FileName =="" || nombre.Text==null || carac.Text==null|| desc.Text==null|| tel.Text==null) 

            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Deber completar todos los campos');", true);
            }

            else {

                int tamanio = imagen.PostedFile.ContentLength;
                byte[] imgOriginal = new byte[tamanio];
                imagen.PostedFile.InputStream.Read(imgOriginal, 0, tamanio);
                Bitmap imgBin = new Bitmap(imagen.PostedFile.InputStream);
                String imgb64 = "data:image/jpg;base64," + Convert.ToBase64String(imgOriginal);
                Image1.ImageUrl = imgb64;


                cmd.CommandText = "INSERT INTO Publicaciones (NombreP, Caracteristicas, Descripcion, telefono, idUsuario, imagen) VALUES (@nombre, @cac, @desc, @tel, @id, @img) ";
                cnx.Open();
                cmd.Connection = cnx;
                cmd.Parameters.AddWithValue("@nombre", nombre.Text);
                cmd.Parameters.AddWithValue("@cac", carac.Text);
                cmd.Parameters.AddWithValue("@desc", desc.Text);
                cmd.Parameters.AddWithValue("@tel", tel.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@img", SqlDbType.Image).Value = imgOriginal;

                cmd.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Publicacion guardada con exito');", true);

            }


        }

        }
    }