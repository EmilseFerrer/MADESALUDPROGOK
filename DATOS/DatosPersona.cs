using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class DatosPersona:DatosConexionBD
    {
        public int AbmPersonas(string accion, Persona objPersona)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO Personas (IdPersona, Nombre, Apellido, DNI, Telefono, Direccion, FechaNacimiento, Rol, Clave) " +
                        "VALUES (@IdPersona, @Nombre, @Apellido, @DNI, @Telefono, @Direccion, @FechaNacimiento, @Rol, @Clave)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Personas SET Nombre=@Nombre, Apellido=@Apellido, DNI=@DNI, Telefono=@Telefono, " +
                        "Direccion=@Direccion, FechaNacimiento=@FechaNacimiento, Rol=@Rol, Clave=@Clave " +
                        "WHERE IdPersona=@IdPersona";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Personas WHERE IdPersona=@IdPersona";
            }

            using (SqlConnection conexion = ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion(conexion);

                    // Parámetros comunes para Alta y Modificar
                    if (accion != "Baja")
                    {
                        cmd.Parameters.AddWithValue("@Nombre", objPersona.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", objPersona.Apellido);
                        cmd.Parameters.AddWithValue("@DNI", objPersona.DNI);
                        cmd.Parameters.AddWithValue("@Telefono", objPersona.Telefono);
                        cmd.Parameters.AddWithValue("@Direccion", objPersona.Direccion);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", objPersona.FechaNacimiento);
                        cmd.Parameters.AddWithValue("@Rol", objPersona.Rol);
                        cmd.Parameters.AddWithValue("@Clave", objPersona.Clave);
                    }

                    // Siempre se necesita el Id
                    cmd.Parameters.AddWithValue("@IdPersona", objPersona.IdPersona);

                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al intentar realizar la operación con Personas", e);
                }
                finally
                {
                    CerrarConexion(conexion);
                    cmd.Dispose();
                }
            }

            return resultado;
        }
        public DataSet ListadoPersona(string idPersona)
        {
            string orden;
            SqlCommand cmd;
            DataSet ds = new DataSet();

            using (SqlConnection conexion = ObtenerConexion())
            {
                if (!string.Equals(idPersona, "Todos", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(idPersona, out int id))
                        throw new ArgumentException("IdPersona inválido.");

                    orden = "SELECT * FROM Persona WHERE IdPersona = @IdPersona;";
                    cmd = new SqlCommand(orden, conexion);
                    cmd.Parameters.AddWithValue("@IdPersona", id);
                }
                else
                {
                    orden = "SELECT * FROM Persona;";
                    cmd = new SqlCommand(orden, conexion);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                try
                {
                    AbrirConexion(conexion);
                    da.Fill(ds);
                }
                catch (Exception e)
                {
                    throw new Exception("Error al listar Personas", e);
                }
                finally
                {
                    CerrarConexion(conexion);
                    cmd.Dispose();
                }
            }

            return ds;
        }
    }
}
