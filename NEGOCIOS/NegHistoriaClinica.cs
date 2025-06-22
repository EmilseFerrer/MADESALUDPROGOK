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
   public class NegHistoriaClinica
   {
        readonly DatosHistoriaClinica datosHistoriaClinica= new DatosHistoriaClinica();

        public int AbmHistoriaClinica(string accion, HistoriaClinica objHistoria)
        {
            return datosHistoriaClinica.AbmHistoriaClinica(accion, objHistoria);
        }
        public DataSet ListadoHistoriaClinica(string cual)
        {
            return datosHistoriaClinica.ListadoHistoriaClinica(cual);
        }
   }
}
