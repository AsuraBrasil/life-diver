using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LifeDiver.CONTROL;
using LifeDiver.MODEL;

namespace LifeDiver.SOLUTION
{
    public partial class frmLD_Curso : Form
    {
        public frmLD_Curso()
        {
            InitializeComponent();
        }

        //
        private bool Alterar = false;
        private int codigoAlterando = 0;

        private void frmLD_Curso_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                CURSO oCurso = new CURSO();
                oCurso.Nome = txtNome.Text;
                oCurso.CPFInstrutor = msktxtCPFInstru.Text;
                oCurso.Horas = int.Parse(txtHoras.Text.Trim());
                oCurso.Preco = decimal.Parse(txtPreco.Text.Trim());
                oCurso.NumeroPessoasTurma = int.Parse(txtTurma.Text);
                if (!Alterar)
                {
                    CCURSO.Incluir(oCurso);
                    MessageBox.Show("O Curso foi cadastrado com Sucesso!");
                    CarregaGrid();
                }
                else
                {
                    oCurso.CodCurso = codigoAlterando;
                    CCURSO.Alterar(oCurso);
                    MessageBox.Show("O Curso foi alterado com Sucesso!");
                    codigoAlterando = 0;
                    Alterar = false;
                }

                CarregaGrid();
                LimpaControles();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpaControles();
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdCodigo.Checked)
                {
                    dtgCurso.AutoGenerateColumns = false;
                    dtgCurso.DataSource = CCURSO_CONSULTA.SelecionaTodosCodigo(txtConsulta.Text);
                }

                if (rdNome.Checked)
                {
                    dtgCurso.AutoGenerateColumns = false;
                    dtgCurso.DataSource = CCURSO_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
            else
                CarregaGrid();
        }

        private void rdCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdCodigo.Checked)
                {
                    dtgCurso.AutoGenerateColumns = false;
                    dtgCurso.DataSource = CCURSO_CONSULTA.SelecionaTodosCodigo(txtConsulta.Text);
                }
            }
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdNome.Checked)
                {
                    dtgCurso.AutoGenerateColumns = false;
                    dtgCurso.DataSource = CCURSO_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
        }

        private void frmLD_Curso_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolCurso = false;
        }

        //functions
        private void CarregaGrid()
        {
            dtgCurso.AutoGenerateColumns = false;
            dtgCurso.DataSource = CCURSO.SelecionaTodos();
        }

        private void LimpaControles()
        {
            if (codigoAlterando != 0)
                codigoAlterando = 0;
            if (Alterar)
                Alterar = false;
            txtNome.Text = "";
            txtHoras.Text = "";
            msktxtCPFInstru.Text = "";
            txtPreco.Text = "";
            txtConsulta.Text = "";
            lblCpfEncontrado.Text = "";
            txtTurma.Text = "";
        }

        private bool ValidaControles()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Nome do CURSO não foi informado!");
                txtNome.Focus();
                return false;
            }
            if (msktxtCPFInstru.Text.Trim().Length != 14)
            {
                MessageBox.Show("O CPF do Instrutor responsável pelo curso não foi informado devidamente!");
                msktxtCPFInstru.Focus();
                return false;
            }

            INSTRUTOR oInstru = null;
            oInstru = CINSTRUTOR.SelecionaPK(msktxtCPFInstru.Text);
            if(oInstru == null)
            {
                MessageBox.Show("O CPF do Instrutor responsável pelo curso não está registrado!");
                msktxtCPFInstru.Focus();
                return false;
            }

            int integerData;
            if (txtHoras.Text.Trim() == "" || int.TryParse(txtHoras.Text.Trim(), out integerData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo Horas!");
                txtHoras.Focus();
                return false;
            }
            if (txtTurma.Text.Trim() == "" || int.TryParse(txtTurma.Text.Trim(), out integerData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo Pessoas por Turma!");
                txtTurma.Focus();
                return false;
            }
            decimal decData;
            if (txtPreco.Text.Trim() == "" || decimal.TryParse(txtPreco.Text.Trim(), out decData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo Preço!");
                txtPreco.Focus();
                return false;
            }

            return true;
        }

        private void dtgCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCurso.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgCurso.Columns[e.ColumnIndex].Name == "btnAlterar")
                    {
                        VW_CURSO oCurso = (VW_CURSO)dtgCurso.Rows[e.RowIndex].DataBoundItem;                      
                        txtNome.Text = oCurso.Nome;
                        txtHoras.Text = oCurso.Horas.ToString();
                        txtPreco.Text = oCurso.Preco.ToString();
                        txtTurma.Text = oCurso.NumeroPessoasTurma.ToString();
                        msktxtCPFInstru.Text = CCURSO.SelecionaPK(oCurso.CodCurso).CPFInstrutor;
                        codigoAlterando = oCurso.CodCurso;
                        Alterar = true;
                    }

                    if (dtgCurso.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        if (Alterar)
                        {
                            Alterar = false;
                            LimpaControles();
                        }  
                        if (MessageBox.Show("Deseja realmente excluir os dados desse Curso? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            VW_CURSO oCurso = (VW_CURSO)dtgCurso.Rows[e.RowIndex].DataBoundItem;
                            CURSO poCurso = CCURSO.SelecionaPK(oCurso.CodCurso);
                            CCURSO.Excluir(poCurso);
                            CarregaGrid();
                        }
                    }
                }
            }
        }

        //
        private void msktxtCPFInstru_Leave(object sender, EventArgs e)
        {
            if (msktxtCPFInstru.MaskCompleted)
            {
                INSTRUTOR oInstru = null;
                oInstru = CINSTRUTOR.SelecionaPK(msktxtCPFInstru.Text);
                if (oInstru == null)
                {
                    lblCpfEncontrado.ForeColor = Color.LightCoral;
                    lblCpfEncontrado.Text = "CPF não encontrado!";
                }
                else
                {
                    lblCpfEncontrado.ForeColor = Color.LimeGreen;
                    lblCpfEncontrado.Text = "CPF encontrado!";
                }
            }
            else
            {
                lblCpfEncontrado.ForeColor = Color.LightCoral;
                lblCpfEncontrado.Text = "CPF incorreto!";
            }

        }

        private void msktxtCPFInstru_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCPFInstru.Text.Trim().Length<10)
            {
                lblCpfEncontrado.Text = "";
            }
        }

        //end
    }
}
