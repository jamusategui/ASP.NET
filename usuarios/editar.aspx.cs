using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pavel;
using System.Data;

public partial class usuarios_crear : System.Web.UI.Page
{
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"]);

        if (!IsPostBack)
        {
            Usuario _u = new Usuario();
            ds = _u.obtenerPorID(id);
            popularDatos();
        }
               
    }

    protected void popularDatos()
    {
        txtIdUsuario.Value = ds.Tables[0].Rows[0]["id"].ToString();
        txtUsername.Text = ds.Tables[0].Rows[0]["username"].ToString();
        txtPassword.Text = ds.Tables[0].Rows[0]["password"].ToString();
        txtPassword2.Text = ds.Tables[0].Rows[0]["password"].ToString();
        txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
        txtApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
        txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
        txtTelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
        chkActivo.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["activo"]);
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

        bool t = _u.actualizarUsuario(Convert.ToInt32(txtIdUsuario.Value) ,txtUsername.Text, txtPassword.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, txtTelefono.Text, _checked);

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
