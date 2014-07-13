using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CEQUIPAMENTO_CONSULTA
    {
        public static List<EQUIPAMENTO> SelecionaTodosCodigo(string sCodigo)
        {
            return EQUIPAMENTO.SelecionaTodosCodigo(sCodigo);
        }

        public static List<EQUIPAMENTO> SelecionaTodosNome(string Nome)
        {
            return EQUIPAMENTO.SelecionaTodosNome(Nome);
        }
    }
}
