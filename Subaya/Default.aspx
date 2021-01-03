<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Subaya._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="./Content/estilos.css">
    <div>
        <p>&nbsp<p/>
       <div>  <div class="usuario-box"><asp:Button ID="boton" runat="server" Text="Iniciar Sesion" OnClick="boton_Click" /> </div> <div class="buscador-box"> <asp:TextBox ID="Buscador" runat="server"/><asp:Button ID="Button1" runat="server" Text="Buscar" /></div></div>
             
    </div>
    <p>&nbsp<p/>
    <div class="slider">
    <ul>
        <li><img src="./Imagenes/principio/1.jpg"/></li>
        <li><img src="./Imagenes/principio/2.jpg"/></li>
        <li><img src="./Imagenes/principio/3.jpg"/></li>
        <li><img src="./Imagenes/principio/4.jpg"/></li>
    </ul>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2 class="lead" >  &nbsp &nbsp &nbsp &nbsp &nbsp  &nbsp   &nbsp  Madera</h2>
           

            <p>
                 <img src="./Imagenes/principio/madera.jpg" width ="250" height="300"/>
            </p>
          
        </div>
        <div class="col-md-4">
            <h2 class="lead" > &nbsp &nbsp &nbsp &nbsp  &nbsp  &nbsp &nbsp  &nbsp &nbsp Tela</h2>
            <p>
                 <img src="./Imagenes/principio/guaya.png" width ="250" height="300"/>
            </p>
           
        </div>
        <div class="col-md-4">
            <h2 class="lead">  &nbsp &nbsp &nbsp  &nbsp  &nbsp  &nbsp   &nbsp  &nbsp   Metales</h2>
            <p>
               <img src="./Imagenes/principio/metal.png" width ="250" height="300"/>
            </p>
            
        </div>
    </div>

</asp:Content>
