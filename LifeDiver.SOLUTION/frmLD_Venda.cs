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
    public partial class frmLD_Venda : Form
    {
        public frmLD_Venda()
        {
            InitializeComponent();
        }

        //private bool ValidaControles()
        //{
        //    if()

        //    return true;
        //}

        //private bool Novo = true;
        private DateTime dataAlterando = DateTime.Now;
        private int codigo = 0;

        private List<VW_EQUIPVENDA> listaItens = new List<VW_EQUIPVENDA>();
        private void btnNew_Click(object sender, EventArgs e)
        {
            dtgEquip.DataSource = null;
            LimpaControles();
            LimpaItens();
            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            txtCodigo.Enabled = false;
            txtCodigo.Text = "";
            msktxtCPFCli.Focus();
            
        }

        private bool ValidaControles()
        {
            if(!msktxtCPFCli.MaskCompleted || msktxtCPFCli.Text.Trim().Length < 14 || txtNomeCli.Text.Trim()=="" || CCLIENTE.SelecionaPK(msktxtCPFCli.Text)==null)
            {
                MessageBox.Show("O Cliente não foi informado devidamente para a venda");
                msktxtCPFCli.Focus();
                return false;
            }
            return true;
        }

        private bool ValidaControlesItens()
        {
            if(cmbEquips.SelectedIndex < 0 || cmbEquips.Text.Trim()=="")
            {
                MessageBox.Show("Não foi selecionado nenhum equipamento para adicionar!");
                cmbEquips.Focus();
                return false;
            }
            int integerData;
            if(int.TryParse(txtQtd.Text, out integerData)==false || txtQtd.Text.Trim()=="")
            {
                MessageBox.Show("Não foi informado um valor válido no campo Quantidade!");
                txtQtd.Focus();
                return false;
            }
            if((CEQUIPAMENTO.SelecionaPK((int)cmbEquips.SelectedValue)) == null)
            {
                MessageBox.Show("Não foi encontrado algum Equipamento com essas informações, tente selecionar novamente!");
                cmbEquips.Focus();
                return false;
            }
            if (int.TryParse(msktxtCodEquip.Text, out integerData) == false || msktxtCodEquip.Text.Trim() == "")
            {
                MessageBox.Show("Não foi informado um valor válido no campo Código do Equipamento");
                msktxtCodEquip.Focus();
                return false;
            }
            //
            foreach(VW_EQUIPVENDA oEquip in listaItens)
            {
                if(oEquip.CodEquipamento == (int)cmbEquips.SelectedValue)
                {
                    MessageBox.Show("Esse item já foi listado");
                    msktxtCodEquip.Focus();
                    return false;
                }
            }
            return true;
        }

        private void LimpaItens()
        {
            cmbEquips.SelectedIndex = -1;
            msktxtCodEquip.Text = "";
            txtPrecoUni.Text = "";
            txtQtd.Text = "";
            txtValorTotal.Text = "";

        }

        private void LimpaControles()
        {
            txtCodigo.Text = "";
            txtNomeCli.Text = "";
            msktxtCPFCli.Text = "";
            dtgEquip.DataSource = null;
            listaItens = new List<VW_EQUIPVENDA>();
            //Novo = true;
            dataAlterando = DateTime.Now;
            codigo = 0;
        }

        private void frmLD_Venda_Load(object sender, EventArgs e)
        {
            cmbEquips.DataSource = CEQUIPAMENTO.SelecionaTodos();
            cmbEquips.DisplayMember = "Nome";
            cmbEquips.ValueMember = "CodEquipamento";
            txtPrecoUni.Text = "";
            msktxtCodEquip.Text = "";
        }

        private void cmbEquips_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbEquips.SelectedIndex > -1)
                {
                    msktxtCodEquip.Text = cmbEquips.SelectedValue.ToString();
                    txtPrecoUni.Text = CEQUIPAMENTO.SelecionaPK((int)cmbEquips.SelectedValue).Preco.ToString();
                }
                else
                {
                    msktxtCodEquip.Text = "";
                    txtPrecoUni.Text = "";
                }
            }
            catch (Exception ex)
            {
                Console.Write("Debug: " + ex.ToString());
            }
        }

        private void frmLD_Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolVenda = false;
        }

        private void txtCodEquip_TextChanged(object sender, EventArgs e)
        {
            if(msktxtCodEquip.Text.Trim().Length >3)
            {
                try
                {
                    cmbEquips.SelectedValue = int.Parse(msktxtCodEquip.Text);
                }
                catch (Exception ex)
                {
                    Console.Write("Debug: " + ex.ToString());
                }
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dtgEquip.DataSource = null;
            LimpaControles();
            LimpaItens();
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidaControles())
            {
                VENDA oVenda = new VENDA();
                oVenda.CPFCliente = msktxtCPFCli.Text;
                oVenda.DataVenda = DateTime.Now;

                MessageBox.Show("Dados do cabeçalho da venda cadastrado com sucesso! \nAdicione itens a venda com o botão 'Adicionar'.");
                codigo = CVENDA.IncluirRetorna(oVenda);

                btnAdd.Enabled = true;
                btnCancel.Enabled = true;
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnDelete.Enabled = true;

                txtCodigo.Enabled = false;
                txtCodigo.Text = codigo.ToString();
            }
        }

        private void msktxtCPFCli_Leave(object sender, EventArgs e)
        {
            if(msktxtCPFCli.MaskCompleted)
            {
                if(CCLIENTE.SelecionaPK(msktxtCPFCli.Text)!= null)
                {
                    txtNomeCli.Text = CCLIENTE.SelecionaPK(msktxtCPFCli.Text).Nome;
                }
                else
                {
                    txtNomeCli.Text = "";
                }
            }
            else
            {
                txtNomeCli.Text = "";
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            int integerData;
           if(int.TryParse(txtCodigo.Text,out integerData))
           {
               msktxtCPFCli.Text = CVENDA.SelecionaPK(integerData).CPFCliente;
               dataAlterando = CVENDA.SelecionaPK(integerData).DataVenda.Value;
               codigo = int.Parse(txtCodigo.Text);
               //liberar Alterar, Excluir, Cancelar
               LimpaItens();
               btnNew.Enabled = true;
               btnSave.Enabled = false;
               btnCancel.Enabled = true;
               btnDelete.Enabled = true;
               btnUpdate.Enabled = true;
               btnAdd.Enabled = true;
               txtCodigo.Enabled = false;
               listaItens = CEQUIPAMENTO_VENDA_CONSULTA.SelecionaTodosCodigoVenda(int.Parse(txtCodigo.Text));
               CarregaGrid();
               CalculaTotal();
               //txtCodigo.Focus();
           }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(ValidaControlesItens())
            {
                EQUIPAMENTO oEquip = CEQUIPAMENTO.SelecionaPK((int)cmbEquips.SelectedValue);
                VW_EQUIPVENDA oEquipVenda = new VW_EQUIPVENDA();
                oEquipVenda.CodEquipamento = oEquip.CodEquipamento;
                oEquipVenda.Preco = oEquip.Preco;
                oEquipVenda.Quantidade = int.Parse(txtQtd.Text);
                oEquipVenda.PrecoTotal = oEquip.Preco * oEquipVenda.Quantidade;
                oEquipVenda.Nome = cmbEquips.Text;
                oEquipVenda.CodVenda = int.Parse(txtCodigo.Text);
               

                //
                EQUIPAMENTO_VENDA poEquip = new EQUIPAMENTO_VENDA();
                poEquip.CodEquipamento = oEquipVenda.CodEquipamento;
                poEquip.CodVenda = oEquipVenda.CodVenda;
                poEquip.Quantidade = oEquipVenda.Quantidade;
                //
                CEQUIPAMENTO_VENDA.Incluir(poEquip);
                MessageBox.Show("O item foi incluido com sucesso na venda!");
                listaItens.Add(oEquipVenda);
                CarregaGrid();
                CalculaTotal();

            }
        }

        private void CalculaTotal()
        {
            decimal ValorTotal = 0;
            foreach (VW_EQUIPVENDA item in listaItens)
            {
                ValorTotal += item.PrecoTotal.Value;
            }

            txtValorTotal.Text = ValorTotal.ToString();
        }

        //functions
        private void CarregaGrid()
        {
            dtgEquip.AutoGenerateColumns = false;
            dtgEquip.DataSource = null;
            dtgEquip.DataSource = listaItens;
        }

        private void msktxtCPFCli_TextChanged(object sender, EventArgs e)
        {
            if(msktxtCPFCli.MaskCompleted)
            {
                if (CCLIENTE.SelecionaPK(msktxtCPFCli.Text) != null)
                {
                    txtNomeCli.Text = CCLIENTE.SelecionaPK(msktxtCPFCli.Text).Nome;
                }
                else
                {
                    txtNomeCli.Text = "";
                }
            }
            else
            {
                txtNomeCli.Text = "";
            }
        }

        private void dtgEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgEquip.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgEquip.Columns[e.ColumnIndex].Name == "btnRemover")
                    {
                        if (MessageBox.Show("Deseja realmente excluir os dados desse Equipamento dessa Venda? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            VW_EQUIPVENDA poEquip = new VW_EQUIPVENDA();
                            poEquip = (VW_EQUIPVENDA)dtgEquip.Rows[e.RowIndex].DataBoundItem;
                            EQUIPAMENTO_VENDA oEquip = new EQUIPAMENTO_VENDA();
                            oEquip.CodVenda = poEquip.CodVenda;
                            oEquip.CodEquipamento = poEquip.CodEquipamento;
                            oEquip.Quantidade = poEquip.Quantidade;
                            CEQUIPAMENTO_VENDA.Excluir(oEquip);
                            //foreach (VW_SUPLEMENTO_PACOTE oSup in listaSuplementos)
                            //{
                            //    if (poSupp.CodSuplemento == oSup.CodSuplemento)
                            //    {
                            listaItens.Remove(poEquip);
                            dtgEquip.AutoGenerateColumns = false;
                            dtgEquip.DataSource = null;
                            dtgEquip.DataSource = listaItens;
                            //    }
                            //}
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                VENDA oVenda = new VENDA();
                oVenda.CPFCliente = msktxtCPFCli.Text;
                oVenda.DataVenda = dataAlterando;
                oVenda.CodVenda = codigo;

                MessageBox.Show("Dados do cabeçalho da venda alterados com sucesso");
                CVENDA.Alterar(oVenda);

                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
                txtCodigo.Text = codigo.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir os dados dessa Venda? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CVENDA.Excluir(CVENDA.SelecionaPK(int.Parse(txtCodigo.Text)));
                LimpaControles();
                LimpaItens();
                //
                btnNew.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                txtCodigo.Enabled = true;
                txtCodigo.Focus();
            }
        }


        //end
    }
}
