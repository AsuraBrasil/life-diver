using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.MODEL
{
    public partial class SUPLEMENTO
    {
        public static void Incluir(SUPLEMENTO oSUPLEMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.SUPLEMENTOs.InsertOnSubmit(oSUPLEMENTO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(SUPLEMENTO oSUPLEMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.SUPLEMENTOs.Attach(oSUPLEMENTO, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(SUPLEMENTO oSUPLEMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oSUPLEMENTO = oDb.SUPLEMENTOs.Single(SUPLEMENTO => SUPLEMENTO.CodSuplemento == oSUPLEMENTO.CodSuplemento);
            oDb.SUPLEMENTOs.DeleteOnSubmit(oSUPLEMENTO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static SUPLEMENTO SelecionaPK(int Codigo)
        {
            SUPLEMENTO oSUPLEMENTO = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.SUPLEMENTOs where p.CodSuplemento == Codigo select p;
            if (Result.Count() > 0)
            {
                oSUPLEMENTO = Result.First();
            }

            oDb.Dispose();
            return oSUPLEMENTO;
        }

        public static List<SUPLEMENTO> SelecionaTodos()
        {
            List<SUPLEMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.SUPLEMENTOs orderby p.Nome select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<SUPLEMENTO> SelecionaTodosNome(string Nome)
        {
            List<SUPLEMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.SUPLEMENTOs where p.Nome.StartsWith(Nome) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<SUPLEMENTO> SelecionaTodosCodigo(string sCodigo)
        {
            List<SUPLEMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.SUPLEMENTOs where p.CodSuplemento.ToString().StartsWith(sCodigo) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

    }
}
