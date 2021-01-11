<%@ Page Title="Busqueda" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="Subaya.Busqueda" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="./Content/estilos.css">
    <div class="jumbotron">
        <h3>Resultados Busqueda: <%# Eval("NombreP") %></h3>
    </div>
      <div class="contenedor">
       <%

               for (int i = 0 ; i < num; i++)
               {
                   Response.Write("<div class = 'item'><div class='item'><img src='data:image/jpg;base64,"+img[i]+"' class='item-img''><div class='item-text'><h3>"+nombre[i]
                   +"</h3><p>"+carac[i]+"</p><p>"+desc[i]+"</p></div><p>&nbsp</p></div></div>");
           }

        %>
          </div>

    </asp:Content>