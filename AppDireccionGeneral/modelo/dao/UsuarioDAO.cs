using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using AppDireccionGeneral.modelo.db;
using AppDireccionGeneral.modelo.poco;

namespace AppDireccionGeneral.modelo.dao
{
    class UsuarioDAO
    {
        public static List<Usuario> getAllUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT u.idUsuario, u.nombreUsuario, " +
                        "u.contrasenia, u.nombre, u.apellidoPaterno, " +
                        "u.apellidoMaterno, u.cargo, u.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Usuario u INNER JOIN " +
                        "SistemaVehicular.dbo.Delegacion d " +
                        "ON u.idDelegacion = d.idDelegacion;";
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.IdUsuario = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        usuario.NombreUsuario = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        usuario.Contrasenia = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        usuario.Nombre = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        usuario.ApellidoPaterno = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        usuario.ApellidoMaterno = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        usuario.Cargo = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        usuario.IdDelegacion = (!dataReader.IsDBNull(7)) ? dataReader.GetInt32(7) : 0;
                        usuario.Delegacion = (!dataReader.IsDBNull(8)) ? dataReader.GetString(8) : "";

                        usuarios.Add(usuario);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción UsuarioDAO getAllUsuarios():");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------------------------\n");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return usuarios;
        }

        public static void agregarUsuario(Usuario usuario)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("INSERT INTO SistemaVehicular.dbo.Usuario " +
                        "(nombreUsuario, contrasenia, apellidoPaterno, apellidoMaterno, cargo, idDelegacion, nombre) " +
                        "VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                        usuario.NombreUsuario, usuario.Contrasenia, usuario.ApellidoPaterno,
                        usuario.ApellidoMaterno, usuario.Cargo, usuario.IdDelegacion, usuario.Nombre);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción UsuarioDAO agregarUsuario(Usuario usuario):");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------------------------\n");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public static void modificarUsuario(Usuario usuario)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("UPDATE SistemaVehicular.dbo.Usuario " +
                        "SET nombreUsuario = '{0}', contrasenia = '{1}', nombre = '{2}', " +
                        "apellidoPaterno = '{3}', apellidoMaterno = '{4}', cargo = '{5}', " +
                        "idDelegacion = {6} " +
                        "WHERE idUsuario = {7};",
                        usuario.NombreUsuario, usuario.Contrasenia, usuario.Nombre,
                        usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Cargo,
                        usuario.IdDelegacion, usuario.IdUsuario);

                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción UsuarioDAO modificarUsuario(Usuario usuario):");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------------------------\n");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public static void eliminarUsuario(Usuario usuario)
        {
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("DELETE FROM SistemaVehicular.dbo.Usuario " +
                        "WHERE idUsuario = {0}", usuario.IdUsuario);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción UsuarioDAO eliminarUsuario(Usuario usuario):");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------------------------\n");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public static List<Usuario> getPeritos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT u.idUsuario, u.nombreUsuario, " +
                        "u.contrasenia, u.nombre, u.apellidoPaterno, " +
                        "u.apellidoMaterno, u.cargo, u.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Usuario u INNER JOIN " +
                        "SistemaVehicular.dbo.Delegacion d " +
                        "ON u.idDelegacion = d.idDelegacion " +
                        "WHERE u.cargo = 'Perito';";
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Usuario usuario = new Usuario();

                        usuario.IdUsuario = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        usuario.NombreUsuario = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        usuario.Contrasenia = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        usuario.Nombre = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        usuario.ApellidoPaterno = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        usuario.ApellidoMaterno = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        usuario.Cargo = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        usuario.IdDelegacion = (!dataReader.IsDBNull(7)) ? dataReader.GetInt32(7) : 0;
                        usuario.Delegacion = (!dataReader.IsDBNull(8)) ? dataReader.GetString(8) : "";

                        usuarios.Add(usuario);
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción UsuarionDAO getPeritos():");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------------------------\n");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return usuarios;
        }

        public static Usuario getUsuario(String nombreUsuario)
        {
            Usuario usuario = new Usuario();
            SqlConnection conn = null;
            try
            {
                conn = ConexionBD.getConecction();
                if (conn != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT u.idUsuario, u.nombreUsuario, " +
                        "u.contrasenia, u.nombre, u.apellidoPaterno, " +
                        "u.apellidoMaterno, u.cargo, u.idDelegacion, d.nombre " +
                        "FROM SistemaVehicular.dbo.Usuario u INNER JOIN " +
                        "SistemaVehicular.dbo.Delegacion d " +
                        "ON u.idDelegacion = d.idDelegacion " +
                        "WHERE u.nombreUsuario = '{0}';", nombreUsuario);
                    command = new SqlCommand(query, conn);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        usuario.IdUsuario = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        usuario.NombreUsuario = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        usuario.Contrasenia = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        usuario.Nombre = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        usuario.ApellidoPaterno = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        usuario.ApellidoMaterno = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        usuario.Cargo = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        usuario.IdDelegacion = (!dataReader.IsDBNull(7)) ? dataReader.GetInt32(7) : 0;
                        usuario.Delegacion = (!dataReader.IsDBNull(8)) ? dataReader.GetString(8) : "";
                    }
                    dataReader.Close();
                    command.Dispose();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\nExcepción UsuarionDAO getUsuario(String nombreUsuario, String contrasenia):");
                Console.WriteLine(e.Message);
                Console.WriteLine("----------------------------------------------------------------\n");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return usuario;
        }

    }

}
