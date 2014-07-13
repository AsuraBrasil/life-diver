using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CCURSO
    {
        public static void Incluir(CURSO oCURSO)
        {
            CURSO.Incluir(oCURSO);
        }

        public static void Alterar(CURSO oCURSO)
        {
            CURSO.Alterar(oCURSO);
        }

        public static void Excluir(CURSO oCURSO)
        {
            CURSO.Excluir(oCURSO);
        }

        public static CURSO SelecionaPK(int Codigo)
        {
            return CURSO.SelecionaPK(Codigo);
        }

        public static List<VW_CURSO> SelecionaTodos()
        {
            return CURSO.SelecionaTodos();
        }
    }
}
