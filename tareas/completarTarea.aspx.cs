using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pavel;

public partial class tareas_completarTarea : System.Web.UI.Page
{
    Tareas t = new Tareas();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"]);
        
        if (t.completarTarea(id))
        {
            Response.Write("Listo");
        }
        else
        {
            Response.Write("Error");
        }

    }
}
