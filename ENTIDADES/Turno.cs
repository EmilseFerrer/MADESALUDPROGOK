using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Turno
    {
        // Campos privados
        private int idTurno;
        private DateTime fecha;
        private TimeSpan hora;
        private int idPaciente;
        private int idMedico;
        private string estado;

        // Propiedades públicas
        public int IdTurno
        {
            get { return idTurno; }
            set { idTurno = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public TimeSpan Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public int IdPaciente
        {
            get { return idPaciente; }
            set { idPaciente = value; }
        }

        public int IdMedico
        {
            get { return idMedico; }
            set { idMedico = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        // Constructor vacío
        public Turno() { }

        // Constructor con parámetros (opcional)
        public Turno(int idTurno, DateTime fecha, TimeSpan hora, int idPaciente, int idMedico, string estado)
        {
            this.idTurno = idTurno;
            this.fecha = fecha;
            this.hora = hora;
            this.idPaciente = idPaciente;
            this.idMedico = idMedico;
            this.estado = estado;
        }
    }
}
