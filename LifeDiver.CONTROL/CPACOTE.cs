using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CPACOTE
    {
        public static void Incluir(PACOTE oPACOTE)
        {
            PACOTE.Incluir(oPACOTE);
        }

        public static int IncluirRetorna(PACOTE oPACOTE)
        {
            return PACOTE.IncluirRetorna(oPACOTE);
        }

        public static void Alterar(PACOTE oPACOTE)
        {
            PACOTE.Alterar(oPACOTE);
        }

        public static void Excluir(PACOTE oPACOTE)
        {
            PACOTE.Excluir(oPACOTE);
        }

        public static PACOTE SelecionaPK(int Codigo)
        {
            return PACOTE.SelecionaPK(Codigo);
        }

        public static List<PACOTE> SelecionaTodos()
        {
            return PACOTE.SelecionaTodos();
        }
    }
}
