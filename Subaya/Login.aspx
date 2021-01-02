<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Subaya.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h3>Login.</h3>
    <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
        <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
        <asp:TextBox ID="Contra" runat="server"></asp:TextBox>
        <asp:Button ID="entrar" runat="server" Text="Button" OnClick="Entrar_Click"/>
    </div>

   
  

    </asp:Content>
