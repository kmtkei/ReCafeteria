using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using RE_Cafeteria.Controlador;

namespace RE_Cafeteria.Modelo
{
    class BDUsuario
    {
        public void mostrar(ref DataTable DT) {
            Conexion conn = new Conexion();
            try
            {
                conn.abrir();
                SqlDataAdapter DA = new SqlDataAdapter("mostrar_todos", conn.conectar);
                DA.Fill(DT);
            }
            catch (Exception ex)
            {
            }
            finally {
                conn.cerrar();
            }
        }
        public bool insertar(ESUsuario nuevo)
        {
            Conexion conn = new Conexion();
            try
            {
                conn.abrir();
                SqlCommand insert = new SqlCommand("insertar_usuario", conn.conectar);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("@Nombre", nuevo.Nombre);
                insert.Parameters.AddWithValue("@Apellidos", nuevo.Apellidos);
                insert.Parameters.AddWithValue("@Usuario", nuevo.User);
                insert.Parameters.AddWithValue("@Pass", nuevo.Pass);
                insert.Parameters.AddWithValue("@Estado", nuevo.Estado);
                insert.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.cerrar();
            }
        }
        public bool eliminar(int id)
        {
            Conexion conn = new Conexion();
            try
            {
                conn.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_usuario", conn.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", id);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.cerrar();
            }
        }
        public bool modificar(ESUsuario usuariomod)
        {
              Conexion conn = new Conexion();
            try
            {
                conn.abrir();
                SqlCommand modificar = new SqlCommand("modificar_usuario", conn.conectar);
                modificar.CommandType = CommandType.StoredProcedure;
                modificar.Parameters.AddWithValue("@id", usuariomod.Id);
                modificar.Parameters.AddWithValue("@Nombre", usuariomod.Nombre);
                modificar.Parameters.AddWithValue("@Apellidos", usuariomod.Apellidos);
                modificar.Parameters.AddWithValue("@Usuario", usuariomod.User);
                modificar.Parameters.AddWithValue("@Pass", usuariomod.Pass);
                modificar.Parameters.AddWithValue("@Estado", usuariomod.Estado);
                modificar.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.cerrar();
            }
        }







    }
}
