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
    public partial class frmLD_Suplemento : Form
    {
        public frmLD_Suplemento()
        {
            InitializeComponent();
        }

        //
        private bool Alterar = false;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidaControles())
            {
                SUPLEMENTO oSupp = new SUPLEMENTO();
                oSupp.Nome = txtNome.Text;
                oSupp.CodSuplemento = int.Parse(msktxtCod.Text.Trim());
                oSupp.QtdDisponivel = int.Parse(txtQtd.Text.Trim());
                oSupp.Tipo = cmbTipo.Text;
                if (!Alterar)
                {
                    CSUPLEMENTO.Incluir(oSupp);
                    MessageBox.Show("O Suplemento foi cadastrado com Sucesso!");
                    CarregaGrid();
                }
                else
                {
                    CSUPLEMENTO.Alterar(oSupp);
                    MessageBox.Show("O Suplemento foi alterado com Sucesso!");
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
                    dtgSupp.AutoGenerateColumns = false;
                    dtgSupp.DataSource = CSUPLEMENTO_CONSULTA.SelecionaTodosCodigo(txtConsulta.Text);
                }

                if (rdNome.Checked)
                {
                    dtgSupp.AutoGenerateColumns = false;
                    dtgSupp.DataSource = CSUPLEMENTO_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
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
                    dtgSupp.AutoGenerateColumns = false;
                    dtgSupp.DataSource = CSUPLEMENTO_CONSULTA.SelecionaTodosCodigo(txtConsulta.Text);
                }
            }
        }

        private void rdNome_CheckedChanged(object sender, EventArgs e)
        {
            if (txtConsulta.Text.Trim() != "")
            {
                if (rdNome.Checked)
                {
                    dtgSupp.AutoGenerateColumns = false;
                    dtgSupp.DataSource = CSUPLEMENTO_CONSULTA.SelecionaTodosNome(txtConsulta.Text);
                }
            }
        }

        //Functions
        private void CarregaGrid()
        {
            dtgSupp.AutoGenerateColumns = false;
            dtgSupp.DataSource = CSUPLEMENTO.SelecionaTodos();
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
            txtConsulta.Text = "";
        }

        private bool ValidaControles()
        {
            int integerData;
            if (msktxtCod.Text.Trim().Length != 4 || !int.TryParse(msktxtCod.Text.Trim(), out integerData))
            {
                MessageBox.Show("O Codigo do Suplemento não foi informado devidamente!");
                msktxtCod.Focus();
                return false;
            }
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("O Nome do Suplemento não foi informado!");
                txtNome.Focus();
                return false;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("O Tipo do Suplemento não foi informado!");
                cmbTipo.Focus();
                return false;
            }

            if (txtQtd.Text.Trim() == "" || int.TryParse(txtQtd.Text.Trim(), out integerData) == false)
            {
                MessageBox.Show("Não foi informado um valor válido no campo Quantidade!");
                txtQtd.Focus();
                return false;
            }
            foreach (SUPLEMENTO p in CSUPLEMENTO.SelecionaTodos())
            {
                if (p.CodSuplemento == int.Parse(msktxtCod.Text))
                {
                    MessageBox.Show("Este Código já está cadastrado!");
                    msktxtCod.Focus();
                    return false;
                }
            }
            return true;
        }

        private void dtgSupp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgSupp.Rows[e.RowIndex].DataBoundItem != null)
            {
                if (e.ColumnIndex > 0)
                {
                    if (dtgSupp.Columns[e.ColumnIndex].Name == "btnAlterar")
                    {
                        SUPLEMENTO oSupp = (SUPLEMENTO)dtgSupp.Rows[e.RowIndex].DataBoundItem;
                        msktxtCod.Text = oSupp.CodSuplemento.ToString();
                        txtNome.Text = oSupp.Nome;
                        txtQtd.Text = oSupp.QtdDisponivel.ToString();
                        cmbTipo.Text = oSupp.Tipo;
                        msktxtCod.Enabled = false;
                        Alterar = true;
                    }

                    if (dtgSupp.Columns[e.ColumnIndex].Name == "btnExcluir")
                    {
                        if (Alterar)
                        {
                            Alterar = false;
                            LimpaControles();
                        }  
                        if (MessageBox.Show("Deseja realmente excluir os dados desse Suplemento? Após a confirmação será impossível recuperar os dados.", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            SUPLEMENTO oSupp = (SUPLEMENTO)dtgSupp.Rows[e.RowIndex].DataBoundItem;
                            oSupp = CSUPLEMENTO.SelecionaPK(oSupp.CodSuplemento);
                            CSUPLEMENTO.Excluir(oSupp);
                            CarregaGrid();
                        }
                    }
                }
            }
        }

        private void frmLD_Suplemento_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void frmLD_Suplemento_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLD_Principal.boolSupp = false;
        }
    }
}
