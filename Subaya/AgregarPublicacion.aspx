<%@ Page Title="Agregar Publicacion" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="AgregarPublicacion.aspx.cs" Inherits="Subaya.AgregarPublicacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="./Content/estilos.css">

    <p></p>
    
        <div >
        <p>Nombre de publicacion <asp:TextBox ID="nombre" runat="server"></asp:TextBox></p>
        <p>Caracteristicas <asp:TextBox ID="carac" runat="server"></asp:TextBox></p>
        <p>Descripcion <asp:TextBox ID="desc" runat="server"></asp:TextBox></p>
        <p>Telefono <asp:TextBox ID="tel" runat="server"></asp:TextBox></p>
            <p><asp:Image ID="Image1" runat="server" ImageUrl="/Imagenes/principio/cal.png" Height="209px" Width="194px" /></p>
        <p>Imagen <asp:FileUpload ID="imagen" runat="server" /></p>
           
       </div>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="agregarPub" />

    </asp:Content>
