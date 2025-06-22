using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class HistoriaClinica
    {
        // Campos privados
        private int idHC;
        private int idPaciente;
        private DateTime fechaCreacion;
        private int idSecretaria;

        // Propiedades públicas
        public int IdHC
        {
            get { return idHC; }
            set { idHC = value; }
        }

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        public int IdSecretaria
        {
            get { return idSecretaria; }
            set { idSecretaria = value; }
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

        // Constructor vacío
        public HistoriaClinica() { }

        // Constructor con parámetros (opcional)
        public HistoriaClinica(int idHC, int idPaciente, DateTime fechaCreacion, int idSecretaria)
        {
            this.idHC = idHC;
            this.idPaciente = idPaciente;
            this.fechaCreacion = fechaCreacion;
            this.idSecretaria = idSecretaria;
        }
    }
}
