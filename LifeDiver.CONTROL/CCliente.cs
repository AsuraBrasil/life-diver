using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CCLIENTE
    {
        public static void Incluir(CLIENTE oCLIENTE)
        {
            CLIENTE.Incluir(oCLIENTE);
        }

        public static void Alterar(CLIENTE oCLIENTE)
        {
            CLIENTE.Alterar(oCLIENTE);
        }

        public static void Excluir(CLIENTE oCLIENTE)
        {
            CLIENTE.Excluir(oCLIENTE);
        }

        public static CLIENTE SelecionaPK(string CPF)
        {
            return CLIENTE.SelecionaPK(CPF);
        }

        public static List<CLIENTE> SelecionaTodos()
        {
            return CLIENTE.SelecionaTodos();
        }

    }
}
