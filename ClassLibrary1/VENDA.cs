using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class VENDA
    {
        public static void Incluir(VENDA oVENDA)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.VENDAs.InsertOnSubmit(oVENDA);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static int IncluirRetorna(VENDA oVENDA)
        {
            int retorno = 1;
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.VENDAs.InsertOnSubmit(oVENDA);
            oDb.SubmitChanges();
            retorno = oVENDA.CodVenda;
            oDb.Dispose();
            return retorno;
        }

        public static void Alterar(VENDA oVENDA)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.VENDAs.Attach(oVENDA, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(VENDA oVENDA)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oVENDA = oDb.VENDAs.Single(VENDA => VENDA.CodVenda == oVENDA.CodVenda);
            oDb.VENDAs.DeleteOnSubmit(oVENDA);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static VENDA SelecionaPK(int Codigo)
        {
            VENDA oVENDA = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VENDAs where p.CodVenda == Codigo select p;
            if (Result.Count() > 0)
            {
                oVENDA = Result.First();
            }

            oDb.Dispose();
            return oVENDA;
        }

        public static List<VENDA> SelecionaTodos()
        {
            List<VENDA> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VENDAs orderby p.CodVenda select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }
    }
}
