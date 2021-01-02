<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Subaya._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead"> Encuentra artesanias sin salir de casa
           
            <asp:Button ID="boton" runat="server" Text="Iniciar Sesion" OnClick="boton_Click" />

        </p>

        <img src="./Imagenes/principio/contactos.jpg"/>
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
