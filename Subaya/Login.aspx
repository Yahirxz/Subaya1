<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Subaya.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server"  >
     <link rel="stylesheet" href="./Content/estilos.css">
    
 
    <div class="login-box">
        <img src="./Imagenes/Principio/user.png">
        <h1>Inicio de sesion</h1>
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="Contra" runat="server"></asp:TextBox>
        <asp:Button ID="entrar" runat="server" Text="Aceptar" OnClick="Entrar_Click"/>
        <asp:Button ID="Regisatarse" runat="server" Text="Registrarse" />
    </div>
     
  

    </asp:Content>
