<%@ Page Title="Busqueda" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="Subaya.Busqueda" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h3>Resultados Busqueda</h3>
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    </div>
    <div class="container">
        <asp:ListView ID="ListView1" runat="server" GroupItemCount="1">
            <ItemTemplate>
                <div class="col-md-4">
                    <table>
                        <tr><td>
                            <h1><%# Eval("NombreP") %></h1>
                        </td></tr>
                        <tr><td>
                            <p><%# Eval("Descripcion") %>
                            </p>
                        </td></tr>
                        <tr><td>
                            <p><%# Eval("Caracteristicas") %></p>
                        </td></tr>
                    </table>
                   </div>
            </ItemTemplate>

        </asp:ListView>
    </div>

    </asp:Content>

