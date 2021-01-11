<%@ Page Title="Publicaciones" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Publicaciones.aspx.cs" Inherits="Subaya.Publicaciones" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <link rel="stylesheet" href="./Content/estilos.css">
    <div class="jumbotron">
     <h3>Mis publicaciones</h3>

       <div class="usuario-box" ><asp:Button ID="boton" runat="server" Text="Crear Publicacion" OnClick="agregar" /> </div>
    </div>

    <div>
        
       <%

               for (int i = 0 ; i < num; i++)
               {
                   Response.Write("<div class = 'publicacion-box'><p>"+nombre[i]
                   +"</p>"+carac[i]+"<p>"+desc[i]+"</p><p> Telefono: "+tel[i]+"</p><img src='data:image/jpg;base64,"+ing[i]+"' Width='200px' Height='200px'></div><p>&nbsp</p>");
           }

        %>

        
        </div>


    </asp:Content>