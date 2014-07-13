using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class EQUIPAMENTO_VENDA
    {
        public static void Incluir(EQUIPAMENTO_VENDA oEQUIPAMENTO_VENDA)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.EQUIPAMENTO_VENDAs.InsertOnSubmit(oEQUIPAMENTO_VENDA);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(EQUIPAMENTO_VENDA oEQUIPAMENTO_VENDA)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.EQUIPAMENTO_VENDAs.Attach(oEQUIPAMENTO_VENDA, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(EQUIPAMENTO_VENDA oEQUIPAMENTO_VENDA)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            //oEQUIPAMENTO_VENDA = oDb.EQUIPAMENTO_VENDAs.Single(EQUIPAMENTO_VENDA => EQUIPAMENTO_VENDA.CodPacote == oEQUIPAMENTO_VENDA.CodPacote && EQUIPAMENTO_VENDA.CodSuplemento == oEQUIPAMENTO_VENDA.CodSuplemento);
            EQUIPAMENTO_VENDA oSupp = new EQUIPAMENTO_VENDA();
            var Res = from p in oDb.EQUIPAMENTO_VENDAs where p.CodVenda == oEQUIPAMENTO_VENDA.CodVenda && p.CodEquipamento == oEQUIPAMENTO_VENDA.CodEquipamento select p;
            oSupp = Res.First();
            //oDb.EQUIPAMENTO_VENDAs.Attach(oSupp);
            oDb.EQUIPAMENTO_VENDAs.DeleteOnSubmit(oSupp);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static EQUIPAMENTO_VENDA SelecionaPK(int CodigoV, int CodigoE)
        {
            EQUIPAMENTO_VENDA oEQUIPAMENTO_VENDA = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.EQUIPAMENTO_VENDAs where p.CodVenda == CodigoV && p.CodEquipamento == CodigoE select p;
            if (Result.Count() > 0)
            {
                oEQUIPAMENTO_VENDA = Result.First();
            }

            oDb.Dispose();
            return oEQUIPAMENTO_VENDA;
        }
        //
        public static VW_EQUIPVENDA SelecionaVW_PK(int CodigoV, int CodigoE)
        {
            VW_EQUIPVENDA oEQUIPAMENTO_VENDA = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_EQUIPVENDAs where p.CodVenda == CodigoV && p.CodEquipamento == CodigoE select p;
            if (Result.Count() > 0)
            {
                oEQUIPAMENTO_VENDA = Result.First();
            }

            oDb.Dispose();
            return oEQUIPAMENTO_VENDA;
        }

        public static List<VW_EQUIPVENDA> SelecionaTodos()
        {
            List<VW_EQUIPVENDA> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_EQUIPVENDAs orderby p.Nome select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }
        //consulta
        public static List<VW_EQUIPVENDA> SelecionaTodosCodigoVenda(int CodigoV)
        {
            List<VW_EQUIPVENDA> oLista = new List<VW_EQUIPVENDA>();
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_EQUIPVENDAs where p.CodVenda == CodigoV select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }
    }
}
