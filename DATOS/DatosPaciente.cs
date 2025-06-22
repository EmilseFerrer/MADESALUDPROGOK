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
    public class DatosPaciente:DatosConexionBD
    {
        public int AbmPacientes(string accion, Paciente objPaciente)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO Pacientes (IdPaciente, MotivoConsulta) VALUES (@IdPaciente, @MotivoConsulta)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Pacientes SET MotivoConsulta = @MotivoConsulta WHERE IdPaciente = @IdPaciente";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Pacientes WHERE IdPaciente = @IdPaciente";
            }

            using (SqlConnection conexion = ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion(conexion);

                    if (accion != "Baja")
                    {
                        cmd.Parameters.AddWithValue("@MotivoConsulta", objPaciente.MotivoConsulta);
                    }

                    cmd.Parameters.AddWithValue("@IdPaciente", objPaciente.IdPaciente);

                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al operar con la tabla Pacientes", ex);
                }
                finally
                {
                    CerrarConexion(conexion);
                    cmd.Dispose();
                }
            }

            return resultado;
        }
        public DataSet ListadoPaciente(string idPaciente)
        {
            string orden;
            SqlCommand cmd;
            DataSet ds = new DataSet();

            using (SqlConnection conexion = ObtenerConexion())
            {
                if (!string.Equals(idPaciente, "Todos", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(idPaciente, out int id))
                        throw new ArgumentException("IdPaciente inválido.");

                    orden = "SELECT * FROM Paciente WHERE IdPaciente = @IdPaciente;";
                    cmd = new SqlCommand(orden, conexion);
                    cmd.Parameters.AddWithValue("@IdPaciente", id);
                }
                else
                {
                    orden = "SELECT * FROM Paciente;";
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
                    throw new Exception("Error al listar Pacientes", e);
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
