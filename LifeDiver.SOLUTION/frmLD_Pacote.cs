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
    public partial class frmLD_Pacote : Form
    {
        public frmLD_Pacote()
        {
            InitializeComponent();
        }

        //
        private bool Alterar = false;
        private int codigoAlterando = 0;
        //


        List<VW_SUPLEMENTO_PACOTE> listaSuplementos = new List<VW_SUPLEMENTO_PACOTE>();
        List<VW_SUPLEMENTO_PACOTE> listaAlterando = new List<VW_SUPLEMENTO_PACOTE>();

        private void frmLD_Pacote_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void frmLD_Pacote_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolPacote = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidaControles())
            {
                PACOTE oPack = new PACOTE();
                oPack.Nome = txtNome.Text;
                oPack.NumeroPessoasMax = int.Parse(txtQtdPessoas.Text.Trim());
                oPack.Preco = decimal.Parse(txtPreco.Text.Trim());
                oPack.Local = txtLocal.Text;
                if (!Alterar)
                {
                    int codigo;
                    codigo = CPACOTE.IncluirRetorna(oPack);
                    foreach(VW_SUPLEMENTO_PACOTE oSupp in listaSuplementos)
                    {
                        SUPLEMENTO_PACOTE poSupp = new SUPLEMENTO_PACOTE();
                        poSupp.CodPacote = codigo;
                        poSupp.CodSuplemento = oSupp.CodSuplemento;
                        poSupp.Quantidade = oSupp.Quantidade;
                        CSUPLEMENTO_PACOTE.Incluir(poSupp);
                    }                  
                    MessageBox.Show("O Pacote foi cadastrado com Sucesso!");
                    CarregaGrid();
                }
                else
                {
                    if(listaAlterando.Count > 0)
                    {
                        foreach (VW_SUPLEMENTO_PACOTE poSupp in listaAlterando)
                        {
                            if (poSupp != null) 
                            {
                                    CSUPLEMENTO_PACOTE.Excluir(CSUPLEMENTO_PACOTE.SelecionaPK(poSupp.CodSuplemento, poSupp.CodPacote));
                            }
                            
                        }
                    }
                   
                    foreach(VW_SUPLEMENTO_PACOTE oSupp in listaSuplementos)
                    {
                        SUPLEMENTO_PACOTE poSupp = new SUPLEMENTO_PACOTE();
                        poSupp.CodPacote = codigoAlterando;
                        poSupp.CodSuplemento = oSupp.CodSuplemento;
                        poSupp.Quantidade = oSupp.Quantidade;
                        CSUPLEMENTO_PACOTE.Incluir(poSupp);
                    }     
                    //
                    oPack.CodPacote = codigoAlterando;
                    CPACOTE.Alterar(oPack);
                    MessageBox.Show("O Pacote foi alterado com Sucesso!");
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

        private void dtgPack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPack.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgPack.Columns[e.ColumnIndex].Name == "btnAlterar")
                    {
                        LimpaControles();
                        PACOTE oPack = (PACOTE)dtgPack.Rows[e.RowIndex].DataBoundItem;
                        txtNome.Text = oPack.Nome;
                        txtQtdPessoas.Text = oPack.NumeroPessoasMax.ToString();
                        txtPreco.Text = oPack.Preco.ToString();
                        txtLocal.Text = oPack.Local;
                        
                        codigoAlterando = oPack.CodPacote;
                        Alterar = true;

                        listaSuplementos = CSUPLEMENTO_PACOTE_CONSULTA.SelecionaTodosCodigoPacote(codigoAlterando);
                        dtgSupp.AutoGenerateColumns = false;
                        dtgSupp.DataSource = null;
                        dtgSupp.DataSource = listaSuplementos;
                        listaAlterando = new List<VW_SUPLEMENTO_PACOTE>();
                        foreach(VW_SUPLEMENTO_PACOTE oS in listaSuplementos)
                        {
                            listaAlterando.Add(oS);
                        }
                        
                    }

                    if (dtgPack.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        if (Alterar)
                        {
                            Alterar = false;
                            LimpaControles();
                        }  
                        if (MessageBox.Show("Deseja realmente excluir os dados desse Pacote? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            PACOTE oPack = (PACOTE)dtgPack.Rows[e.RowIndex].DataBoundItem;
                            oPack = CPACOTE.SelecionaPK(oPack.CodPacote);
                            CPACOTE.Excluir(oPack);
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
                if (rdCodigo.Checked)
                {
                    dtgPack.AutoGenerateColumns = false;
                    dtgPack.DataSource = CPACOTE_CONSULTA.SelecionaTodosCodigo(txtConsulta.Text);
                }

                if (rdNome.Checked)
                {
                    dtgPack.AutoGenerateColumns = false;
                    dtgPack.DataSource = CPACOTE_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
            else
                CarregaGrid();
        }

        //functions
        private void CarregaGrid()
        {
            dtgPack.AutoGenerateColumns = false;
            dtgPack.DataSource = CPACOTE.SelecionaTodos();
            //
            cmbSuplementos.DataSource = null;
            cmbSuplementos.DataSource = CSUPLEMENTO.SelecionaTodos();
            cmbSuplementos.DisplayMember = "Nome";
            cmbSuplementos.ValueMember = "CodSuplemento";
            cmbSuplementos.SelectedIndex = -1;
            listaAlterando = new List<VW_SUPLEMENTO_PACOTE>();
            listaSuplementos = new List<VW_SUPLEMENTO_PACOTE>();
            dtgSupp.DataSource = null;
            txtQtdSupp.Text = "";
        }

        private void LimpaControles()
        {
            if (codigoAlterando != 0)
                codigoAlterando = 0;
            if (Alterar)
                Alterar = false;
            txtNome.Text = "";
            txtLocal.Text = "";
            txtQtdPessoas.Text = "";
            txtPreco.Text = "";
            txtConsulta.Text = "";
            cmbSuplementos.SelectedIndex = -1;
            dtgSupp.DataSource = null;
            listaSuplementos.Clear();
        }

        private bool ValidaControles()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Nome do Pacote não foi informado!");
                txtNome.Focus();
                return false;
            }
            if (txtLocal.Text.Trim() == "")
            {
                MessageBox.Show("O Local de Mergulho do Pacote não foi informado!");
                txtLocal.Focus();
                return false;
            }

            int integerData;
            if (txtQtdPessoas.Text.Trim() == "" || int.TryParse(txtQtdPessoas.Text.Trim(), out integerData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo de Número máximo de Pessoas Permitido!");
                txtQtdPessoas.Focus();
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

        private void rdCodigo_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdCodigo.Checked)
                {
                    dtgPack.AutoGenerateColumns = false;
                    dtgPack.DataSource = CPACOTE_CONSULTA.SelecionaTodosCodigo(txtConsulta.Text);
                }
            }
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdNome.Checked)
                {
                    dtgPack.AutoGenerateColumns = false;
                    dtgPack.DataSource = CPACOTE_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int integerData;
            if (cmbSuplementos.SelectedIndex > -1)
            {
                if (txtQtdSupp.Text.Trim() != "" && int.TryParse(txtQtdSupp.Text, out integerData))
                {
                    bool listado = false;
                        foreach(VW_SUPLEMENTO_PACOTE oSupp in listaSuplementos)
                        {
                            if (oSupp.CodSuplemento == (int)cmbSuplementos.SelectedValue)
                            {
                                MessageBox.Show("Esse suplemento já foi inserido na lista");
                                cmbSuplementos.Focus();
                                listado = true;
                            }
                        }
                        if (!listado)
                        {
                            VW_SUPLEMENTO_PACOTE poSupp = new VW_SUPLEMENTO_PACOTE();
                            poSupp.CodSuplemento = (int)cmbSuplementos.SelectedValue;
                            poSupp.Nome = CSUPLEMENTO.SelecionaPK((int)cmbSuplementos.SelectedValue).Nome;
                            poSupp.Quantidade = int.Parse(txtQtdSupp.Text);
                            listaSuplementos.Add(poSupp);
                            dtgSupp.AutoGenerateColumns = false;
                            dtgSupp.DataSource = null;
                            dtgSupp.DataSource = listaSuplementos;
                        }
                    


                }
                else
                {
                    MessageBox.Show("Não foi informado um valor válido no campo Quantidade!");
                    txtQtdSupp.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nenhum suplemento foi selecionado!");
                cmbSuplementos.Focus();
            }

            
        }

        private void dtgSupp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgSupp.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgSupp.Columns[e.ColumnIndex].Name == "btnRemover")
                    {
                        VW_SUPLEMENTO_PACOTE poSupp = new VW_SUPLEMENTO_PACOTE();
                        poSupp = (VW_SUPLEMENTO_PACOTE)dtgSupp.Rows[e.RowIndex].DataBoundItem;
                        //foreach (VW_SUPLEMENTO_PACOTE oSup in listaSuplementos)
                        //{
                        //    if (poSupp.CodSuplemento == oSup.CodSuplemento)
                        //    {
                                listaSuplementos.Remove(poSupp);
                                dtgSupp.AutoGenerateColumns = false;
                                dtgSupp.DataSource = null;
                                dtgSupp.DataSource = listaSuplementos;
                        //    }
                        //}
                    }
                }
            }
        }



        //end
    }
}
