using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using Pavel;
using System.Data;

public partial class usuarios_eliminar : System.Web.UI.Page
{

    Usuario _u = new Usuario();

    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"]);
        
        DataSet ds = _u.obtenerPorID(id);

        if (ds.Tables[0].Rows.Count > 0)
        {
            msg.Text = String.Format("Esta seguro que desea eliminar el usuario {0}?", ds.Tables[0].Rows[0]["username"].ToString());
        }
        else
        {
            btnAceptar.Visible = false;
            msg.Text = "Usuario no existe";
        }
    }


    protected void btnAceptar_Click(object sender, EventArgs e)
    {

        btnAceptar.Visible = false;
        btnCancelar.Text = "Volver Al Listado";

        if (_u.eliminar(int.Parse(Request.QueryString["id"])))
        {
            msg.CssClass = "alert alert-info";
            msg.Text = "Usuario eliminado";
        }
        else 
        {
            msg.CssClass = "alert alert-error";
            msg.Text = "No se Pudo eliminar el usuario";
        }

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("default.aspx");
    }
    
}
