using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
    public class Medico
    {
        // Atributos privados
        private int idMedico;
        private string especialidad;
        private string matriculaProfesional;

        // Propiedades públicas
        public int IdMedico
        {
            get
            { return idMedico; }
            set { idMedico = value; }
        }

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public string MatriculaProfesional
        {
            get { return matriculaProfesional; }
            set { matriculaProfesional = value; }
        }

        // Constructor vacío (opcional)
        public Medico() { }

        // Constructor con parámetros (opcional)
        public Medico(int idMedico, string especialidad, string matriculaProfesional)
        {
            this.idMedico = idMedico;
            this.especialidad = especialidad;
            this.matriculaProfesional = matriculaProfesional;
        }
    }
}
