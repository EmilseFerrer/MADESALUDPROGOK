using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Paciente
    {
        // Campo privado
        private int idPaciente;
        private string motivoConsulta;

        // Propiedades públicas (encapsulan los campos)
        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        public string MotivoConsulta
        {
            get { return motivoConsulta; }
            set { motivoConsulta = value; }
        }

        // Constructor vacío (opcional)
        public Paciente() { }

        // Constructor con parámetros (opcional)
        public Paciente(int idPaciente, string motivoConsulta)
        {
            this.idPaciente = idPaciente;
            this.motivoConsulta = motivoConsulta;
        }
    }
}
