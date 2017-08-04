<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="eliminar.aspx.cs" Inherits="usuarios_eliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainPlaceHolder" Runat="Server">
    <h2>Eliminar Usuario</h2>
    <asp:Label id="msg" runat="server" ></asp:Label>
    
    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" 
        CssClass="btn btn-success" onclick="btnAceptar_Click" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn" 
        onclick="btnCancelar_Click" />
    
    
</asp:Content>

