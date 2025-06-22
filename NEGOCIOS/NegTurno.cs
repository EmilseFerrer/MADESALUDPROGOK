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
    public class NegTurno
    {
        DatosTurno objdatosturno = new DatosTurno();

        public int AbmTurnos(string accion, Turno objTurno)
        {
            return objdatosturno.AbmTurnos(accion, objTurno);
        }
        public DataSet ListadoTurno(string cual)
        {
            return objdatosturno.ListadoTurno(cual);
        }
    }
    
}
 