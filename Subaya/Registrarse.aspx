<%@ Page Title="Registrarse"  Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Subaya.Registrarse" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"  >
     <link rel="stylesheet" href="./Content/estilos.css">

    <div class="registro-box">
        <img src="./Imagenes/Principio/nuevo.jpg">
        <h1>Registro</h1>

        <asp:Label ID="Label5" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="txtapellido" runat="server"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Text="Correo"></asp:Label>
        <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Edad"></asp:Label>
        <asp:TextBox ID="txtedad" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="Tienda"></asp:Label>
        <asp:TextBox ID="txttienda" runat="server"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="txtcontra" runat="server" TextMode="Password"></asp:TextBox>

        <asp:Button ID="entrar" runat="server" Text="Aceptar" OnClick="entrar_Click" />
        
    </div>
    </asp:Content>