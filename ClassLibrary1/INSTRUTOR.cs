using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class INSTRUTOR
    {
        public static void Incluir(INSTRUTOR oINSTRUTOR)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.INSTRUTORs.InsertOnSubmit(oINSTRUTOR);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(INSTRUTOR oINSTRUTOR)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.INSTRUTORs.Attach(oINSTRUTOR, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(INSTRUTOR oINSTRUTOR)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oINSTRUTOR = oDb.INSTRUTORs.Single(INSTRUTOR => INSTRUTOR.CPF == oINSTRUTOR.CPF);
            oDb.INSTRUTORs.DeleteOnSubmit(oINSTRUTOR);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static INSTRUTOR SelecionaPK(string CPF)
        {
            INSTRUTOR oINSTRUTOR = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.INSTRUTORs where p.CPF == CPF select p;
            if (Result.Count() > 0)
            {
                oINSTRUTOR = Result.First();
            }

            oDb.Dispose();
            return oINSTRUTOR;
        }

        public static List<INSTRUTOR> SelecionaTodos()
        {
            List<INSTRUTOR> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.INSTRUTORs orderby p.Nome select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<INSTRUTOR> SelecionaTodosNome(string Nome)
        {
            List<INSTRUTOR> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.INSTRUTORs where p.Nome.StartsWith(Nome) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<INSTRUTOR> SelecionaTodosCPF(string CPF)
        {
            List<INSTRUTOR> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.INSTRUTORs where p.CPF.StartsWith(CPF) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

    }
}
