<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="crear.aspx.cs" Inherits="proyectos_crear" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainPlaceHolder" Runat="Server">
<asp:Label ID="lblMsg" runat="server"></asp:Label>
    <div class="form-horizontal">
    <h2>Crear Nuevo Proyecto</h2>
    <fieldset>
        <div class="control-group">
            <label class="control-label" for="txtNombreProy">Nombre Proyecto</label>
            <div class="controls">
                <asp:TextBox ID="txtNombreProy" runat="server" CssClass="span3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNombreProy" Display="Dynamic" ErrorMessage="*">Requerido</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Descripcion</label>
            <div class="controls">
                <asp:TextBox ID="txtDesc" runat="server" CssClass="span3" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Fecha Inicio</label>
            <div class="controls">
                <asp:TextBox ID="txtFechaIni" runat="server" CssClass="span3" 
                     ></asp:TextBox>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Fecha Fin</label>
            <div class="controls">
                <asp:TextBox ID="txtFechaFin" runat="server" CssClass="span3"></asp:TextBox>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Gerente de Proyecto</label>
            <div class="controls">
                <asp:DropDownList ID="ddlGerente" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Activo</label>
            <div class="controls">
                <asp:CheckBox ID="chkActivo" runat="server" CssClass="span3"></asp:CheckBox>
            </div>
        </div>
        
        <div class="control-group">
            <asp:Button ID="btnCrearUsuario" runat="server" Text="Crear Usuario" 
                CssClass="btn btn-success" onclick="btnCrearProyecto_Click" />
        </div>
    </fieldset>
    </div>

</asp:Content>

