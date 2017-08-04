<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="agregar.aspx.cs" Inherits="tareas_agregar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainPlaceHolder" Runat="Server">

<div class="form-horizontal">
    
    <asp:Label id="msg" runat="server"></asp:Label>

    <h2>Agregar Tareas a Proyecto</h2>
    <fieldset>
        <div class="control-group">
            <label class="control-label" for="txtNombreTask">Nombre Tarea</label>
            <div class="controls">
                <asp:TextBox ID="txtNombreTask" runat="server" CssClass="span3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtNombreTask" Display="Dynamic" ErrorMessage="*">Requerido</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Descripcion</label>
            <div class="controls">
                <asp:TextBox ID="txtDesc" runat="server" CssClass="span3" TextMode="MultiLine"></asp:TextBox>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Fecha Fin</label>
            <div class="controls">
                <asp:TextBox ID="txtFechaFin" runat="server" CssClass="span3"></asp:TextBox>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Responsable</label>
            <div class="controls">
                <asp:DropDownList ID="ddlResponsable" runat="server"></asp:DropDownList>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Completada</label>
            <div class="controls">
                <asp:CheckBox ID="chkCompletada" runat="server" CssClass="span3"></asp:CheckBox>
            </div>
        </div>
        
        <div class="control-group">
            <asp:Button ID="btnCrearUsuario" runat="server" Text="Agregar Tarea" 
                CssClass="btn btn-success" onclick="btnAgregarTarea_Click" />
        </div>
    </fieldset>
    </div>

</asp:Content>

