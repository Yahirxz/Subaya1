<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DatosTienda.aspx.cs" Inherits="Subaya.DatosTienda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="container">
            <div class="row">
                <div class="col-md-4">
                    <asp:Image ID="Image1" runat="server" Height="200px" ImageUrl="~/Imagenes/principio/tienda.png" /><br />
                    <h3><asp:Label ID="lblNombreTienda" runat="server"></asp:Label></h3>
                </div>
                <div class="col-md-8">
                    <h2>Datos de la tienda</h2>
                    <asp:Label ID="lblDireccionTienda" runat="server"></asp:Label><br />
                    <asp:Label ID="lblTipoArtesanias" runat="server"></asp:Label><br />
                    <asp:Label ID="lblNombreDueño" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
