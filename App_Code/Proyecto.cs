using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Pavel;

/// <summary>
/// Summary description for Usuario
/// </summary>

namespace Pavel
{
    public class Proyecto
    {
        static string connString = "Server=localhost;Database=pm;User Id=root;Pwd=";
        MySqlConnection _conn = new MySqlConnection(connString);
        public Proyecto() {}

        public bool Crear(string nombre, string descripcion, string fechaini, string fechafin, string activo, int usuario_id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("insert into proyectos(nombre, descripcion, fecha_ini, fecha_fin, activo, usuario_id ) values('{0}','{1}','{2}','{3}','{4}','{5}')",
                    nombre, descripcion, fechaini, fechafin, activo, usuario_id);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _conn.Close();
                _flag = true;
            }
            catch
            {
                throw new Exception();
            }

            return _flag;
        }


        /// <summary>
        /// Elimina un Proyecto
        /// </summary>
        /// <param name="id">El id del proyecto a eliminar</param>
        /// <returns></returns>
        public bool eliminar(int id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("delete from proyectos where id = {0}", id);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _conn.Close();
                _flag = true;
            }
            catch
            {
                throw new Exception();
            }

            return _flag;
        }

        /// <summary>
        /// Desactiva un Proyecto
        /// </summary>
        /// <param name="id">El id del proyecto a desactivar</param>
        /// <returns></returns>
        public bool desactivarPorID(int id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("update proyectos set activo = 0 where id = {0}", id);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _conn.Close();
                _flag = true;
            }
            catch
            {
                throw new Exception();
            }

            return _flag;
        }

        /// <summary>
        /// Activa un Proyecto
        /// </summary>
        /// <param name="id">El id del proyecto a activar</param>
        /// <returns></returns>
        public bool activarPorID(int id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("update proyectos set activo = 1 where id = {0}", id);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _conn.Close();
                _flag = true;
            }
            catch
            {
                throw new Exception();
            }

            return _flag;
        }


        /// <summary>
        /// Obtiene un Proyecto por su ID
        /// </summary>
        /// <param name="id">El ID del proyecto a obtener</param>
        /// <returns></returns>
        public DataSet obtenerPorID(int id)
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("select * from proyectos where id = {0}", id);
                MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);


                _conn.Open();
                _cmd.ExecuteNonQuery();
                _da.Fill(ds);
                _conn.Close();
            }
            catch
            {
                throw new Exception();
            }

            return ds;
        }

        /// <summary>
        /// Obtiene todos los Proyectos
        /// </summary>
        /// <returns></returns>
        public DataSet obtenerTodos()
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "select * from proyectos";
                MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _da.Fill(ds);
                _conn.Close();
            }
            catch
            {
                throw new Exception();
            }

            return ds;
        }

        /// <summary>
        /// Obtiene proyectos activos
        /// </summary>
        /// <returns></returns>
        public DataSet obtenerActivos()
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "select * from proyectos where activo = 1";
                MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _da.Fill(ds);
                _conn.Close();
            }
            catch
            {
                throw new Exception();
            }

            return ds;
        }

        /// <summary>
        /// Obtiene proyectos Inactivos
        /// </summary>
        /// <returns></returns>
        public DataSet obtenerInactivos()
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "select * from proyectos where activo = 0";
                MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _da.Fill(ds);
                _conn.Close();
            }
            catch
            {
                throw new Exception();
            }

            return ds;
        }

       
        /// <summary>
        /// Obtiene todos los proyectos segun su estatus
        /// </summary>
        /// <param name="status">True: si activo, False: inactivos</param>
        /// <returns></returns>
        public DataSet obtenerTodos(bool status)
        {
            //bool _flag = false;
            int estado = 0;
            if (status)
            {
                 estado = 1;
            }
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("select * from proyectos where activo = {0}", estado);
                MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _da.Fill(ds);
                _conn.Close();
            }
            catch
            {
                throw new Exception();
            }

            return ds;
        }


        public DataSet obtenerDatosRelacionados()
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "select p.id as proyID, p.nombre as proyNombre, p.descripcion as proyDesc, fecha_ini, fecha_fin, p.activo as proyActivo, u.id as userID, username, password, u.nombre as userNombre, apellido, email, telefono, u.activo as userActivo  from proyectos p join usuarios u on p.usuario_id = u.id";
                MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _da.Fill(ds);
                _conn.Close();
            }
            catch
            {
                throw new Exception();
            }

            return ds;
        }


        public DataSet obtenerDatosRelacionados(string limit)
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "select p.id as proyID, p.nombre as proyNombre, p.descripcion as proyDesc, fecha_ini, fecha_fin, p.activo as proyActivo, u.id as userID, username, password, u.nombre as userNombre, apellido, email, telefono, u.activo as userActivo  from proyectos p join usuarios u on p.usuario_id = u.id limit " + limit;
                MySqlDataAdapter _da = new MySqlDataAdapter(_cmd);

                _conn.Open();
                _cmd.ExecuteNonQuery();
                _da.Fill(ds);
                _conn.Close();
            }
            catch
            {
                throw new Exception();
            }

            return ds;
        }

        /// <summary>
        /// Obtiene los datos del Gerente de un proyecto
        /// </summary>
        /// <param name="proyectoID">El Id del proyecto</param>
        /// <returns></returns>
        public DataSet obtenerPM(int proyectoID)
        {
            
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("select usuario_id from proyectos where id = {0}", proyectoID);
                
                _conn.Open();
                int usuarioId = int.Parse(_cmd.ExecuteScalar().ToString());
                _conn.Close();

                Usuario u = new Usuario();
                ds = u.obtenerPorID(usuarioId);

            }
            catch
            {
                throw new Exception();
            }

            return ds;
        }
    }
}
