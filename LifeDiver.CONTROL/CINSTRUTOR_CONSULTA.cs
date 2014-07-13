using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CINSTRUTOR_CONSULTA
    {

        public static List<INSTRUTOR> SelecionaTodosCPF(string CPF)
        {
            return INSTRUTOR.SelecionaTodosCPF(CPF);
        }

        public static List<INSTRUTOR> SelecionaTodosNome(string Nome)
        {
            return INSTRUTOR.SelecionaTodosNome(Nome);
        }

    }
}
