using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CCLIENTE_CONSULTA
    {
        public static List<CLIENTE> SelecionaTodosCPF(string CPF)
        {
            return CLIENTE.SelecionaTodosCPF(CPF);
        }

        public static List<CLIENTE> SelecionaTodosNome(string Nome)
        {
            return CLIENTE.SelecionaTodosNome(Nome);
        }

    }
}
