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
    public class NegPersona
    {
        readonly DatosPersona datosPersona = new DatosPersona();

        public int AbmPersonas(string accion, Persona objpersona)
        {
            return datosPersona.AbmPersonas(accion, objpersona);
        }
        public DataSet ListadoPersonas(string cual)
        {
            return datosPersona.ListadoPersona(cual);
        }
        
    }

}

