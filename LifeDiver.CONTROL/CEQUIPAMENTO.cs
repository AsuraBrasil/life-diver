using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CEQUIPAMENTO
    {
        public static void Incluir(EQUIPAMENTO oEQUIPAMENTO)
        {
            EQUIPAMENTO.Incluir(oEQUIPAMENTO);
        }

        public static void Alterar(EQUIPAMENTO oEQUIPAMENTO)
        {
            EQUIPAMENTO.Alterar(oEQUIPAMENTO);
        }

        public static void Excluir(EQUIPAMENTO oEQUIPAMENTO)
        {
            EQUIPAMENTO.Excluir(oEQUIPAMENTO);
        }

        public static EQUIPAMENTO SelecionaPK(int Codigo)
        {
            return EQUIPAMENTO.SelecionaPK(Codigo);
        }

        public static List<EQUIPAMENTO> SelecionaTodos()
        {
            return EQUIPAMENTO.SelecionaTodos();
        }
    }
}
