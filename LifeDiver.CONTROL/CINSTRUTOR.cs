using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.CONTROL
{
    public class CINSTRUTOR
    {
        public static void Incluir(INSTRUTOR oINSTRUTOR)
        {
            INSTRUTOR.Incluir(oINSTRUTOR);
        }

        public static void Alterar(INSTRUTOR oINSTRUTOR)
        {
            INSTRUTOR.Alterar(oINSTRUTOR);
        }

        public static void Excluir(INSTRUTOR oINSTRUTOR)
        {
            INSTRUTOR.Excluir(oINSTRUTOR);
        }

        public static INSTRUTOR SelecionaPK(string CPF)
        {
            return INSTRUTOR.SelecionaPK(CPF);
        }

        public static List<INSTRUTOR> SelecionaTodos()
        {
            return INSTRUTOR.SelecionaTodos();
        }

    }
}
