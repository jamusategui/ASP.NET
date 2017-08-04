using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pavel;

public partial class usuarios_crear : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCrearUsuario_Click(object sender, EventArgs e)
    {
        Usuario _u = new Usuario();
        string _checked;
        if (chkActivo.Checked)
        {
            _checked = "1";
        }
        else 
        {
            _checked = "0";
        }

        bool t = _u.Crear(txtUsername.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text, _checked);

        if (t)
        {
            lblMsg.Text = String.Format("El usuario: {0} ha sido creado exitosamente", txtUsername.Text);
            lblMsg.CssClass = "alert alert-info";
        }
        else
        {
            lblMsg.Text = String.Format("El usuario: {0} No pudo ser creado", txtUsername.Text);
            lblMsg.CssClass = "alert alert-error";
        }
    }
}
