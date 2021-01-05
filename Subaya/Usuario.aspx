<%@ Page Title="Usuario" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Subaya.Usuario" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2>
            <asp:Label ID="lblNombre" runat="server"></asp:Label><br />
        </h2>
        <strong><span style="color: #EF7472; font-size: 16px; margin:10px 0px|">Bienvenido</span></strong>
        <div class="container" style="border: 1px solid #F6857C; border-radius:10px; padding: 5px 15px">
            <div class="row">
                <div class="col-md-4">
                    <p style="margin:0px"> Datos personales</p><asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="/Imagenes/principio/datosPersonales.jpeg" Width="100%" Height="200px" OnClick="ImageButton1_Click" />
                </div>
                <div class="col-md-4">
                   <p style="margin:0px"> Datos de la tienda</p> <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="/Imagenes/principio/datosTienda.jpeg" Width="100%" Height="200px" OnClick="ImageButton2_Click" />
                </div>
                <div class="col-md-4">
                    <p style="margin:0px">Contactos</p><asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="/Imagenes/principio/contactos.jpeg" Width="100%" Height="200px" OnClick="ImageButton3_Click" />
                </div>
            </div>
            <br />
            <br />
            <div class="row">
               <div class="col-12">
                   <p style="margin:0px">Publicaciones</p> <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="/Imagenes/principio/publicaciones.jpeg" OnClick="ImageButton4_Click" Width="100%" />
               </div>
            </div>
        </div>
    </div>




</asp:Content>
