<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosPersonales.aspx.cs" Inherits="Subaya.DatosPersonales" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <img alt="" src="Imagenes/principio/guest.png" style="border-radius:100px" height="200px" />
                    <h3><asp:Label ID="lblNombre" runat="server" Text=""></asp:Label></h3>
                </div>
                <div class="col-md-8">
                    <h2>Datos Personales</h2>
                    <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label><br />
                    <asp:Label ID="lblEdad" runat="server" Text=""></asp:Label><br />
                    <asp:Label ID="lblNombreTienda" runat="server" Text=""></asp:Label><br />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
