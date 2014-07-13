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
    public partial class frmLD_Cliente : Form
    {

        private bool Alterar = false;
        private DateTime dataAlterar;

        public frmLD_Cliente()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                CLIENTE oCli = new CLIENTE();
                oCli.Nome = txtNome.Text;
                oCli.CPF = msktxtCPF.Text;
                oCli.E_mail = txtEmail.Text;
                oCli.Endereço = txtEndereco.Text;
                oCli.Telefone = msktxtTelefone.Text;
                if (!Alterar)
                {
                    oCli.DataCadastro = DateTime.Now.Date;
                    CCLIENTE.Incluir(oCli);
                    MessageBox.Show("O Cliente foi cadastrado com Sucesso!");


                }
                else
                {
                    oCli.DataCadastro = dataAlterar;
                    CCLIENTE.Alterar(oCli);
                    MessageBox.Show("O Cliente foi alterado com Sucesso!");
                    msktxtCPF.Enabled = true;
                    Alterar = false;
                    dataAlterar = DateTime.Now;
                }

                CarregaGrid();
                LimpaControles();
            }

        }

        private void CarregaGrid()
        {
            dtgCliente.AutoGenerateColumns = false;
            dtgCliente.DataSource = CCLIENTE.SelecionaTodos();
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
        }

        private bool ValidaControles()
        {
            if (msktxtCPF.Text.Trim().Length != 14)
            {
                MessageBox.Show("O CPF do Cliente não foi informado devidamente!");
                msktxtCPF.Focus();
                return false;
            }
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Nome do Cliente não foi informado!");
                txtNome.Focus();
                return false;
            }
            if (txtEndereco.Text.Trim() == "")
            {
                MessageBox.Show("O Endereço do Cliente não foi informado!");
                txtEndereco.Focus();
                return false;
            }
            if (msktxtTelefone.Text.Trim().Length != 14)
            {
                MessageBox.Show("O Telefone do Cliente não foi informado devidamente!");
                msktxtTelefone.Focus();
                return false;
            }
            if (txtEmail.Text.Trim() == "")
            {
                MessageBox.Show("O E-mail do Cliente não foi informado!");
                txtEmail.Focus();
                return false;
            }
            //verificaigual
            if (!Alterar)
            {
                if (!Alterar)
                {
                    foreach (CLIENTE p in CCLIENTE.SelecionaTodos())
                    {
                        if (p.CPF == msktxtCPF.Text)
                        {
                            MessageBox.Show("Este CPF já está cadastrado!");
                            msktxtCPF.Focus();
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private void frmLD_Cliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolCliente = false;
        }

        private void frmLD_Cliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LimpaControles();
        }

        private void dtgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgCliente.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgCliente.Columns[e.ColumnIndex].Name == "btnAlterar")
                    {
                        CLIENTE oCli = (CLIENTE)dtgCliente.Rows[e.RowIndex].DataBoundItem;
                        msktxtCPF.Text = oCli.CPF;
                        msktxtTelefone.Text = oCli.Telefone;
                        txtEmail.Text = oCli.E_mail;
                        txtEndereco.Text = oCli.Endereço;
                        txtNome.Text = oCli.Nome;
                        dataAlterar = (DateTime)oCli.DataCadastro;
                        msktxtCPF.Enabled = false;
                        Alterar = true;
                    }

                    if (dtgCliente.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        if (Alterar)
                        {
                            Alterar = false;
                            LimpaControles();
                        }  
                        if (MessageBox.Show("Deseja realmente excluir os dados desse Cliente? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            CLIENTE oCli = (CLIENTE)dtgCliente.Rows[e.RowIndex].DataBoundItem;
                            oCli = CCLIENTE.SelecionaPK(oCli.CPF);
                            CCLIENTE.Excluir(oCli);
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
                    dtgCliente.AutoGenerateColumns = false;
                    dtgCliente.DataSource = CCLIENTE_CONSULTA.SelecionaTodosCPF(txtConsulta.Text);
                }

                if (rdNome.Checked)
                {
                    dtgCliente.AutoGenerateColumns = false;
                    dtgCliente.DataSource = CCLIENTE_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
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
                    dtgCliente.AutoGenerateColumns = false;
                    dtgCliente.DataSource = CCLIENTE_CONSULTA.SelecionaTodosCPF(txtConsulta.Text);
                }
            }
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdNome.Checked)
                {
                    dtgCliente.AutoGenerateColumns = false;
                    dtgCliente.DataSource = CCLIENTE_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
        }



        //end
    }

}
