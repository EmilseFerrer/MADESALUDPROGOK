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
    public class DatosHistoriaClinica:DatosConexionBD
    {
        public int AbmHistoriaClinica(string accion, HistoriaClinica objHistoria)
        {
            int resultado = -1;
            string orden = string.Empty;

            if (accion == "Alta")
            {
                orden = "INSERT INTO HistoriaClinica (IdHC, IdPaciente, FechaCreacion, IdSecretaria) " +
                        "VALUES (@IdHC, @IdPaciente, @FechaCreacion, @IdSecretaria)";
            }
            else if (accion == "Modificar")
            {
                orden = "UPDATE HistoriaClinica SET IdPaciente=@IdPaciente, FechaCreacion=@FechaCreacion, IdSecretaria=@IdSecretaria " +
                        "WHERE IdHC=@IdHC";
            }
            else if (accion == "Baja")
            {
                orden = "DELETE FROM HistoriaClinica WHERE IdHC=@IdHC";
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
                        cmd.Parameters.AddWithValue("@IdPaciente", objHistoria.IdPaciente);
                        cmd.Parameters.AddWithValue("@FechaCreacion", objHistoria.FechaCreacion);
                        cmd.Parameters.AddWithValue("@IdSecretaria", objHistoria.IdSecretaria);
                    }

                    // Siempre se necesita el IdHC
                    cmd.Parameters.AddWithValue("@IdHC", objHistoria.IdHC);

                    resultado = cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Error al intentar realizar la operación con HistoriaClinica", e);
                }
                finally
                {
                    CerrarConexion(conexion);
                    cmd.Dispose();
                }
            }

            return resultado;
        }
        public DataSet ListadoHistoriaClinica(string idHC)
        {
            string orden;
            SqlCommand cmd;
            DataSet ds = new DataSet();

            using (SqlConnection conexion = ObtenerConexion())
            {
                if (!string.Equals(idHC, "Todos", StringComparison.OrdinalIgnoreCase))
                {
                    if (!int.TryParse(idHC, out int id))
                        throw new ArgumentException("IdHC inválido.");

                    orden = "SELECT * FROM HistoriaClinica WHERE IdHC = @IdHC;";
                    cmd = new SqlCommand(orden, conexion);
                    cmd.Parameters.AddWithValue("@IdHC", id);
                }
                else
                {
                    orden = "SELECT * FROM HistoriaClinica;";
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
                    throw new Exception("Error al listar Historias Clínicas", e);
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
