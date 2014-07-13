using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeDiver.MODEL;

namespace LifeDiver.MODEL
{
    public partial class EQUIPAMENTO
    {

        public static void Incluir(EQUIPAMENTO oEQUIPAMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.EQUIPAMENTOs.InsertOnSubmit(oEQUIPAMENTO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(EQUIPAMENTO oEQUIPAMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.EQUIPAMENTOs.Attach(oEQUIPAMENTO, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(EQUIPAMENTO oEQUIPAMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oEQUIPAMENTO = oDb.EQUIPAMENTOs.Single(EQUIPAMENTO => EQUIPAMENTO.CodEquipamento == oEQUIPAMENTO.CodEquipamento);
            oDb.EQUIPAMENTOs.DeleteOnSubmit(oEQUIPAMENTO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static EQUIPAMENTO SelecionaPK(int Codigo)
        {
            EQUIPAMENTO oEQUIPAMENTO = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.EQUIPAMENTOs where p.CodEquipamento == Codigo select p;
            if (Result.Count() > 0)
            {
                oEQUIPAMENTO = Result.First();
            }

            oDb.Dispose();
            return oEQUIPAMENTO;
        }

        public static List<EQUIPAMENTO> SelecionaTodos()
        {
            List<EQUIPAMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.EQUIPAMENTOs orderby p.Nome select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<EQUIPAMENTO> SelecionaTodosNome(string Nome)
        {
            List<EQUIPAMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.EQUIPAMENTOs where p.Nome.StartsWith(Nome) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<EQUIPAMENTO> SelecionaTodosCodigo(string sCodigo)
        {
            List<EQUIPAMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.EQUIPAMENTOs where p.CodEquipamento.ToString().StartsWith(sCodigo) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

    }
}
