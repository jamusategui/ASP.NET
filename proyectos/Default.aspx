<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="proyectos_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainPlaceHolder" Runat="Server">
    <h2>Listado de Proyectos</h2>
    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/proyectos/crear.aspx">Crear Proyecto</asp:HyperLink>
    
    <asp:ListView ID="lvProyectos" runat="server">
    <LayoutTemplate>
        <table class="table">
            <thead>
                <tr>
                    <th>Proyecto</th>
                    <th>Fecha Inicio</th>
                    <th>Fecha Fin</th>
                    <th>Responsable</th>
                    <th>Tareas</th>
                    <th>Acciones</th>
                </tr>
            </thead>
            <tbody>
                <asp:PlaceHolder id="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </tbody>
        </table>
    </LayoutTemplate>
    <ItemTemplate>
        <tr>
            <td><a href="/pm/proyectos/detalle.aspx?id=<%# Eval("proyID") %>" ><%# Eval("proyNombre") %></a></td>
            <td><%# Eval("fecha_ini") %></td>
            <td><%# Eval("fecha_fin") %></td>
            <td><a href="/usuarios/editar.aspx?id=<%# Eval("userID") %>" ><%# Eval("username") %></a></td>
            <td></td>
            <td><a href="/pm/proyectos/editar.aspx?id=<%# Eval("proyID") %>" >Editar</a>
                <a href="/pm/proyectos/eliminar.aspx?id=<%# Eval("proyID") %>" >Eliminar</a>
                <a href="/pm/tareas/agregar.aspx?id=<%# Eval("proyID") %>" >Tareas</a>
            </td>
        </tr>
    </ItemTemplate>
    </asp:ListView>
    
    
</asp:Content>

