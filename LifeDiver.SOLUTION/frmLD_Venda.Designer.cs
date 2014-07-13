namespace LifeDiver.SOLUTION
{
    partial class frmLD_Venda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.msktxtCPFCli = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.groupEquip = new System.Windows.Forms.GroupBox();
            this.msktxtCodEquip = new System.Windows.Forms.MaskedTextBox();
            this.dtgEquip = new System.Windows.Forms.DataGridView();
            this.colCodEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cmbEquips = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtPrecoUni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.groupEquip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEquip)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNome.Size = new System.Drawing.Size(40, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(58, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // msktxtCPFCli
            // 
            this.msktxtCPFCli.Location = new System.Drawing.Point(263, 6);
            this.msktxtCPFCli.Mask = "###.###.###-##";
            this.msktxtCPFCli.Name = "msktxtCPFCli";
            this.msktxtCPFCli.Size = new System.Drawing.Size(100, 20);
            this.msktxtCPFCli.TabIndex = 21;
            this.msktxtCPFCli.TextChanged += new System.EventHandler(this.msktxtCPFCli_TextChanged);
            this.msktxtCPFCli.Leave += new System.EventHandler(this.msktxtCPFCli_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "CPF do Cliente";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(261, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 39);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(153, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 39);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(45, 32);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(102, 39);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(369, 32);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 39);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Alterar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(477, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 39);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtNomeCli.Location = new System.Drawing.Point(369, 6);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.ReadOnly = true;
            this.txtNomeCli.Size = new System.Drawing.Size(343, 20);
            this.txtNomeCli.TabIndex = 3;
            // 
            // groupEquip
            // 
            this.groupEquip.Controls.Add(this.msktxtCodEquip);
            this.groupEquip.Controls.Add(this.dtgEquip);
            this.groupEquip.Controls.Add(this.cmbEquips);
            this.groupEquip.Controls.Add(this.label3);
            this.groupEquip.Controls.Add(this.label6);
            this.groupEquip.Controls.Add(this.btnAdd);
            this.groupEquip.Controls.Add(this.txtQtd);
            this.groupEquip.Controls.Add(this.txtPrecoUni);
            this.groupEquip.Controls.Add(this.label4);
            this.groupEquip.Location = new System.Drawing.Point(12, 87);
            this.groupEquip.Name = "groupEquip";
            this.groupEquip.Size = new System.Drawing.Size(713, 371);
            this.groupEquip.TabIndex = 28;
            this.groupEquip.TabStop = false;
            this.groupEquip.Text = "Itens da Venda";
            // 
            // msktxtCodEquip
            // 
            this.msktxtCodEquip.Location = new System.Drawing.Point(94, 21);
            this.msktxtCodEquip.Mask = "####";
            this.msktxtCodEquip.Name = "msktxtCodEquip";
            this.msktxtCodEquip.Size = new System.Drawing.Size(41, 20);
            this.msktxtCodEquip.TabIndex = 23;
            this.msktxtCodEquip.TextChanged += new System.EventHandler(this.txtCodEquip_TextChanged);
            // 
            // dtgEquip
            // 
            this.dtgEquip.AllowUserToAddRows = false;
            this.dtgEquip.AllowUserToDeleteRows = false;
            this.dtgEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEquip.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodEquip,
            this.colNomeEquip,
            this.colQtd,
            this.colpreco,
            this.colprecoTotal,
            this.btnRemover});
            this.dtgEquip.Location = new System.Drawing.Point(33, 79);
            this.dtgEquip.Name = "dtgEquip";
            this.dtgEquip.RowHeadersWidth = 21;
            this.dtgEquip.Size = new System.Drawing.Size(667, 286);
            this.dtgEquip.TabIndex = 22;
            this.dtgEquip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEquip_CellClick);
            // 
            // colCodEquip
            // 
            this.colCodEquip.DataPropertyName = "CodEquipamento";
            this.colCodEquip.HeaderText = "Cod. Equipamento";
            this.colCodEquip.Name = "colCodEquip";
            this.colCodEquip.ReadOnly = true;
            this.colCodEquip.Width = 130;
            // 
            // colNomeEquip
            // 
            this.colNomeEquip.DataPropertyName = "Nome";
            this.colNomeEquip.HeaderText = "Nome Equipamento";
            this.colNomeEquip.Name = "colNomeEquip";
            this.colNomeEquip.ReadOnly = true;
            this.colNomeEquip.Width = 150;
            // 
            // colQtd
            // 
            this.colQtd.DataPropertyName = "Quantidade";
            this.colQtd.HeaderText = "Quantidade";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // colpreco
            // 
            this.colpreco.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colpreco.DefaultCellStyle = dataGridViewCellStyle1;
            this.colpreco.HeaderText = "Preço";
            this.colpreco.Name = "colpreco";
            this.colpreco.ReadOnly = true;
            // 
            // colprecoTotal
            // 
            this.colprecoTotal.DataPropertyName = "PrecoTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colprecoTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colprecoTotal.HeaderText = "Preço Total";
            this.colprecoTotal.Name = "colprecoTotal";
            this.colprecoTotal.ReadOnly = true;
            // 
            // btnRemover
            // 
            this.btnRemover.HeaderText = "Remover";
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Width = 60;
            // 
            // cmbEquips
            // 
            this.cmbEquips.FormattingEnabled = true;
            this.cmbEquips.Location = new System.Drawing.Point(141, 20);
            this.cmbEquips.Name = "cmbEquips";
            this.cmbEquips.Size = new System.Drawing.Size(333, 21);
            this.cmbEquips.TabIndex = 21;
            this.cmbEquips.SelectedIndexChanged += new System.EventHandler(this.cmbEquips_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 50);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 24);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Equipamento";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(576, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 47);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Salvar Item";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(274, 47);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(58, 20);
            this.txtQtd.TabIndex = 18;
            // 
            // txtPrecoUni
            // 
            this.txtPrecoUni.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPrecoUni.Location = new System.Drawing.Point(94, 47);
            this.txtPrecoUni.Name = "txtPrecoUni";
            this.txtPrecoUni.ReadOnly = true;
            this.txtPrecoUni.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoUni.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 50);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Preço Unidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 476);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Total da Venda";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorTotal.Location = new System.Drawing.Point(625, 473);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotal.TabIndex = 3;
            // 
            // frmLD_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 505);
            this.Controls.Add(this.groupEquip);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.msktxtCPFCli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblNome);
            this.Name = "frmLD_Venda";
            this.ShowIcon = false;
            this.Text = "Venda de Equipamentos de Mergulho";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLD_Venda_FormClosed);
            this.Load += new System.EventHandler(this.frmLD_Venda_Load);
            this.groupEquip.ResumeLayout(false);
            this.groupEquip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEquip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox msktxtCPFCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.GroupBox groupEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.DataGridView dtgEquip;
        private System.Windows.Forms.ComboBox cmbEquips;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtPrecoUni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox msktxtCodEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprecoTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnRemover;

    }
}