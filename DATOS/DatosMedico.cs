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
    public class DatosMedico:DatosConexionBD
    {
        public int AbmMedicos(string accion, Medico objMedico)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO Medicos (IdMedico, Especialidad, MatriculaProfesional) " +
                        "VALUES (@IdMedico, @Especialidad, @MatriculaProfesional)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Medicos SET Especialidad = @Especialidad, MatriculaProfesional = @MatriculaProfesional " +
                        "WHERE IdMedico = @IdMedico";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Medicos WHERE IdMedico = @IdMedico";
            }

            using (SqlConnection conexion = ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion(conexion);

                    if (accion != "Baja")
                    {
                        cmd.Parameters.AddWithValue("@Especialidad", objMedico.Especialidad);
                        cmd.Parameters.AddWithValue("@MatriculaProfesional", objMedico.MatriculaProfesional);
                    }

                    cmd.Parameters.AddWithValue("@IdMedico", objMedico.IdMedico);

                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al operar con la tabla Medicos", e);
                }
                finally
                {
                    CerrarConexion(conexion);
                    cmd.Dispose();
                }
            }

            return resultado;
        }
        public DataSet ListadoMedico(string idMedico)
        {
            string orden;
            SqlCommand cmd;
            DataSet ds = new DataSet();

            using (SqlConnection conexion = ObtenerConexion())
            {
                if (!string.Equals(idMedico, "Todos", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(idMedico, out int id))
                        throw new ArgumentException("IdMedico inválido.");

                    orden = "SELECT * FROM Medico WHERE IdMedico = @IdMedico;";
                    cmd = new SqlCommand(orden, conexion);
                    cmd.Parameters.AddWithValue("@IdMedico", id);
                }
                else
                {
                    orden = "SELECT * FROM Medico;";
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
                    throw new Exception("Error al listar Medicos", e);
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
