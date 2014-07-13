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
    public partial class frmLD_Equipamento : Form
    {
        public frmLD_Equipamento()
        {
            InitializeComponent();
        }

        //
        private bool Alterar = false;

        private void frmLD_Equipamento_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void frmLD_Equipamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolEquip = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                EQUIPAMENTO oEquip = new EQUIPAMENTO();
                oEquip.Nome = txtNome.Text;
                oEquip.CodEquipamento = int.Parse(msktxtCod.Text.Trim());
                oEquip.QtdEstoque = int.Parse(txtQtd.Text.Trim());
                oEquip.Preco = decimal.Parse(txtPreco.Text.Trim());
                oEquip.Tipo = cmbTipo.Text;
                if (!Alterar)
                {
                    CEQUIPAMENTO.Incluir(oEquip);
                    MessageBox.Show("O Equipamento foi cadastrado com Sucesso!");
                    CarregaGrid();
                }
                else
                {
                    CEQUIPAMENTO.Alterar(oEquip);
                    MessageBox.Show("O Equipamento foi alterado com Sucesso!");
                    msktxtCod.Enabled = true;
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
                    dtgEquip.AutoGenerateColumns = false;
                    dtgEquip.DataSource = CEQUIPAMENTO_CONSULTA.SelecionaTodosCodigo(txtConsulta.Text);
                }

                if (rdNome.Checked)
                {
                    dtgEquip.AutoGenerateColumns = false;
                    dtgEquip.DataSource = CEQUIPAMENTO_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
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
                    dtgEquip.AutoGenerateColumns = false;
                    dtgEquip.DataSource = CEQUIPAMENTO_CONSULTA.SelecionaTodosCodigo(txtConsulta.Text);
                }
            }
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdNome.Checked)
                {
                    dtgEquip.AutoGenerateColumns = false;
                    dtgEquip.DataSource = CEQUIPAMENTO_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
        }

        //Functions
        private void CarregaGrid()
        {
            dtgEquip.AutoGenerateColumns = false;
            dtgEquip.DataSource = CEQUIPAMENTO.SelecionaTodos();
        }

        private void LimpaControles()
        {
            if (!msktxtCod.Enabled)
                msktxtCod.Enabled = true;
            if (Alterar)
                Alterar = false;
            msktxtCod.Text = "";
            txtNome.Text = "";
            cmbTipo.SelectedIndex = -1;
            txtQtd.Text = "";
            txtPreco.Text = "";
            txtConsulta.Text = "";
        }

        private bool ValidaControles()
        {
            int integerData;
            if (msktxtCod.Text.Trim().Length != 4 || !int.TryParse(msktxtCod.Text.Trim(), out integerData))
            {
                MessageBox.Show("O Codigo do Equipamento não foi informado devidamente!");
                msktxtCod.Focus();
                return false;
            }
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Nome do Equipamento não foi informado!");
                txtNome.Focus();
                return false;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("O Tipo do Equipamento não foi informado!");
                cmbTipo.Focus();
                return false;
            }
            
            if (txtQtd.Text.Trim() =="" || int.TryParse(txtQtd.Text.Trim(), out integerData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo Quantidade!");
                txtQtd.Focus();
                return false;
            }
            decimal decData;
            if (txtPreco.Text.Trim() =="" || decimal.TryParse(txtPreco.Text.Trim(), out decData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo Preço!");
                txtPreco.Focus();
                return false;
            }
            //verificaigual
            if (!Alterar)
            {
                foreach (EQUIPAMENTO p in CEQUIPAMENTO.SelecionaTodos())
                {
                    if (p.CodEquipamento == int.Parse(msktxtCod.Text))
                    {
                        MessageBox.Show("Este Código já está cadastrado!");
                        msktxtCod.Focus();
                        return false;
                    }
                }
            }

            return true;
        }

        private void dtgEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgEquip.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgEquip.Columns[e.ColumnIndex].Name == "btnAlterar")
                    {
                        EQUIPAMENTO oEquip = (EQUIPAMENTO)dtgEquip.Rows[e.RowIndex].DataBoundItem;
                        msktxtCod.Text = oEquip.CodEquipamento.ToString();
                        txtNome.Text = oEquip.Nome;
                        txtQtd.Text = oEquip.QtdEstoque.ToString();
                        txtPreco.Text = oEquip.Preco.ToString();
                        cmbTipo.Text = oEquip.Tipo;
                        msktxtCod.Enabled = false;
                        Alterar = true;
                    }

                    if (dtgEquip.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        if (Alterar)
                        {
                            Alterar = false;
                            LimpaControles();
                        }  
                        if (MessageBox.Show("Deseja realmente excluir os dados desse Equipamento? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            EQUIPAMENTO oEquip = (EQUIPAMENTO)dtgEquip.Rows[e.RowIndex].DataBoundItem;
                            oEquip = CEQUIPAMENTO.SelecionaPK(oEquip.CodEquipamento);
                            CEQUIPAMENTO.Excluir(oEquip);
                            CarregaGrid();
                        }
                    }
                }
            }
        }

        //end
    }
}
