using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CPACOTE_CONSULTA
    {
        public static List<PACOTE> SelecionaTodosCodigo(string sCodigo)
        {
            return PACOTE.SelecionaTodosCodigo(sCodigo);
        }

        public static List<PACOTE> SelecionaTodosNome(string Nome)
        {
            return PACOTE.SelecionaTodosNome(Nome);
        }

    }
}
