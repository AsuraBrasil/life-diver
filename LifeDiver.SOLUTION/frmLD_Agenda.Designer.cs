namespace LifeDiver.SOLUTION
{
    partial class frmLD_Agenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msktxtCPFCli = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgAgenda = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfInstrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdPessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdPessoasSem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAgenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQtdPessoas = new System.Windows.Forms.TextBox();
            this.txtQtdPessoasSem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPacote = new System.Windows.Forms.ComboBox();
            this.lblQtdMaximo = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQtdMaxSemEquip = new System.Windows.Forms.Label();
            this.dtPickerPesquisa = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.dtPickerAgendada = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCpfEncontrado = new System.Windows.Forms.Label();
            this.btnRestaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // msktxtCPFCli
            // 
            this.msktxtCPFCli.Location = new System.Drawing.Point(136, 35);
            this.msktxtCPFCli.Mask = "###.###.###-##";
            this.msktxtCPFCli.Name = "msktxtCPFCli";
            this.msktxtCPFCli.Size = new System.Drawing.Size(100, 20);
            this.msktxtCPFCli.TabIndex = 19;
            this.msktxtCPFCli.Leave += new System.EventHandler(this.msktxtCPFCli_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 38);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "CPF do Cliente";
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.AllowUserToAddRows = false;
            this.dtgAgenda.AllowUserToDeleteRows = false;
            this.dtgAgenda.AllowUserToResizeColumns = false;
            this.dtgAgenda.AllowUserToResizeRows = false;
            this.dtgAgenda.ColumnHeadersHeight = 20;
            this.dtgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.cpfInstrutor,
            this.QtdEquip,
            this.Preco,
            this.qtdPessoas,
            this.qtdPessoasSem,
            this.PrecoTotal,
            this.dateRegistro,
            this.dateAgenda,
            this.btnAlterar,
            this.btnExcluir});
            this.dtgAgenda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgAgenda.Location = new System.Drawing.Point(0, 176);
            this.dtgAgenda.MultiSelect = false;
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgAgenda.RowHeadersWidth = 20;
            this.dtgAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAgenda.Size = new System.Drawing.Size(1222, 231);
            this.dtgAgenda.TabIndex = 30;
            this.dtgAgenda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAgenda_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodAgendamento";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 50;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "CPFCliente";
            this.Nome.HeaderText = "CPF Cliente";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // cpfInstrutor
            // 
            this.cpfInstrutor.DataPropertyName = "CliNome";
            this.cpfInstrutor.HeaderText = "Cliente";
            this.cpfInstrutor.Name = "cpfInstrutor";
            this.cpfInstrutor.ReadOnly = true;
            this.cpfInstrutor.Width = 130;
            // 
            // QtdEquip
            // 
            this.QtdEquip.DataPropertyName = "PacNome";
            this.QtdEquip.HeaderText = "Pacote";
            this.QtdEquip.Name = "QtdEquip";
            this.QtdEquip.ReadOnly = true;
            this.QtdEquip.Width = 130;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle1;
            this.Preco.HeaderText = "Preço do Pacote";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 120;
            // 
            // qtdPessoas
            // 
            this.qtdPessoas.DataPropertyName = "QtdPessoas";
            this.qtdPessoas.HeaderText = "Qtd. Pessoas";
            this.qtdPessoas.Name = "qtdPessoas";
            this.qtdPessoas.ReadOnly = true;
            // 
            // qtdPessoasSem
            // 
            this.qtdPessoasSem.DataPropertyName = "QtdPessoasSemEquipamento";
            this.qtdPessoasSem.HeaderText = "Qtd. Pessoas sem Equipamentos";
            this.qtdPessoasSem.Name = "qtdPessoasSem";
            this.qtdPessoasSem.ReadOnly = true;
            this.qtdPessoasSem.Width = 170;
            // 
            // PrecoTotal
            // 
            this.PrecoTotal.DataPropertyName = "agendaPrecoTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.PrecoTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecoTotal.HeaderText = "Valor Total";
            this.PrecoTotal.Name = "PrecoTotal";
            this.PrecoTotal.ReadOnly = true;
            // 
            // dateRegistro
            // 
            this.dateRegistro.DataPropertyName = "DateRegistro";
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.dateRegistro.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateRegistro.HeaderText = "Data de Registro";
            this.dateRegistro.Name = "dateRegistro";
            this.dateRegistro.ReadOnly = true;
            // 
            // dateAgenda
            // 
            this.dateAgenda.DataPropertyName = "DataAgendada";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dateAgenda.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateAgenda.HeaderText = "Data Agendada";
            this.dateAgenda.Name = "dateAgenda";
            this.dateAgenda.ReadOnly = true;
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
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(171, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 34);
            this.btnClear.TabIndex = 25;
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
            this.btnSave.Location = new System.Drawing.Point(63, 136);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 34);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 65);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Preço do Pacote";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantidade de Pessoas";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtPreco.Location = new System.Drawing.Point(458, 62);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(80, 20);
            this.txtPreco.TabIndex = 23;
            this.txtPreco.Text = "0";
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // txtQtdPessoas
            // 
            this.txtQtdPessoas.Location = new System.Drawing.Point(136, 62);
            this.txtQtdPessoas.Name = "txtQtdPessoas";
            this.txtQtdPessoas.Size = new System.Drawing.Size(80, 20);
            this.txtQtdPessoas.TabIndex = 21;
            this.txtQtdPessoas.Text = "0";
            this.txtQtdPessoas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtdPessoas.TextChanged += new System.EventHandler(this.txtQtdPessoas_TextChanged);
            this.txtQtdPessoas.Leave += new System.EventHandler(this.txtQtdPessoas_Leave);
            // 
            // txtQtdPessoasSem
            // 
            this.txtQtdPessoasSem.Location = new System.Drawing.Point(136, 91);
            this.txtQtdPessoasSem.Name = "txtQtdPessoasSem";
            this.txtQtdPessoasSem.Size = new System.Drawing.Size(80, 20);
            this.txtQtdPessoasSem.TabIndex = 21;
            this.txtQtdPessoasSem.Text = "0";
            this.txtQtdPessoasSem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtdPessoasSem.TextChanged += new System.EventHandler(this.txtQtdPessoasSem_TextChanged);
            this.txtQtdPessoasSem.Leave += new System.EventHandler(this.txtQtdPessoasSem_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 94);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Qtd. sem Equipamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(411, 14);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Pacote";
            // 
            // cmbPacote
            // 
            this.cmbPacote.FormattingEnabled = true;
            this.cmbPacote.Location = new System.Drawing.Point(458, 11);
            this.cmbPacote.Name = "cmbPacote";
            this.cmbPacote.Size = new System.Drawing.Size(185, 21);
            this.cmbPacote.TabIndex = 32;
            this.cmbPacote.SelectedIndexChanged += new System.EventHandler(this.cmbPacote_SelectedIndexChanged);
            this.cmbPacote.TextChanged += new System.EventHandler(this.cmbPacote_TextChanged);
            // 
            // lblQtdMaximo
            // 
            this.lblQtdMaximo.AutoSize = true;
            this.lblQtdMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMaximo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblQtdMaximo.Location = new System.Drawing.Point(223, 66);
            this.lblQtdMaximo.Name = "lblQtdMaximo";
            this.lblQtdMaximo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQtdMaximo.Size = new System.Drawing.Size(0, 13);
            this.lblQtdMaximo.TabIndex = 31;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtValorTotal.Location = new System.Drawing.Point(458, 91);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(80, 20);
            this.txtValorTotal.TabIndex = 23;
            this.txtValorTotal.Text = "0";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 94);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Valor Total";
            // 
            // lblQtdMaxSemEquip
            // 
            this.lblQtdMaxSemEquip.AutoSize = true;
            this.lblQtdMaxSemEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMaxSemEquip.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblQtdMaxSemEquip.Location = new System.Drawing.Point(223, 95);
            this.lblQtdMaxSemEquip.Name = "lblQtdMaxSemEquip";
            this.lblQtdMaxSemEquip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQtdMaxSemEquip.Size = new System.Drawing.Size(0, 13);
            this.lblQtdMaxSemEquip.TabIndex = 33;
            // 
            // dtPickerPesquisa
            // 
            this.dtPickerPesquisa.Location = new System.Drawing.Point(905, 7);
            this.dtPickerPesquisa.MinDate = new System.DateTime(2014, 6, 30, 0, 0, 0, 0);
            this.dtPickerPesquisa.Name = "dtPickerPesquisa";
            this.dtPickerPesquisa.Size = new System.Drawing.Size(270, 20);
            this.dtPickerPesquisa.TabIndex = 34;
            this.dtPickerPesquisa.Value = new System.DateTime(2014, 6, 30, 0, 0, 0, 0);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisa.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPesquisa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnPesquisa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisa.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(905, 35);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(124, 28);
            this.btnPesquisa.TabIndex = 24;
            this.btnPesquisa.Text = "Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = false;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // dtPickerAgendada
            // 
            this.dtPickerAgendada.Location = new System.Drawing.Point(136, 8);
            this.dtPickerAgendada.MinDate = new System.DateTime(2014, 6, 30, 0, 0, 0, 0);
            this.dtPickerAgendada.Name = "dtPickerAgendada";
            this.dtPickerAgendada.Size = new System.Drawing.Size(240, 20);
            this.dtPickerAgendada.TabIndex = 34;
            this.dtPickerAgendada.Value = new System.DateTime(2014, 6, 30, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 13);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Data Agendada";
            // 
            // lblCpfEncontrado
            // 
            this.lblCpfEncontrado.AutoSize = true;
            this.lblCpfEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfEncontrado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCpfEncontrado.Location = new System.Drawing.Point(242, 38);
            this.lblCpfEncontrado.Name = "lblCpfEncontrado";
            this.lblCpfEncontrado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCpfEncontrado.Size = new System.Drawing.Size(0, 13);
            this.lblCpfEncontrado.TabIndex = 31;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(1051, 35);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(124, 28);
            this.btnRestaurar.TabIndex = 35;
            this.btnRestaurar.Text = "Restaurar Valores";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // frmLD_Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 407);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.dtPickerAgendada);
            this.Controls.Add(this.dtPickerPesquisa);
            this.Controls.Add(this.lblQtdMaxSemEquip);
            this.Controls.Add(this.cmbPacote);
            this.Controls.Add(this.lblCpfEncontrado);
            this.Controls.Add(this.lblQtdMaximo);
            this.Controls.Add(this.msktxtCPFCli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgAgenda);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtQtdPessoasSem);
            this.Controls.Add(this.txtQtdPessoas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLD_Agenda";
            this.Text = "Agendamento de Mergulho";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLD_Agenda_FormClosed);
            this.Load += new System.EventHandler(this.frmLD_Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msktxtCPFCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgAgenda;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQtdPessoas;
        private System.Windows.Forms.TextBox txtQtdPessoasSem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPacote;
        private System.Windows.Forms.Label lblQtdMaximo;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdMaxSemEquip;
        private System.Windows.Forms.DateTimePicker dtPickerPesquisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DateTimePicker dtPickerAgendada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCpfEncontrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfInstrutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdPessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdPessoasSem;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAgenda;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
        private System.Windows.Forms.Button btnRestaurar;
    }
}