using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pavel;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Proyecto proy = new Proyecto();
        lvProyectos.DataSource = proy.obtenerDatosRelacionados("3");
        lvProyectos.DataBind();

        Usuario u = new Usuario();
        lvUsuarios.DataSource = u.obtenerTodos();
        lvUsuarios.DataBind();

        Tareas t = new Tareas();
        lvTareas.DataSource = t.obtenerTareasActivas();
        lvTareas.DataBind();

    }
}
