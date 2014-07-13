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
    public partial class frmLD_Agenda : Form
    {
        public frmLD_Agenda()
        {
            InitializeComponent();
        }

        //
        private bool Alterar = false;
        private int codigoAlterando = 0;
        private DateTime dataAlterando = DateTime.Now;

        private void frmLD_Agenda_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void frmLD_Agenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolAgenda = false;
        }

        private void cmbPacote_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbPacote.SelectedIndex > -1)
                {
                    txtPreco.Text = CPACOTE.SelecionaPK((int)cmbPacote.SelectedValue).Preco.ToString();
                    lblQtdMaximo.Text = "N° Máximo Permitido:" + CPACOTE.SelecionaPK((int)cmbPacote.SelectedValue).NumeroPessoasMax.ToString();
                }
                else
                {
                    txtPreco.Text = "";
                    txtValorTotal.Text = "";
                }
                CalculaTotal();                  
            }
            catch(Exception ex)
            {
                Console.Write("Debug: " + ex.ToString());
            }

        }

        //functions
        private void CarregaGrid()
        {
            dtgAgenda.AutoGenerateColumns = false;
            dtgAgenda.DataSource = CAGENDAMENTO.SelecionaTodos();
            //
            cmbPacote.DataSource = null;
            cmbPacote.DataSource = CPACOTE.SelecionaTodos();
            cmbPacote.DisplayMember = "Nome";
            cmbPacote.ValueMember = "CodPacote";
            cmbPacote.SelectedIndex = -1;
        }

        private void LimpaControles()
        {
            if (codigoAlterando != 0)
                codigoAlterando = 0;
            if (Alterar)
                Alterar = false;
            dtPickerAgendada.Value = DateTime.Now.Date;
            txtQtdPessoas.Text = "0";
            txtQtdPessoasSem.Text = "0";
            msktxtCPFCli.Text = "";
            dtPickerPesquisa.Value = DateTime.Now.Date;
            lblQtdMaximo.Text = "";
            lblQtdMaxSemEquip.Text = "";
            lblCpfEncontrado.Text = "";
            dataAlterando = DateTime.Now;
            cmbPacote.SelectedIndex = -1;
        }

        private bool ValidaControles()
        {
            if(dtPickerAgendada.Value == DateTime.Now.Date)
            {
                MessageBox.Show("O Sistema não permite que você agende um mergulho para o dia de Hoje!\nData:" + DateTime.Now.Date.ToString("dd/MM/yyyy"));
                dtPickerAgendada.Focus();
                return false;
            }
            //
            if (msktxtCPFCli.Text.Trim().Length != 14)
            {
                MessageBox.Show("O CPF do CLIENTE responsável pelo AGENDAMENTO não foi informado devidamente!");
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
            if (cmbPacote.SelectedIndex < 0 || cmbPacote.Text.Trim() =="")
            {
                MessageBox.Show("Nenhum Pacote foi selecionado!");
                cmbPacote.Focus();
                return false;
            }
            //
            int integerData;
            if (txtQtdPessoas.Text.Trim() == "" || int.TryParse(txtQtdPessoas.Text.Trim(), out integerData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo Quantidade de Pessoas!");
                txtQtdPessoas.Focus();
                return false;
            }
            if(int.Parse(txtQtdPessoas.Text) > CPACOTE.SelecionaPK((int)cmbPacote.SelectedValue).NumeroPessoasMax)
            {
                MessageBox.Show("O número de pessoas é maior do que o permitido no pacote!");
                txtQtdPessoas.Focus();
                return false;
            }
            //
            if (txtQtdPessoasSem.Text.Trim() == "" || int.TryParse(txtQtdPessoas.Text.Trim(), out integerData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo Quantidade de Pessoas sem Equipamento!");
                txtQtdPessoasSem.Focus();
                return false;
            }
            if (int.Parse(txtQtdPessoasSem.Text) > int.Parse(txtQtdPessoas.Text))
            {
                MessageBox.Show("O número de pessoas sem equipamento é maior do que número de pessoas no pacote!");
                txtQtdPessoasSem.Focus();
                return false;
            }
            return true;
        }
        private void cmbPacote_TextChanged(object sender, EventArgs e)
        {
            if(cmbPacote.Text.Trim() == "")
            {
                txtPreco.Text = "";
                txtValorTotal.Text = "";
                lblQtdMaximo.Text = "";
                lblQtdMaxSemEquip.Text = "";
            }
        }

        private void txtQtdPessoas_TextChanged(object sender, EventArgs e)
        {
            int integerData;
            if (int.TryParse(txtQtdPessoas.Text, out integerData))
            {
                lblQtdMaxSemEquip.Text = "N° Máximo Permitido:" + txtQtdPessoas.Text;
            }
            else
            {
                lblQtdMaxSemEquip.Text = "";
            }
            CalculaTotal();
        }
        private void txtQtdPessoasSem_Leave(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        private void txtQtdPessoas_Leave(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        private void txtQtdPessoasSem_TextChanged(object sender, EventArgs e)
        {
            CalculaTotal();
        }
        private void CalculaTotal()
        {
            try
            {
                decimal calculo = (int.Parse(txtQtdPessoas.Text) * decimal.Parse(txtPreco.Text)) + (decimal.Parse(txtPreco.Text) / 100) * 10 * int.Parse(txtQtdPessoasSem.Text);
                txtValorTotal.Text = calculo.ToString();
            }
            catch (Exception ex)
            {
                Console.Write("Debug: " + ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                AGENDAMENTO oAGENDAMENTO = new AGENDAMENTO();
                oAGENDAMENTO.CPFCliente = msktxtCPFCli.Text;
                oAGENDAMENTO.QtdPessoas = int.Parse(txtQtdPessoas.Text.Trim());
                oAGENDAMENTO.QtdPessoasSemEquipamento = int.Parse(txtQtdPessoasSem.Text.Trim());
                oAGENDAMENTO.CodPacote = (int)cmbPacote.SelectedValue;
                oAGENDAMENTO.DataAgendada = dtPickerAgendada.Value;
                if (!Alterar)
                {
                    oAGENDAMENTO.DateRegistro = DateTime.Now;
                    CAGENDAMENTO.Incluir(oAGENDAMENTO);
                    MessageBox.Show("O Agendamento foi registrado com Sucesso!");
                    CarregaGrid();
                }
                else
                {
                    oAGENDAMENTO.CodAgendamento = codigoAlterando;
                    oAGENDAMENTO.DateRegistro = dataAlterando;
                    CAGENDAMENTO.Alterar(oAGENDAMENTO);
                    MessageBox.Show("O Agendamento foi alterado com Sucesso!");
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

        private void dtgAgenda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgAgenda.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgAgenda.Columns[e.ColumnIndex].Name == "btnAlterar")
                    {
                        VW_AGENDAMENTO oAGENDAMENTO = (VW_AGENDAMENTO)dtgAgenda.Rows[e.RowIndex].DataBoundItem;
                        dtPickerAgendada.Value = oAGENDAMENTO.DataAgendada.Value;
                        txtQtdPessoas.Text = oAGENDAMENTO.QtdPessoas.ToString();
                        txtQtdPessoasSem.Text = oAGENDAMENTO.QtdPessoasSemEquipamento.ToString();
                        msktxtCPFCli.Text = oAGENDAMENTO.CPFCliente;
                        cmbPacote.Text = CPACOTE.SelecionaPK(CAGENDAMENTO.SelecionaPK(oAGENDAMENTO.CodAgendamento).CodPacote).Nome;
                        cmbPacote.SelectedValue = CAGENDAMENTO.SelecionaPK(oAGENDAMENTO.CodAgendamento).CodPacote;
                        txtPreco.Text = CPACOTE.SelecionaPK(CAGENDAMENTO.SelecionaPK(oAGENDAMENTO.CodAgendamento).CodPacote).Preco.ToString();
                        codigoAlterando = oAGENDAMENTO.CodAgendamento;
                        dataAlterando = oAGENDAMENTO.DateRegistro.Value;
                        Alterar = true;
                    }

                    if (dtgAgenda.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        if(Alterar)
                        {
                            Alterar = false;
                            LimpaControles();
                        }                                              
                        if (MessageBox.Show("Deseja realmente excluir os dados desse Agendamento? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            VW_AGENDAMENTO oAGENDAMENTO = (VW_AGENDAMENTO)dtgAgenda.Rows[e.RowIndex].DataBoundItem;
                            AGENDAMENTO poAGENDAMENTO = CAGENDAMENTO.SelecionaPK(oAGENDAMENTO.CodAgendamento);
                            CAGENDAMENTO.Excluir(poAGENDAMENTO);
                            CarregaGrid();
                        }
                        
                    }
                }
            }
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            CalculaTotal();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dtgAgenda.AutoGenerateColumns = false;
            dtgAgenda.DataSource = CAGENDAMENTO_CONSULTA.SelecionaTodosData(dtPickerPesquisa.Value);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        //end
    }
}
