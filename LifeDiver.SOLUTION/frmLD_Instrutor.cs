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
    public partial class frmLD_Instrutor : Form
    {
        public frmLD_Instrutor()
        {
            InitializeComponent();
        }

        private bool Alterar = false;
        private DateTime dataAlterar;


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                INSTRUTOR oInstru = new INSTRUTOR();
                oInstru.Nome = txtNome.Text;
                oInstru.CPF = msktxtCPF.Text;
                oInstru.E_mail = txtEmail.Text;
                oInstru.Endereço = txtEndereco.Text;
                oInstru.Telefone = msktxtTelefone.Text;
                if(rdYes.Checked)
                    oInstru.Certificado = true;
                else if(rdNo.Checked)
                    oInstru.Certificado = false;

                if (!Alterar)
                {
                    oInstru.DataCadastro = DateTime.Now.Date;
                    CINSTRUTOR.Incluir(oInstru);
                    MessageBox.Show("O Instrutor foi cadastrado com Sucesso!");


                }
                else
                {
                    oInstru.DataCadastro = dataAlterar;
                    CINSTRUTOR.Alterar(oInstru);
                    MessageBox.Show("O Instrutor foi alterado com Sucesso!");
                    msktxtCPF.Enabled = true;
                    Alterar = false;
                    dataAlterar = DateTime.Now;
                }

                CarregaGrid();
                LimpaControles();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpaControles();
        }

        private void CarregaGrid()
        {
            dtgInstrutor.AutoGenerateColumns = false;
            dtgInstrutor.DataSource = CINSTRUTOR.SelecionaTodos();
        }

        private void LimpaControles()
        {
            dataAlterar = DateTime.Now;
            if (!msktxtCPF.Enabled)
                msktxtCPF.Enabled = true;
            if (Alterar)
                Alterar = false;
            msktxtCPF.Text = "";
            msktxtTelefone.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtNome.Text = "";
            txtConsulta.Text = "";
            rdNo.Checked = false;
            rdYes.Checked = false;
        }

        private bool ValidaControles()
        {
            if (msktxtCPF.Text.Trim().Length != 14)
            {
                MessageBox.Show("O CPF do Instrutor não foi informado devidamente!");
                msktxtCPF.Focus();
                return false;
            }
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Nome do Instrutor não foi informado!");
                txtNome.Focus();
                return false;
            }
            if (txtEndereco.Text.Trim() == "")
            {
                MessageBox.Show("O Endereço do Instrutor não foi informado!");
                txtEndereco.Focus();
                return false;
            }
            if (msktxtTelefone.Text.Trim().Length != 14)
            {
                MessageBox.Show("O Telefone do Instrutor não foi informado devidamente!");
                msktxtTelefone.Focus();
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("O E-mail do Instrutor não foi informado!");
                txtEmail.Focus();
                return false;
            }
            if(!rdYes.Checked && !rdNo.Checked)
            {
                MessageBox.Show("Não foi informado se o instrutor possui certificado ou não!");
                rdYes.Focus();
                return false;
            }
            //verificaigual
            if (!Alterar)
            {
                foreach (INSTRUTOR p in CINSTRUTOR.SelecionaTodos())
                {
                    if (p.CPF == msktxtCPF.Text)
                    {
                        MessageBox.Show("Este CPF já está cadastrado!");
                        msktxtCPF.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        private void frmLD_Instrutor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolInstrutor = false;
        }

        private void frmLD_Instrutor_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dtgInstrutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInstrutor.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgInstrutor.Columns[e.ColumnIndex].Name == "btnAlterar")
                    {
                        INSTRUTOR oInstru = (INSTRUTOR)dtgInstrutor.Rows[e.RowIndex].DataBoundItem;
                        msktxtCPF.Text = oInstru.CPF;
                        msktxtTelefone.Text = oInstru.Telefone;
                        txtEmail.Text = oInstru.E_mail;
                        txtEndereco.Text = oInstru.Endereço;
                        txtNome.Text = oInstru.Nome;
                        dataAlterar = (DateTime)oInstru.DataCadastro;
                        msktxtCPF.Enabled = false;
                        if (oInstru.Certificado.Value)
                        { 
                            rdYes.Checked = true;
                            rdNo.Checked = false;
                        }      
                        else
                        {
                            rdYes.Checked = false;
                            rdNo.Checked = true;
                        }
                        Alterar = true;
                    }

                    if (dtgInstrutor.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        if (Alterar)
                        {
                            Alterar = false;
                            LimpaControles();
                        }  
                        if (MessageBox.Show("Deseja realmente excluir os dados desse Instrutor? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            INSTRUTOR oInstru = (INSTRUTOR)dtgInstrutor.Rows[e.RowIndex].DataBoundItem;
                            oInstru = CINSTRUTOR.SelecionaPK(oInstru.CPF);
                            CINSTRUTOR.Excluir(oInstru);
                            CarregaGrid();
                        }
                    }
                }
            }
        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdCPF.Checked)
                {
                    dtgInstrutor.AutoGenerateColumns = false;
                    dtgInstrutor.DataSource = CINSTRUTOR_CONSULTA.SelecionaTodosCPF(txtConsulta.Text);
                }

                if (rdNome.Checked)
                {
                    dtgInstrutor.AutoGenerateColumns = false;
                    dtgInstrutor.DataSource = CINSTRUTOR_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
            else
                CarregaGrid();
        }

        private void rdCPF_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdCPF.Checked)
                {
                    dtgInstrutor.AutoGenerateColumns = false;
                    dtgInstrutor.DataSource = CINSTRUTOR_CONSULTA.SelecionaTodosCPF(txtConsulta.Text);
                }
            }
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdNome.Checked)
                {
                    dtgInstrutor.AutoGenerateColumns = false;
                    dtgInstrutor.DataSource = CINSTRUTOR_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
        }

        //end
    }
}
