using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Data;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Subaya
{
    
    public partial class Publicaciones : System.Web.UI.Page
    {
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnx = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        DataSet ds = new DataSet();
        string id;
        public string[] nombre = new string[255];
        public string[] carac = new string[255];
        public string[] desc = new string[255];
        public string[] tel = new string[255];
        public string[] ing = new string[255];
        public int num; 


        protected void Page_Load(object sender, EventArgs e)
        {

            id = Request.QueryString["id"];
            verificarSesion(); 

            cnx.ConnectionString = "Data source = DESKTOP-RB041FV; initial catalog= Subaya ; integrated Security=true";
            cmd.CommandText = "select * from Publicaciones where idUsuario = '" + 1 +"'";
            cmd.Connection = cnx;
            data.SelectCommand = cmd;
            data.Fill(ds, "Publicaciones");
            num = ds.Tables[0].Rows.Count;

            for (int i = 0; i < num; i++)
            {

               

                nombre[i] = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                carac[i]= ds.Tables[0].Rows[i].ItemArray[2].ToString();
                desc[i] = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                tel[i] = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                ing[i] = Convert.ToBase64String((byte[])ds.Tables[0].Rows[i].ItemArray[6]);
                
                
                

            }


        }
        private void verificarSesion()
        {
            if (id == null)
                Response.Redirect("~/Login.aspx");
        }

        protected void agregar(object sender, EventArgs e)
        {

         
           id = Request.QueryString["id"];
           Response.Redirect("AgregarPublicacion.aspx?id=" + id);

            

        }
    }
}