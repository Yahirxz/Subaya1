<%@ Page Title="Agregar Publicacion" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="AgregarPublicacion.aspx.cs" Inherits="Subaya.AgregarPublicacion" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="./Content/estilos.css">

    <p></p>
    
        <div class="registro-box" >
             
            <asp:Image ID="Image1" runat="server" ImageUrl="/Imagenes/principio/cal.png" />
            <asp:Label ID="Label1" runat="server" Text="Nombre de la publicacion"></asp:Label>
            <asp:TextBox ID="nombre" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Caracteristicas"></asp:Label>
            <asp:TextBox ID="carac" runat="server"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="Descripcion"></asp:Label>
            <asp:TextBox ID="desc" runat="server"></asp:TextBox>

            <asp:Label ID="Label4" runat="server" Text="Telefono"></asp:Label>
            <asp:TextBox ID="tel" runat="server"></asp:TextBox>
            
            <asp:Label ID="Label5" runat="server" Text="Imagen"></asp:Label><asp:FileUpload ID="imagen" runat="server" />
            <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="agregarPub" />

       </div>
   

    </asp:Content>
