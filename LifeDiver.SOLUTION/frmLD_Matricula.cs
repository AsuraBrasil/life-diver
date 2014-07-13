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
    public partial class frmLD_Matricula : Form
    {
        public frmLD_Matricula()
        {
            InitializeComponent();
        }

        private bool Alterar = false;
        private DateTime dataAlterando = DateTime.Now;

        private void frmLD_Matricula_Load(object sender, EventArgs e)
        {
            CarregaGrid();
            cmbCurso.DataSource = null;
            cmbCurso.DataSource = CCURSO.SelecionaTodos();
            cmbCurso.DisplayMember = "Nome";
            cmbCurso.ValueMember = "CodCurso";
            cmbCurso.SelectedIndex = -1;
        }

        private void frmLD_Matricula_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolMatricula = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                CLIENTE_CURSO oCLIENTE_CURSO = new CLIENTE_CURSO();
                oCLIENTE_CURSO.CPFCliente = msktxtCPFCli.Text;
                oCLIENTE_CURSO.CodCurso = (int)cmbCurso.SelectedValue;
                oCLIENTE_CURSO.Turma = cmbTurma.Text;
                if (!Alterar)
                {
                    oCLIENTE_CURSO.DataMatricula = DateTime.Now;
                    CCLIENTE_CURSO.Incluir(oCLIENTE_CURSO);
                    MessageBox.Show("O Cliente foi matriculado com Sucesso!");
                    CarregaGrid();
                }
                else
                {
                    oCLIENTE_CURSO.DataMatricula = dataAlterando;
                    CCLIENTE_CURSO.Alterar(oCLIENTE_CURSO);
                    MessageBox.Show("A Matricula foi alterada com Sucesso!");
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

        private void dtgCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCurso.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgCurso.Columns[e.ColumnIndex].Name == "btnAlterar")
                    {
                        VW_CLIENTE_CURSO oCLIENTE_CURSO = (VW_CLIENTE_CURSO)dtgCurso.Rows[e.RowIndex].DataBoundItem;
                        cmbTurma.Text = oCLIENTE_CURSO.Turma;
                        msktxtCPFCli.Text = oCLIENTE_CURSO.CPFCliente;
                        cmbCurso.SelectedValue = oCLIENTE_CURSO.CodCurso;
                        cmbCurso.Text = oCLIENTE_CURSO.CursoNome;
                        dataAlterando = oCLIENTE_CURSO.DataMatricula.Value;
                        Alterar = true;
                    }

                    if (dtgCurso.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        if (Alterar)
                        {
                            Alterar = false;
                            LimpaControles();
                        }
                        if (MessageBox.Show("Deseja realmente excluir os dados dessa Matrícula? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            VW_CLIENTE_CURSO oCLIENTE_CURSO = (VW_CLIENTE_CURSO)dtgCurso.Rows[e.RowIndex].DataBoundItem;
                            CLIENTE_CURSO poCLIENTE_CURSO = CCLIENTE_CURSO.SelecionaPK(oCLIENTE_CURSO.CodCurso, oCLIENTE_CURSO.CPFCliente);
                            CCLIENTE_CURSO.Excluir(poCLIENTE_CURSO);
                            CarregaGrid();
                        }

                    }
                }
            }
        }

        private void rdCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdCodigo.Checked)
                {
                    dtgCurso.AutoGenerateColumns = false;
                    dtgCurso.DataSource = CCLIENTE_CURSO_CONSULTA.SelecionaTodosCodigoCurso(txtConsulta.Text);
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
                    dtgCurso.DataSource = CCLIENTE_CURSO_CONSULTA.SelecionaTodosNomeCliente(txtConsulta.Text);
                }
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdCodigo.Checked)
                {
                    dtgCurso.AutoGenerateColumns = false;
                    dtgCurso.DataSource = CCLIENTE_CURSO_CONSULTA.SelecionaTodosCodigoCurso(txtConsulta.Text);
                }

                if (rdNome.Checked)
                {
                    dtgCurso.AutoGenerateColumns = false;
                    dtgCurso.DataSource = CCLIENTE_CURSO_CONSULTA.SelecionaTodosNomeCliente(txtConsulta.Text);
                }
            }
            else
                CarregaGrid();
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (cmbCurso.SelectedIndex > -1)
            //    {
                    
            //    }
            //    else
            //    {
                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.Write("Debug: " + ex.ToString());
            //}
        }
    
        //functions
        private void CarregaGrid()
        {
            dtgCurso.AutoGenerateColumns = false;
            dtgCurso.DataSource = CCLIENTE_CURSO.SelecionaTodos();
            //
            cmbCurso.DataSource = null;
            cmbCurso.DataSource = CCURSO.SelecionaTodos();
            cmbCurso.DisplayMember = "Nome";
            cmbCurso.ValueMember = "CodCurso";
            cmbCurso.SelectedIndex = -1;
        }

        private void LimpaControles()
        {
            if (Alterar)
                Alterar = false;
            cmbTurma.Text = "";
            msktxtCPFCli.Text = "";
            txtConsulta.Text = "";
            lblCpfEncontrado.Text = "";
            dataAlterando = DateTime.Now;
            cmbCurso.SelectedIndex = -1;
        }

        private bool ValidaControles()
        {
            //
            if (msktxtCPFCli.Text.Trim().Length != 14)
            {
                MessageBox.Show("O CPF do CLIENTE não foi informado devidamente!");
                msktxtCPFCli.Focus();
                return false;
            }
            CLIENTE oCli = null;
            oCli = CCLIENTE.SelecionaPK(msktxtCPFCli.Text);
            if (oCli == null)
            {
                MessageBox.Show("O CPF do Cliente informado não está registrado!");
                msktxtCPFCli.Focus();
                return false;
            }
            
            
            //
            if (cmbCurso.SelectedIndex < 0 || cmbCurso.Text.Trim() == "")
            {
                MessageBox.Show("Nenhum Curso foi selecionado!");
                cmbCurso.Focus();
                return false;
            }
            //
            if (cmbTurma.Text.Trim() == "")
            {
                MessageBox.Show("Nome da Turma não foi informado!");
                cmbCurso.Focus();
                return false;
            }

            //verificaigual
            if (!Alterar)
            {
                foreach (VW_CLIENTE_CURSO p in CCLIENTE_CURSO.SelecionaTodos())
                {
                    if (p.CPFCliente == msktxtCPFCli.Text && p.CodCurso == (int)cmbCurso.SelectedValue)
                    {
                        MessageBox.Show("Já há uma matricula relacionada a este Cliente neste Curso!");
                        cmbCurso.Focus();
                        return false;
                    }
                }
            }
           
            return true;
        }

        private void msktxtCPFCli_Leave(object sender, EventArgs e)
        {
            if (msktxtCPFCli.MaskCompleted)
            {
                CLIENTE oCli = null;
                oCli = CCLIENTE.SelecionaPK(msktxtCPFCli.Text);
                if (oCli == null)
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

        private void msktxtCPFCli_TextChanged(object sender, EventArgs e)
        {
            if (msktxtCPFCli.MaskCompleted)
            {
                CLIENTE oCli = null;
                oCli = CCLIENTE.SelecionaPK(msktxtCPFCli.Text);
                if (oCli == null)
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


    //end
    }
}
