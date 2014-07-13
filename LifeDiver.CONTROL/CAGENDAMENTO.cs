using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CAGENDAMENTO
    {
        public static void Incluir(AGENDAMENTO oAGENDAMENTO)
        {
            AGENDAMENTO.Incluir(oAGENDAMENTO);
        }

        public static void Alterar(AGENDAMENTO oAGENDAMENTO)
        {
            AGENDAMENTO.Alterar(oAGENDAMENTO);
        }

        public static void Excluir(AGENDAMENTO oAGENDAMENTO)
        {
            AGENDAMENTO.Excluir(oAGENDAMENTO);
        }

        public static AGENDAMENTO SelecionaPK(int Codigo)
        {
            return AGENDAMENTO.SelecionaPK(Codigo);
        }

        public static List<VW_AGENDAMENTO> SelecionaTodos()
        {
            return AGENDAMENTO.SelecionaTodos();
        }
    }
}
