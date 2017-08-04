using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pavel;
using System.Data;

public partial class proyectos_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Proyecto proy = new Proyecto();
        lvProyectos.DataSource = proy.obtenerDatosRelacionados();
        lvProyectos.DataBind();
        
    }
}
