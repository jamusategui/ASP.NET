using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Pavel;
using System.Data;

public partial class proyectos_detalle : System.Web.UI.Page
{
    Proyecto p = new Proyecto();
    Usuario _u = new Usuario();
    protected void Page_Load(object sender, EventArgs e)
    {
        int id = int.Parse(Request.QueryString["id"]);

        DataSet dsProyecto = p.obtenerPorID(id);

        if (dsProyecto.Tables[0].Rows.Count > 0)
        {
            lblNombreProyecto.Text = dsProyecto.Tables[0].Rows[0]["nombre"].ToString();
            lblNombre.Text =  dsProyecto.Tables[0].Rows[0]["nombre"].ToString();
            lblDesc.Text = dsProyecto.Tables[0].Rows[0]["descripcion"].ToString();
            lblInicio.Text =  dsProyecto.Tables[0].Rows[0]["fecha_ini"].ToString();
            lblFin.Text = dsProyecto.Tables[0].Rows[0]["fecha_fin"].ToString();
            
            int userID = int.Parse(dsProyecto.Tables[0].Rows[0]["usuario_id"].ToString());
            
            DataSet dsUsuario = _u.obtenerPorID(userID);

            lblResponsable.Text = dsUsuario.Tables[0].Rows[0]["nombre"].ToString() + " " + dsUsuario.Tables[0].Rows[0]["apellido"].ToString();

            Tareas t = new Tareas();
            lvTareas.DataSource = t.obtenerTareasPorProyecto(id);
            lvTareas.DataBind();


        }

    }

    protected void chkbox_OnCheckedChanged(object sender, EventArgs e)
    { 
        
    }
}
