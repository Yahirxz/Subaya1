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
        String busc;
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnx = new SqlConnection();
        SqlDataAdapter data = new SqlDataAdapter();
        SqlDataAdapter data1 = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public string ima;
        public int num;
        public string[] nombre = new string[255];
        public string[] carac = new string[255];
        public string[] desc = new string[255];
        
        public string[] img = new string[255];
        protected void Page_Load(object sender, EventArgs e)
        {

            
           
            
           

            busc = Request.QueryString["Buscar"];

            if (busc !="" )
            {
                cnx.ConnectionString = "Data source = DESKTOP-RB041FV; initial catalog= Subaya ; integrated Security=true";
                cmd.CommandText = "SELECT * FROM Publicaciones WHERE contains(NombreP, '" + busc + "')";
                cmd.Connection = cnx;
                data.SelectCommand = cmd;
                data1.SelectCommand = cmd;
                data.Fill(ds, "Publicaciones");

               
                num = ds.Tables[0].Rows.Count;

                for (int i = 0; i < num; i++)
                {



                    nombre[i] = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    carac[i] = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    desc[i] = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    img[i] = Convert.ToBase64String((byte[])ds.Tables[0].Rows[i].ItemArray[6]);





                }

              

                }
            else {
                Response.Write("0 Resultados");
            }
            

        }

        
    }
}