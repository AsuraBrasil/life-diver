using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CVENDA
    {
        public static void Incluir(VENDA oVENDA)
        {
            VENDA.Incluir(oVENDA);
        }

        public static int IncluirRetorna(VENDA oVENDA)
        {
            return VENDA.IncluirRetorna(oVENDA);
        }

        public static void Alterar(VENDA oVENDA)
        {
            VENDA.Alterar(oVENDA);
        }

        public static void Excluir(VENDA oVENDA)
        {
            VENDA.Excluir(oVENDA);
        }

        public static VENDA SelecionaPK(int Codigo)
        {
            return VENDA.SelecionaPK(Codigo);
        }

        public static List<VENDA> SelecionaTodos()
        {
            return VENDA.SelecionaTodos();
        }

    }
}
