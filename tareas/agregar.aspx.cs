using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Pavel;

public partial class tareas_agregar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Usuario _u = new Usuario();

        ddlResponsable.DataSource = _u.obtenerTodos();
        ddlResponsable.DataTextField = "username";
        ddlResponsable.DataValueField = "id";
        ddlResponsable.DataBind();
    }

    protected void btnAgregarTarea_Click(object sender, EventArgs e)
    {
        Tareas _t = new Tareas();
        
        string _checked;
        if (chkCompletada.Checked)
        {
            _checked = "1";
        }
        else 
        {
            _checked = "0";
        }

        int proyID = int.Parse(Request.QueryString["id"]);

        bool success = _t.Crear(txtNombreTask.Text, txtDesc.Text, txtFechaFin.Text, _checked, int.Parse(ddlResponsable.SelectedValue), proyID);

        if (success)
        {
            msg.Text = String.Format("El Proyecto: {0} ha sido creado exitosamente", txtNombreTask.Text);
            msg.CssClass = "alert alert-info";
        }
        else
        {
            msg.Text = String.Format("El proyecto: {0} No pudo ser creado", txtNombreTask.Text);
            msg.CssClass = "alert alert-error";
        }

    }
}
