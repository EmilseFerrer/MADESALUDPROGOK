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
    public class DatosTurno:DatosConexionBD
    {
        public int AbmTurnos(string accion, Turno objTurno)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO Turnos (IdTurno, Fecha, Hora, IdPaciente, IdMedico, Estado) " +
                        "VALUES (@IdTurno, @Fecha, @Hora, @IdPaciente, @IdMedico, @Estado)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE Turnos SET Fecha=@Fecha, Hora=@Hora, IdPaciente=@IdPaciente, IdMedico=@IdMedico, Estado=@Estado " +
                        "WHERE IdTurno=@IdTurno";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM Turnos WHERE IdTurno=@IdTurno";
            }

            using (SqlConnection conexion = ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(orden, conexion);
                try
                {
                    AbrirConexion(conexion);

                    // En Alta y Modificar se asignan todos los campos
                    if (accion != "Baja")
                    {
                        cmd.Parameters.AddWithValue("@Fecha", objTurno.Fecha);
                        cmd.Parameters.AddWithValue("@Hora", objTurno.Hora);
                        cmd.Parameters.AddWithValue("@IdPaciente", objTurno.IdPaciente);
                        cmd.Parameters.AddWithValue("@IdMedico", objTurno.IdMedico);
                        cmd.Parameters.AddWithValue("@Estado", objTurno.Estado);
                    }

                    // Siempre se necesita el ID
                    cmd.Parameters.AddWithValue("@IdTurno", objTurno.IdTurno);

                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al intentar realizar la operación con Turnos", e);
                }
                finally
                {
                    CerrarConexion(conexion);
                    cmd.Dispose();
                }
            }

            return resultado;
        }

        public DataSet ListadoTurno(string idTurno)
        {
            string orden;
            SqlCommand cmd;
            DataSet ds = new DataSet();

            using (SqlConnection conexion = ObtenerConexion())
            {
                if (!string.Equals(idTurno, "Todos", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(idTurno, out int id))
                        throw new ArgumentException("IdTurno inválido.");

                    orden = "SELECT * FROM Turno WHERE IdTurno = @IdTurno;";
                    cmd = new SqlCommand(orden, conexion);
                    cmd.Parameters.AddWithValue("@IdTurno", id);
                }
                else
                {
                    orden = "SELECT * FROM Turno;";
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
                    throw new Exception("Error al listar Turno", e);
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
