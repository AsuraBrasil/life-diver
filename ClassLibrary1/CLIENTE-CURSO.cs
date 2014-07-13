using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeDiver.MODEL
{
    public partial class CLIENTE_CURSO
    {
        public static void Incluir(CLIENTE_CURSO oCLIENTE_CURSO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.CLIENTE_CURSOs.InsertOnSubmit(oCLIENTE_CURSO);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Alterar(CLIENTE_CURSO oCLIENTE_CURSO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
            oDb.CLIENTE_CURSOs.Attach(oCLIENTE_CURSO, true);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static void Excluir(CLIENTE_CURSO oCLIENTE_CURSO)
        {
            DataClassesDataContext oDb = new DataClassesDataContext();
           // oCLIENTE_CURSO = oDb.CLIENTE_CURSOs.Single(CLIENTE_CURSO => CLIENTE_CURSO.CodCurso == oCLIENTE_CURSO.CodCurso && CLIENTE_CURSO.CPFCliente == oCLIENTE_CURSO.CPFCliente);
            CLIENTE_CURSO oCliC = new CLIENTE_CURSO();
            var Res = from p in oDb.CLIENTE_CURSOs where p.CodCurso== oCLIENTE_CURSO.CodCurso && p.CPFCliente == oCLIENTE_CURSO.CPFCliente select p;
            oCliC = Res.First();
            //oDb.CLIENTE_CURSOs.Attach(oSupp);
            oDb.CLIENTE_CURSOs.DeleteOnSubmit(oCliC);
            oDb.SubmitChanges();
            oDb.Dispose();
        }

        public static CLIENTE_CURSO SelecionaPK(int Codigo, string CPFCliente)
        {
            CLIENTE_CURSO oCLIENTE_CURSO = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.CLIENTE_CURSOs where p.CodCurso == Codigo && p.CPFCliente == CPFCliente select p;
            if (Result.Count() > 0)
            {
                oCLIENTE_CURSO = Result.First();
            }

            oDb.Dispose();
            return oCLIENTE_CURSO;
        }

        public static List<VW_CLIENTE_CURSO> SelecionaTodos()
        {
            List<VW_CLIENTE_CURSO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_CLIENTE_CURSOs orderby p.Turma select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<VW_CLIENTE_CURSO> SelecionaTodosNomeCliente(string Nome)
        {
            List<VW_CLIENTE_CURSO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_CLIENTE_CURSOs where p.CliNome.StartsWith(Nome) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }

        public static List<VW_CLIENTE_CURSO> SelecionaTodosCodigoCurso(string sCodigo)
        {
            List<VW_CLIENTE_CURSO> oLista = null;
            DataClassesDataContext oDb = new DataClassesDataContext();
            var Result = from p in oDb.VW_CLIENTE_CURSOs where p.CodCurso.ToString().StartsWith(sCodigo) select p;
            if (Result.Count() > 0)
            {
                oLista = Result.ToList();
            }

            oDb.Dispose();
            return oLista;
        }
    }
}
