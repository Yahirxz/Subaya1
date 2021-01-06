<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contactos.aspx.cs" Inherits="Subaya.Contactos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <div class="container">
            <div class="row">
                <div class="col">
                    <h3>Contactos</h3>
                    <asp:Label ID="lblTelefono" runat="server"></asp:Label><br />
                    <asp:Label ID="lblCorreo" runat="server"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
