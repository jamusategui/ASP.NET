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
    public class Usuario
    {

        public string nombre;
        public string apellido;
        public string email;

        static string connString = "Server=localhost;Database=pm;User Id=root;Pwd=";
        MySqlConnection _conn = new MySqlConnection(connString);
        public Usuario()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// Crear un nuevo usuario
        /// </summary>
        /// <param name="usuario">El username</param>
        /// <param name="password">Password</param>
        /// <param name="nombre">El nombre</param>
        /// <param name="apellido">Apellido </param>
        /// <param name="email">Email</param>
        /// <param name="telefono">Telefono</param>
        /// <param name="activo">activo</param>
        /// <returns>True cuando el usuario es creado, false si falla</returns>
        public bool Crear(string usuario, string password, string nombre, string apellido, string email, string telefono, string activo) 
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("insert into usuarios(username, password, nombre, apellido, email, telefono, activo) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                    usuario, password, nombre, apellido, email, telefono, activo);

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
        /// Elimina un Usuario
        /// </summary>
        /// <param name="id">El id del usuario a eliminar</param>
        /// <returns></returns>
        public bool eliminar(int id) 
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("delete from usuarios where id = {0}", id);

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
        /// Desactiva un usuario
        /// </summary>
        /// <param name="id">El id del usuario a desactivar</param>
        /// <returns></returns>
        public bool desactivarPorID(int id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("update usuarios set activo = 0 where id = {0}", id);

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
        /// Activa un usuario
        /// </summary>
        /// <param name="id">El id del usuario a activar</param>
        /// <returns></returns>
        public bool activarPorID(int id)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("update usuarios set activo = 1 where id = {0}", id);

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
        /// Obtiene un usuario por ID
        /// </summary>
        /// <param name="id">El ID del usuario a obtener</param>
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
                _cmd.CommandText = String.Format("select * from usuarios where id = {0}", id);
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
        /// Obtiene todos los usuarios
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
                _cmd.CommandText = "select * from usuarios";
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
        /// Actualiza los datos de un usuario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="email"></param>
        /// <param name="telefono"></param>
        /// <param name="activo"></param>
        /// <returns></returns>
        public bool actualizarUsuario(int id, string usuario, string password, string nombre, string apellido, string email, string telefono, string activo)
        {
            bool _flag = false;

            try
            {
                MySqlCommand _cmd = new MySqlCommand();
                _cmd.Connection = _conn;
                _cmd.CommandType = CommandType.Text;
                _cmd.CommandText = String.Format("update usuarios set username = '{0}', password = '{1}', nombre = '{2}', apellido = '{3}', email = '{4}', telefono = '{5}', activo ='{6}' where id = {7}",
                    usuario, password, nombre, apellido, email, telefono, activo, id);

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

    }
}
