using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CCURSO_CONSULTA
    {
        public static List<VW_CURSO> SelecionaTodosCodigo(string sCodigo)
        {
            return CURSO.SelecionaTodosCodigo(sCodigo);
        }

        public static List<VW_CURSO> SelecionaTodosNome(string Nome)
        {
            return CURSO.SelecionaTodosNome(Nome);
        }
    }
}
