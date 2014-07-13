using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class PACOTE
    {
        public static void Incluir(PACOTE oPACOTE)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.PACOTEs.InsertOnSubmit(oPACOTE);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static int IncluirRetorna(PACOTE oPACOTE)
        {
            int retorno = 1;
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.PACOTEs.InsertOnSubmit(oPACOTE);
            oDb.SubmitChanges();
            retorno = oPACOTE.CodPacote;
            oDb.Dispose();
            return retorno;
        }

        public static void Alterar(PACOTE oPACOTE)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.PACOTEs.Attach(oPACOTE, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(PACOTE oPACOTE)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oPACOTE = oDb.PACOTEs.Single(PACOTE => PACOTE.CodPacote == oPACOTE.CodPacote);
            oDb.PACOTEs.DeleteOnSubmit(oPACOTE);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static PACOTE SelecionaPK(int Codigo)
        {
            PACOTE oPACOTE = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.PACOTEs where p.CodPacote == Codigo select p;
            if (Result.Count() > 0)
            {
                oPACOTE = Result.First();
            }

            oDb.Dispose();
            return oPACOTE;
        }

        public static List<PACOTE> SelecionaTodos()
        {
            List<PACOTE> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.PACOTEs orderby p.Nome select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<PACOTE> SelecionaTodosNome(string Nome)
        {
            List<PACOTE> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.PACOTEs where p.Nome.StartsWith(Nome) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<PACOTE> SelecionaTodosCodigo(string sCodigo)
        {
            List<PACOTE> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.PACOTEs where p.CodPacote.ToString().StartsWith(sCodigo) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }
    }

    
}
