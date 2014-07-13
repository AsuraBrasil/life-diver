using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class AGENDAMENTO
    {
         public static void Incluir(AGENDAMENTO oAGENDAMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.AGENDAMENTOs.InsertOnSubmit(oAGENDAMENTO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(AGENDAMENTO oAGENDAMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.AGENDAMENTOs.Attach(oAGENDAMENTO, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(AGENDAMENTO oAGENDAMENTO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oAGENDAMENTO = oDb.AGENDAMENTOs.Single(AGENDAMENTO => AGENDAMENTO.CodAgendamento == oAGENDAMENTO.CodAgendamento);
            oDb.AGENDAMENTOs.DeleteOnSubmit(oAGENDAMENTO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static AGENDAMENTO SelecionaPK(int Codigo)
        {
            AGENDAMENTO oAGENDAMENTO = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.AGENDAMENTOs where p.CodAgendamento == Codigo select p;
            if (Result.Count() > 0)
            {
                oAGENDAMENTO = Result.First();
            }

            oDb.Dispose();
            return oAGENDAMENTO;
        }

        public static List<VW_AGENDAMENTO> SelecionaTodos()
        {
            List<VW_AGENDAMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_AGENDAMENTOs orderby p.DataAgendada select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }
        /*
        public static List<VW_AGENDAMENTO> SelecionaTodosCPFCliente(string cliCPF)
        {
            List<VW_AGENDAMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_AGENDAMENTOs where p.CPFCliente.StartsWith(cliCPF) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
            
        } */

        public static List<VW_AGENDAMENTO> SelecionaTodosData(DateTime dataAgendada)
        {
            List<VW_AGENDAMENTO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_AGENDAMENTOs where p.DataAgendada.Value == dataAgendada select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

    }
}
