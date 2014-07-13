using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CSUPLEMENTO_CONSULTA
    {
        public static List<SUPLEMENTO> SelecionaTodosCodigo(string sCodigo)
        {
            return SUPLEMENTO.SelecionaTodosCodigo(sCodigo);
        }

        public static List<SUPLEMENTO> SelecionaTodosNome(string Nome)
        {
            return SUPLEMENTO.SelecionaTodosNome(Nome);
        }
    }
}
