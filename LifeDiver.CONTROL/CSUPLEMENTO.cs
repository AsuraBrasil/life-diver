using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CSUPLEMENTO
    {
        public static void Incluir(SUPLEMENTO oSUPLEMENTO)
        {
            SUPLEMENTO.Incluir(oSUPLEMENTO);
        }

        public static void Alterar(SUPLEMENTO oSUPLEMENTO)
        {
            SUPLEMENTO.Alterar(oSUPLEMENTO);
        }

        public static void Excluir(SUPLEMENTO oSUPLEMENTO)
        {
            SUPLEMENTO.Excluir(oSUPLEMENTO);
        }

        public static SUPLEMENTO SelecionaPK(int Codigo)
        {
            return SUPLEMENTO.SelecionaPK(Codigo);
        }

        public static List<SUPLEMENTO> SelecionaTodos()
        {
            return SUPLEMENTO.SelecionaTodos();
        }
    }
}
