using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class CURSO
    {
        public static void Incluir(CURSO oCURSO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.CURSOs.InsertOnSubmit(oCURSO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(CURSO oCURSO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.CURSOs.Attach(oCURSO, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(CURSO oCURSO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oCURSO = oDb.CURSOs.Single(CURSO => CURSO.CodCurso == oCURSO.CodCurso);
            oDb.CURSOs.DeleteOnSubmit(oCURSO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static CURSO SelecionaPK(int Codigo)
        {
            CURSO oCURSO = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.CURSOs where p.CodCurso == Codigo select p;
            if (Result.Count() > 0)
            {
                oCURSO = Result.First();
            }

            oDb.Dispose();
            return oCURSO;
        }

        public static List<VW_CURSO> SelecionaTodos()
        {
            List<VW_CURSO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_CURSOs orderby p.Nome select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<VW_CURSO> SelecionaTodosNome(string Nome)
        {
            List<VW_CURSO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_CURSOs where p.Nome.StartsWith(Nome) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<VW_CURSO> SelecionaTodosCodigo(string sCodigo)
        {
            List<VW_CURSO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_CURSOs where p.CodCurso.ToString().StartsWith(sCodigo) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }
    }
}
