<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="detalle.aspx.cs" Inherits="proyectos_detalle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainPlaceHolder" Runat="Server">

    <h2>Detalle Proyecto: <asp:Label ID="lblNombreProyecto" runat="server"></asp:Label></h2>
    
    <table class="table table-bordered">
        <tr>
            <td>Nombre</td>
            <td><asp:Label ID="lblNombre" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Descripcion</td>
             <td><asp:Label ID="lblDesc" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Responsable</td>
             <td><asp:Label ID="lblResponsable" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Fecha Inicio</td>
             <td><asp:Label ID="lblInicio" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Fecha Fin</td>
             <td><asp:Label ID="lblFin" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td colspan="2">
               <h3>Tareas</h3>
                <asp:ListView ID="lvTareas" runat="server">
                    <LayoutTemplate>
                        <table class="table">
                            <thead>
                            <tr>
                                <th>Tarea</th>
                                <th>Responsable</th>
                                <th>Fecha Fin</th>
                                <th>Completar</th>
                            </tr>
                            </thead>
                            <tbody>
                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </tbody>
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("nombre") %></td>
                            <td><%# Eval("username") %></td>
                            <td><%# Eval("fecha_fin") %></td>
                            <td><input type="checkbox" name="chkbox" value="<%# Eval("id") %>" /></td>
                        </tr>
                    </ItemTemplate>
                </asp:ListView>
            </td>
        </tr>
    </table>
    
    
</asp:Content>

