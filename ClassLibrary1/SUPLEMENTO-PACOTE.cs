using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class SUPLEMENTO_PACOTE
    {
        public static void Incluir(SUPLEMENTO_PACOTE oSUPLEMENTO_PACOTE)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.SUPLEMENTO_PACOTEs.InsertOnSubmit(oSUPLEMENTO_PACOTE);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(SUPLEMENTO_PACOTE oSUPLEMENTO_PACOTE)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.SUPLEMENTO_PACOTEs.Attach(oSUPLEMENTO_PACOTE, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(SUPLEMENTO_PACOTE oSUPLEMENTO_PACOTE)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            //oSUPLEMENTO_PACOTE = oDb.SUPLEMENTO_PACOTEs.Single(SUPLEMENTO_PACOTE => SUPLEMENTO_PACOTE.CodPacote == oSUPLEMENTO_PACOTE.CodPacote && SUPLEMENTO_PACOTE.CodSuplemento == oSUPLEMENTO_PACOTE.CodSuplemento);
            SUPLEMENTO_PACOTE oSupp = new SUPLEMENTO_PACOTE();
            var Res = from p in oDb.SUPLEMENTO_PACOTEs where p.CodSuplemento == oSUPLEMENTO_PACOTE.CodSuplemento && p.CodPacote == oSUPLEMENTO_PACOTE.CodPacote select p;
            oSupp = Res.First();
            //oDb.SUPLEMENTO_PACOTEs.Attach(oSupp);
            oDb.SUPLEMENTO_PACOTEs.DeleteOnSubmit(oSupp);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static SUPLEMENTO_PACOTE SelecionaPK(int CodigoS, int CodigoP)
        {
            SUPLEMENTO_PACOTE oSUPLEMENTO_PACOTE = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.SUPLEMENTO_PACOTEs where p.CodSuplemento == CodigoS && p.CodPacote == CodigoP select p;
            if (Result.Count() > 0)
            {
                oSUPLEMENTO_PACOTE = Result.First();
            }

            oDb.Dispose();
            return oSUPLEMENTO_PACOTE;
        }
        //
        public static VW_SUPLEMENTO_PACOTE SelecionaVW_PK(int CodigoS, int CodigoP)
        {
            VW_SUPLEMENTO_PACOTE oSUPLEMENTO_PACOTE = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_SUPLEMENTO_PACOTEs where p.CodSuplemento == CodigoS && p.CodPacote == CodigoP select p;
            if (Result.Count() > 0)
            {
                oSUPLEMENTO_PACOTE = Result.First();
            }

            oDb.Dispose();
            return oSUPLEMENTO_PACOTE;
        }

        public static List<VW_SUPLEMENTO_PACOTE> SelecionaTodos()
        {
            List<VW_SUPLEMENTO_PACOTE> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_SUPLEMENTO_PACOTEs orderby p.Nome select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<VW_SUPLEMENTO_PACOTE> SelecionaTodosCodigoPacote(int CodigoP)
        {
            List<VW_SUPLEMENTO_PACOTE> oLista = new List<VW_SUPLEMENTO_PACOTE>();
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_SUPLEMENTO_PACOTEs where p.CodPacote == CodigoP select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }
    }
}
