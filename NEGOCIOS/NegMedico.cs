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
    public class NegMedico
    {
        DatosMedico datosMedico= new DatosMedico();

        public int AbmMedicos(string accion, Medico objMedico)
        {
            return datosMedico.AbmMedicos(accion , objMedico);
        }
        public DataSet ListadoMedico(string cual)
        {
            return datosMedico.ListadoMedico(cual);
        }
    }
}
