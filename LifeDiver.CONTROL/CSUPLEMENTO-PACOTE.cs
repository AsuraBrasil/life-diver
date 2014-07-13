using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CSUPLEMENTO_PACOTE
    {
        public static void Incluir(SUPLEMENTO_PACOTE oSUPLEMENTO_PACOTE)
        {
            SUPLEMENTO_PACOTE.Incluir(oSUPLEMENTO_PACOTE);
        }

        public static void Alterar(SUPLEMENTO_PACOTE oSUPLEMENTO_PACOTE)
        {
            SUPLEMENTO_PACOTE.Alterar(oSUPLEMENTO_PACOTE);
        }

        public static void Excluir(SUPLEMENTO_PACOTE oSUPLEMENTO_PACOTE)
        {
            SUPLEMENTO_PACOTE.Excluir(oSUPLEMENTO_PACOTE);
        }

        public static SUPLEMENTO_PACOTE SelecionaPK(int CodigoS, int CodigoP)
        {
            return SUPLEMENTO_PACOTE.SelecionaPK(CodigoS, CodigoP);
        }

        public static VW_SUPLEMENTO_PACOTE SelecionaVW_PK(int CodigoS, int CodigoP)
        {
            return SUPLEMENTO_PACOTE.SelecionaVW_PK(CodigoS, CodigoP);
        }

        public static List<VW_SUPLEMENTO_PACOTE> SelecionaTodos()
        {
            return SUPLEMENTO_PACOTE.SelecionaTodos();
        }
    }
}
