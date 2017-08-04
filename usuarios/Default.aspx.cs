using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Pavel;

public partial class usuarios_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Usuario _u = new Usuario();

        lvUsuarios.DataSource = _u.obtenerTodos();
        lvUsuarios.DataBind();

    }
}
