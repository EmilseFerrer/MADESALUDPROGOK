using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DATOS
{
    public class DatosConexionBD
    {
        public static string Cadena = @"Data Source=DESKTOP-NM47MN7\SQLEXPRESS;Initial Catalog=MADESALUD;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public static SqlConnection ObtenerConexion() => new SqlConnection(Cadena);

        public static void AbrirConexion(SqlConnection conexion)
        {
            if (conexion.State != ConnectionState.Open)
                conexion.Open();
        }

        public static void CerrarConexion(SqlConnection conexion)
        {
            if (conexion.State != ConnectionState.Closed)
                conexion.Close();
        }

        public static DataTable ObtenerPacientes()
        {
            DataTable tabla = new DataTable();
            SqlConnection conexion = ObtenerConexion();

            try
            {
                AbrirConexion(conexion);

                string consulta = "SELECT * FROM Pacientes";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener pacientes: " + ex.Message);
            }
            finally
            {
                CerrarConexion(conexion);
            }

            return tabla;

        }
    }
}

