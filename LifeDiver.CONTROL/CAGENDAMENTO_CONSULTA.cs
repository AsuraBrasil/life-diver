using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CAGENDAMENTO_CONSULTA
    {
        public static List<VW_AGENDAMENTO> SelecionaTodosData(DateTime dataAgenda)
        {
            return AGENDAMENTO.SelecionaTodosData(dataAgenda);
        }

    }
}
