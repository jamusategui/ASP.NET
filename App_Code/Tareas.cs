using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// Summary description for Usuario
/// </summary>

namespace Pavel
{
    public class Tareas
    {
        static string connString = "Server=localhost;Database=pm;User Id=root;Pwd=";
        MySqlConnection _conn = new MySqlConnection(connString);

        public Tareas()
        {
            
        }

        public bool Crear(string nombre, string descripcion, string fechafin, string activo, int usuario_id, int proyectoID)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("insert into tareas(nombre, descripcion, fecha_fin, activo, usuario_id, proyecto_id ) values('{0}','{1}','{2}','{3}','{4}','{5}')",
                    nombre, descripcion, fechafin, activo, usuario_id, proyectoID);

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
        /// Elimina una Tarea
        /// </summary>
        /// <param name="id">El id de la tarea a eliminar</param>
        /// <returns></returns>
        public bool eliminar(int id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("delete from tareas where id = {0}", id);

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
        /// Completa una Tarea
        /// </summary>
        /// <param name="id">El id de la tarea a marcar como completada</param>
        /// <returns></returns>
        public bool completarTarea(int id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("update tareas set activo = 0 where id = {0}", id);

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
        /// Reactivar una tarea
        /// </summary>
        /// <param name="id">El id de la tarea a reactivar</param>
        /// <returns></returns>
        public bool reactivarTarea(int id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("update tareas set activo = 1 where id = {0}", id);

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

        public DataSet obtenerTareasPorProyecto(int proyID)
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("select t.*, u.username from tareas t inner join usuarios u on t.usuario_id = u.id  where proyecto_id = {0}", proyID);
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

        public DataSet obtenerTareas()
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "select t.*, u.username from tareas t inner join usuarios u on t.usuario_id = u.id ";
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

        public DataSet obtenerTareasActivas()
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = "select t.*, u.username from tareas t inner join usuarios u on t.usuario_id = u.id and t.activo = 1";
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

        public DataSet obtenerTareasPorUsuario(int usuarioID)
        {
            //bool _flag = false;
            DataSet ds = new DataSet();

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("select * from tareas where usuario_id = {0}", usuarioID);
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

    }
}
