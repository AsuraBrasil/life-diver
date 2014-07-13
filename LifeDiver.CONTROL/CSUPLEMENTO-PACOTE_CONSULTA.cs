using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CSUPLEMENTO_PACOTE_CONSULTA
    {
        public static List<VW_SUPLEMENTO_PACOTE> SelecionaTodosCodigoPacote(int CodigoP)
        {
            return SUPLEMENTO_PACOTE.SelecionaTodosCodigoPacote(CodigoP);
        }
    }
}
