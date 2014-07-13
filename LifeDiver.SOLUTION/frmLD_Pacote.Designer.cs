namespace LifeDiver.SOLUTION
{
    partial class frmLD_Pacote
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
            this.label2 = new System.Windows.Forms.Label();
            this.rdCodigo = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtdPessoas = new System.Windows.Forms.TextBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dtgPack = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfInstrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSuplementos = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgSupp = new System.Windows.Forms.DataGridView();
            this.NomeSupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdSupp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtQtdSupp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 36);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Local do Mergulho";
            // 
            // rdCodigo
            // 
            this.rdCodigo.AutoSize = true;
            this.rdCodigo.Checked = true;
            this.rdCodigo.Location = new System.Drawing.Point(548, 31);
            this.rdCodigo.Name = "rdCodigo";
            this.rdCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdCodigo.TabIndex = 12;
            this.rdCodigo.TabStop = true;
            this.rdCodigo.Text = "Código";
            this.rdCodigo.UseVisualStyleBackColor = true;
            this.rdCodigo.CheckedChanged += new System.EventHandler(this.rdCodigo_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(160, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 34);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(52, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 34);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 88);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço por Pessoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 62);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº Pessoas Máximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 10);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 10);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(130, 85);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(80, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // txtQtdPessoas
            // 
            this.txtQtdPessoas.Location = new System.Drawing.Point(130, 59);
            this.txtQtdPessoas.Name = "txtQtdPessoas";
            this.txtQtdPessoas.Size = new System.Drawing.Size(41, 20);
            this.txtQtdPessoas.TabIndex = 5;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(543, 7);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(218, 20);
            this.txtConsulta.TabIndex = 11;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(130, 7);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 20);
            this.txtNome.TabIndex = 1;
            // 
            // dtgPack
            // 
            this.dtgPack.AllowUserToAddRows = false;
            this.dtgPack.AllowUserToDeleteRows = false;
            this.dtgPack.AllowUserToResizeRows = false;
            this.dtgPack.ColumnHeadersHeight = 20;
            this.dtgPack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.cpfInstrutor,
            this.QtdEquip,
            this.Preco,
            this.btnAlterar,
            this.btnExcluir});
            this.dtgPack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPack.Location = new System.Drawing.Point(0, 296);
            this.dtgPack.MultiSelect = false;
            this.dtgPack.Name = "dtgPack";
            this.dtgPack.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgPack.RowHeadersWidth = 20;
            this.dtgPack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPack.Size = new System.Drawing.Size(773, 231);
            this.dtgPack.TabIndex = 14;
            this.dtgPack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPack_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodPacote";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 160;
            // 
            // cpfInstrutor
            // 
            this.cpfInstrutor.DataPropertyName = "Local";
            this.cpfInstrutor.HeaderText = "Local";
            this.cpfInstrutor.Name = "cpfInstrutor";
            this.cpfInstrutor.ReadOnly = true;
            this.cpfInstrutor.Width = 180;
            // 
            // QtdEquip
            // 
            this.QtdEquip.DataPropertyName = "NumeroPessoasMax";
            this.QtdEquip.HeaderText = "Número Pessoas";
            this.QtdEquip.Name = "QtdEquip";
            this.QtdEquip.ReadOnly = true;
            this.QtdEquip.Width = 90;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle1;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 150;
            // 
            // btnAlterar
            // 
            this.btnAlterar.HeaderText = "Alterar";
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Width = 50;
            // 
            // btnExcluir
            // 
            this.btnExcluir.HeaderText = "Excluir";
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Width = 50;
            // 
            // rdNome
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Location = new System.Drawing.Point(695, 31);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(53, 17);
            this.rdNome.TabIndex = 13;
            this.rdNome.Text = "Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            this.rdNome.CheckedChanged += new System.EventHandler(this.rdNome_CheckedChanged);
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(130, 33);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(204, 20);
            this.txtLocal.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 114);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(116, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Suplementos Utilizados";
            // 
            // cmbSuplementos
            // 
            this.cmbSuplementos.FormattingEnabled = true;
            this.cmbSuplementos.Location = new System.Drawing.Point(132, 111);
            this.cmbSuplementos.Name = "cmbSuplementos";
            this.cmbSuplementos.Size = new System.Drawing.Size(202, 21);
            this.cmbSuplementos.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(389, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 21);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgSupp
            // 
            this.dtgSupp.AllowUserToAddRows = false;
            this.dtgSupp.AllowUserToDeleteRows = false;
            this.dtgSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSupp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeSupp,
            this.QtdSupp,
            this.btnRemover});
            this.dtgSupp.Location = new System.Drawing.Point(130, 138);
            this.dtgSupp.Name = "dtgSupp";
            this.dtgSupp.RowHeadersWidth = 21;
            this.dtgSupp.Size = new System.Drawing.Size(383, 112);
            this.dtgSupp.TabIndex = 17;
            this.dtgSupp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSupp_CellClick);
            // 
            // NomeSupp
            // 
            this.NomeSupp.DataPropertyName = "Nome";
            this.NomeSupp.HeaderText = "Nome";
            this.NomeSupp.Name = "NomeSupp";
            this.NomeSupp.ReadOnly = true;
            this.NomeSupp.Width = 200;
            // 
            // QtdSupp
            // 
            this.QtdSupp.DataPropertyName = "Quantidade";
            this.QtdSupp.HeaderText = "Quantidade";
            this.QtdSupp.Name = "QtdSupp";
            this.QtdSupp.ReadOnly = true;
            // 
            // btnRemover
            // 
            this.btnRemover.HeaderText = "Remover";
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Width = 60;
            // 
            // txtQtdSupp
            // 
            this.txtQtdSupp.Location = new System.Drawing.Point(340, 111);
            this.txtQtdSupp.Name = "txtQtdSupp";
            this.txtQtdSupp.Size = new System.Drawing.Size(41, 20);
            this.txtQtdSupp.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 95);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Qtd.";
            // 
            // frmLD_Pacote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 527);
            this.Controls.Add(this.dtgSupp);
            this.Controls.Add(this.cmbSuplementos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdNome);
            this.Controls.Add(this.dtgPack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdCodigo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQtdSupp);
            this.Controls.Add(this.txtQtdPessoas);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLD_Pacote";
            this.Text = "Gerenciamento de Pacote de Mergulho";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLD_Pacote_FormClosed);
            this.Load += new System.EventHandler(this.frmLD_Pacote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSupp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdCodigo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtdPessoas;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dtgPack;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfInstrutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSuplementos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgSupp;
        private System.Windows.Forms.TextBox txtQtdSupp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSupp;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdSupp;
        private System.Windows.Forms.DataGridViewButtonColumn btnRemover;
    }
}