<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="editar.aspx.cs" Inherits="usuarios_crear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="leftPlaceHolder" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="mainPlaceHolder" Runat="Server">
    
    <asp:Label ID="lblMsg" runat="server"></asp:Label>
    
    <div class="form-horizontal">
    <h2>Editar Usuario</h2>
    <fieldset>
        <asp:HiddenField ID="txtIdUsuario" runat="server" />
        <div class="control-group">
            <label class="control-label" for="txtUsername">Username</label>
            <div class="controls">
                <asp:TextBox ID="txtUsername" runat="server" CssClass="span3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtUsername" Display="Dynamic" ErrorMessage="*">Requerido</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Password</label>
            <div class="controls">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="span3" 
                    TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtPassword" Display="Dynamic" ErrorMessage="*">Requerido</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Repetir Password</label>
            <div class="controls">
                <asp:TextBox ID="txtPassword2" runat="server" CssClass="span3" 
                    TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="*" ControlToValidate="txtPassword2">Requerido</asp:RequiredFieldValidator>
                
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="txtPassword" ControlToValidate="txtPassword2" 
                    Display="Dynamic" ErrorMessage="*">Password No Coinciden</asp:CompareValidator>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Nombre</label>
            <div class="controls">
                <asp:TextBox ID="txtNombre" runat="server" CssClass="span3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtNombre" ErrorMessage="*">Requerido</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Apellido</label>
            <div class="controls">
                <asp:TextBox ID="txtApellido" runat="server" CssClass="span3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtApellido" ErrorMessage="*">Requerido</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Email</label>
            <div class="controls">
                <asp:TextBox ID="txtEmail" runat="server" CssClass="span3"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtEmail" ErrorMessage="*">Requerido</asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="control-group">
            <label class="control-label">Telefono</label>
            <div class="controls">
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="span3"></asp:TextBox>
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
                CssClass="btn btn-success" onclick="btnCrearUsuario_Click" />
        </div>
    </fieldset>
    </div>

</asp:Content>

