using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CCLIENTE_CURSO
    {
        public static void Incluir(CLIENTE_CURSO oCLIENTE_CURSO)
        {
            CLIENTE_CURSO.Incluir(oCLIENTE_CURSO);
        }

        public static void Alterar(CLIENTE_CURSO oCLIENTE_CURSO)
        {
            CLIENTE_CURSO.Alterar(oCLIENTE_CURSO);
        }

        public static void Excluir(CLIENTE_CURSO oCLIENTE_CURSO)
        {
            CLIENTE_CURSO.Excluir(oCLIENTE_CURSO);
        }

        public static CLIENTE_CURSO SelecionaPK(int Codigo, string CPFCliente)
        {
            return CLIENTE_CURSO.SelecionaPK(Codigo, CPFCliente);
        }

        public static List<VW_CLIENTE_CURSO> SelecionaTodos()
        {
            return CLIENTE_CURSO.SelecionaTodos();
        }
    }
}
