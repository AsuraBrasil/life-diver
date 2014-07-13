using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class CLIENTE
    {
        public static void Incluir(CLIENTE oCLIENTE) 
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.CLIENTEs.InsertOnSubmit(oCLIENTE);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(CLIENTE oCLIENTE)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.CLIENTEs.Attach(oCLIENTE, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(CLIENTE oCLIENTE)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oCLIENTE = oDb.CLIENTEs.Single(CLIENTE => CLIENTE.CPF == oCLIENTE.CPF); //GAMBIARRA
            oDb.CLIENTEs.DeleteOnSubmit(oCLIENTE);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static CLIENTE SelecionaPK(string CPF)
        {
            CLIENTE oCLIENTE = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.CLIENTEs where p.CPF == CPF select p;
            if (Result.Count() > 0)
            {
                oCLIENTE = Result.First();
            }

            oDb.Dispose();
            return oCLIENTE;
        }

        public static List<CLIENTE> SelecionaTodos()
        {
            List<CLIENTE> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.CLIENTEs orderby p.Nome select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<CLIENTE> SelecionaTodosNome(string Nome)
        {
            List<CLIENTE> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.CLIENTEs where p.Nome.StartsWith(Nome) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<CLIENTE> SelecionaTodosCPF(string CPF)
        {
            List<CLIENTE> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.CLIENTEs where p.CPF.StartsWith(CPF) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

    }
}
