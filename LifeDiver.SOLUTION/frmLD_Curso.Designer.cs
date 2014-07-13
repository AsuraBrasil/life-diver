namespace LifeDiver.SOLUTION
{
    partial class frmLD_Curso
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
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.rdCodigo = new System.Windows.Forms.RadioButton();
            this.dtgCurso = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.msktxtCPFInstru = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCpfEncontrado = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfInstrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeropessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTurma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // rdNome
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Location = new System.Drawing.Point(709, 30);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(53, 17);
            this.rdNome.TabIndex = 13;
            this.rdNome.Text = "Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            this.rdNome.CheckedChanged += new System.EventHandler(this.rdNome_CheckedChanged);
            // 
            // rdCodigo
            // 
            this.rdCodigo.AutoSize = true;
            this.rdCodigo.Checked = true;
            this.rdCodigo.Location = new System.Drawing.Point(576, 30);
            this.rdCodigo.Name = "rdCodigo";
            this.rdCodigo.Size = new System.Drawing.Size(58, 17);
            this.rdCodigo.TabIndex = 12;
            this.rdCodigo.TabStop = true;
            this.rdCodigo.Text = "Código";
            this.rdCodigo.UseVisualStyleBackColor = true;
            this.rdCodigo.CheckedChanged += new System.EventHandler(this.rdCodigo_CheckedChanged);
            // 
            // dtgCurso
            // 
            this.dtgCurso.AllowUserToAddRows = false;
            this.dtgCurso.AllowUserToDeleteRows = false;
            this.dtgCurso.AllowUserToResizeColumns = false;
            this.dtgCurso.AllowUserToResizeRows = false;
            this.dtgCurso.ColumnHeadersHeight = 20;
            this.dtgCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.cpfInstrutor,
            this.numeropessoas,
            this.QtdEquip,
            this.Preco,
            this.btnAlterar,
            this.btnExcluir});
            this.dtgCurso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgCurso.Location = new System.Drawing.Point(0, 182);
            this.dtgCurso.MultiSelect = false;
            this.dtgCurso.Name = "dtgCurso";
            this.dtgCurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgCurso.RowHeadersWidth = 20;
            this.dtgCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCurso.Size = new System.Drawing.Size(813, 231);
            this.dtgCurso.TabIndex = 14;
            this.dtgCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCurso_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(155, 136);
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
            this.btnSave.Location = new System.Drawing.Point(47, 136);
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
            this.label4.Location = new System.Drawing.Point(74, 113);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 87);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pesquisar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(115, 110);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(80, 20);
            this.txtPreco.TabIndex = 7;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(115, 84);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(41, 20);
            this.txtHoras.TabIndex = 5;
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(571, 6);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(218, 20);
            this.txtConsulta.TabIndex = 11;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 6);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(204, 20);
            this.txtNome.TabIndex = 1;
            // 
            // msktxtCPFInstru
            // 
            this.msktxtCPFInstru.Location = new System.Drawing.Point(115, 32);
            this.msktxtCPFInstru.Mask = "###.###.###-##";
            this.msktxtCPFInstru.Name = "msktxtCPFInstru";
            this.msktxtCPFInstru.Size = new System.Drawing.Size(100, 20);
            this.msktxtCPFInstru.TabIndex = 3;
            this.msktxtCPFInstru.TextChanged += new System.EventHandler(this.msktxtCPFInstru_TextChanged);
            this.msktxtCPFInstru.Leave += new System.EventHandler(this.msktxtCPFInstru_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPF do Instrutor";
            // 
            // lblCpfEncontrado
            // 
            this.lblCpfEncontrado.AutoSize = true;
            this.lblCpfEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfEncontrado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCpfEncontrado.Location = new System.Drawing.Point(221, 35);
            this.lblCpfEncontrado.Name = "lblCpfEncontrado";
            this.lblCpfEncontrado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCpfEncontrado.Size = new System.Drawing.Size(0, 13);
            this.lblCpfEncontrado.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodCurso";
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
            this.cpfInstrutor.DataPropertyName = "InstruNome";
            this.cpfInstrutor.HeaderText = "Instrutor";
            this.cpfInstrutor.Name = "cpfInstrutor";
            this.cpfInstrutor.ReadOnly = true;
            this.cpfInstrutor.Width = 130;
            // 
            // numeropessoas
            // 
            this.numeropessoas.DataPropertyName = "NumeroPessoasTurma";
            this.numeropessoas.HeaderText = "Pessoas Por Turma";
            this.numeropessoas.Name = "numeropessoas";
            this.numeropessoas.ReadOnly = true;
            this.numeropessoas.Width = 150;
            // 
            // QtdEquip
            // 
            this.QtdEquip.DataPropertyName = "Horas";
            this.QtdEquip.HeaderText = "Horas";
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
            this.Preco.Width = 90;
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
            // txtTurma
            // 
            this.txtTurma.Location = new System.Drawing.Point(115, 58);
            this.txtTurma.Name = "txtTurma";
            this.txtTurma.Size = new System.Drawing.Size(41, 20);
            this.txtTurma.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 61);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pessoas por Turma";
            // 
            // frmLD_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 413);
            this.Controls.Add(this.lblCpfEncontrado);
            this.Controls.Add(this.msktxtCPFInstru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdNome);
            this.Controls.Add(this.rdCodigo);
            this.Controls.Add(this.dtgCurso);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtTurma);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLD_Curso";
            this.Text = "Gerenciamento de Cursos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLD_Curso_FormClosed);
            this.Load += new System.EventHandler(this.frmLD_Curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.RadioButton rdCodigo;
        private System.Windows.Forms.DataGridView dtgCurso;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox msktxtCPFInstru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCpfEncontrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfInstrutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeropessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
        private System.Windows.Forms.TextBox txtTurma;
        private System.Windows.Forms.Label label6;

    }
}