using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using System.Data;
using DATOS;

namespace NEGOCIOS
{
    public class NegPaciente
    {
        readonly DatosPaciente datosPaciente = new DatosPaciente();

        public int AbmPacientes(string accion, Paciente objPaciente)
        {
            return datosPaciente.AbmPacientes(accion, objPaciente);
        }
        public DataSet ListadoPaciente(string cual)
        {
            return datosPaciente.ListadoPaciente(cual);
        }

    }
}
