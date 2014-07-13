using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CEQUIPAMENTO_VENDA_CONSULTA
    {
        public static List<VW_EQUIPVENDA> SelecionaTodosCodigoVenda(int CodigoV)
        {
            return EQUIPAMENTO_VENDA.SelecionaTodosCodigoVenda(CodigoV);
        }
    }
}
