using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pavel;
using System.Data;

public partial class proyectos_crear : System.Web.UI.Page
{
    Usuario _u = new Usuario();
    Proyecto _p = new Proyecto();
    protected void Page_Load(object sender, EventArgs e)
    {
        fillGerentes();
    }

    private void fillGerentes() 
    {
        DataSet ds = _u.obtenerTodos();
        ddlGerente.DataSource = ds;
        ddlGerente.DataValueField = "id";
        ddlGerente.DataTextField = "username";
        ddlGerente.DataBind();
    }

    protected void btnCrearProyecto_Click(object sender, EventArgs e)
    {
        string _checked;
        if (chkActivo.Checked)
        {
            _checked = "1";
        }
        else 
        {
            _checked = "0";
        }
        
        bool success = _p.Crear(txtNombreProy.Text, txtDesc.Text, txtFechaIni.Text, txtFechaFin.Text, _checked, int.Parse(ddlGerente.SelectedValue));

        if (success)
        {
            lblMsg.Text = String.Format("El Proyecto: {0} ha sido creado exitosamente", txtNombreProy.Text);
            lblMsg.CssClass = "alert alert-info";
        }
        else
        {
            lblMsg.Text = String.Format("El proyecto: {0} No pudo ser creado", txtNombreProy.Text);
            lblMsg.CssClass = "alert alert-error";
        }
    }
    
}
