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
        DataSet ds1 = new DataSet();
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
        public string[] tel = new string[255];
        public string[] img = new string[255];
        public string[] tienda = new string[255];
        public string[] correo = new string[255];
        protected void Page_Load(object sender, EventArgs e)
        {


            busc = Request.QueryString["Buscar"];

            if (busc !="" )
            {
                //cnx.ConnectionString = "Data source = DESKTOP-RB041FV; initial catalog= Subaya ; integrated Security=true";
                cnx.ConnectionString = "Data source = DESKTOP-RORGF8I; initial catalog= Subaya ; integrated Security=true";
                cmd.CommandText = "SELECT * FROM Publicaciones WHERE Descripcion like'%" + busc + "%' OR Caracteristicas like '%" + busc+"%' OR NombreP like '%"+busc+"%'";
                cmd.Connection = cnx;
                data.SelectCommand = cmd; 
                data.Fill(ds, "Publicaciones");
                num = ds.Tables[0].Rows.Count;

                


                for (int i = 0; i < num; i++)
                {

                    cmd.CommandText = "SELECT * FROM Usuarios WHERE IdUsu ='" + ds.Tables[0].Rows[i].ItemArray[5].ToString() + "'";
                    cmd.Connection = cnx;
                    data.SelectCommand = cmd;
                    data.Fill(ds1, "Usuarios");

                    nombre[i] = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    carac[i] = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    desc[i] = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    tel[i] = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    tienda[i] = ds1.Tables[0].Rows[i].ItemArray[6].ToString();
                    correo[i] = ds1.Tables[0].Rows[i].ItemArray[1].ToString();                    img[i] = Convert.ToBase64String((byte[])ds.Tables[0].Rows[i].ItemArray[6]);
                    busc = "";




                }

              

                }
            else {
                Response.Write("0 Resultados");
            }
            

        }

        
    }
}