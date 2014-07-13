using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CCLIENTE_CURSO_CONSULTA
    {
        public static List<VW_CLIENTE_CURSO> SelecionaTodosCodigoCurso(string sCodigo)
        {
            return CLIENTE_CURSO.SelecionaTodosCodigoCurso(sCodigo);
        }
        public static List<VW_CLIENTE_CURSO> SelecionaTodosNomeCliente(string Nome)
        {
            return CLIENTE_CURSO.SelecionaTodosNomeCliente(Nome);
        }

    }
}
