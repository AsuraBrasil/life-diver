using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CEQUIPAMENTO_VENDA
    {
        public static void Incluir(EQUIPAMENTO_VENDA oEQUIPAMENTO_VENDA)
        {
            EQUIPAMENTO_VENDA.Incluir(oEQUIPAMENTO_VENDA);
        }

        public static void Alterar(EQUIPAMENTO_VENDA oEQUIPAMENTO_VENDA)
        {
            EQUIPAMENTO_VENDA.Alterar(oEQUIPAMENTO_VENDA);
        }

        public static void Excluir(EQUIPAMENTO_VENDA oEQUIPAMENTO_VENDA)
        {
            EQUIPAMENTO_VENDA.Excluir(oEQUIPAMENTO_VENDA);
        }

        public static EQUIPAMENTO_VENDA SelecionaPK(int CodigoV, int CodigoE)
        {
            return EQUIPAMENTO_VENDA.SelecionaPK(CodigoV, CodigoE);
        }

        public static VW_EQUIPVENDA SelecionaVW_PK(int CodigoV, int CodigoE)
        {
            return EQUIPAMENTO_VENDA.SelecionaVW_PK(CodigoV, CodigoE);
        }

        public static List<VW_EQUIPVENDA> SelecionaTodos()
        {
            return EQUIPAMENTO_VENDA.SelecionaTodos();
        }
    }
}
