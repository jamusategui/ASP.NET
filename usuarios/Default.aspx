<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="usuarios_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainPlaceHolder" Runat="Server">
    
    
    <h2>Listado de Usuarios</h2>
    <a href="crear.aspx" >Crear Usuario</a>
    <asp:ListView ID="lvUsuarios" runat="server">
        <LayoutTemplate>
            <table class="table">
            <thead>
                <tr>
                    <th>Usuario</th>
                    <th>Nombre Completo</th>
                    <th>Email</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                 <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%# Eval("username") %></td>
                <td><%# Eval("nombre") %> <%# Eval("apellido") %></td>
                <td><%# Eval("email") %></td>
                <td>
                    <a href="editar.aspx?id=<%# Eval("id") %>">Editar</a>
                    |
                    <a href="eliminar.aspx?id=<%# Eval("id") %>">Eliminar</a>
                </td>
             </tr>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>

