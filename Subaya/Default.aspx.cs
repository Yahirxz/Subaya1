﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Subaya
{
    public partial class _Default : Page
    {

        string nombre = "";
        protected void Page_Load(object sender, EventArgs e)
        {



            if (!IsPostBack)
            {
                nombre = Request.QueryString["usuario"];




                if (nombre == null)
                {

                    boton.Text = "Iniciar sesion";

                }

                else
                {

                    Session["usuario"] = nombre;

                    boton.Text = ((string)Session["usuario"]);

                }
            }

        }

        protected void boton_Click(object sender, EventArgs e)
        {

            if (Session["usuario"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            if(Session["usuario"] != null)

            { Response.Redirect("Usuario.aspx"); 
            
            }

        }

       
    }
}