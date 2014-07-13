namespace LifeDiver.SOLUTION
{
    partial class frmLD_Matricula
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
            this.lblCpfEncontrado = new System.Windows.Forms.Label();
            this.msktxtCPFCli = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.rdCodigo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.dtgCurso = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPFClientee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfInstrutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeropessoas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAlterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCpfEncontrado
            // 
            this.lblCpfEncontrado.AutoSize = true;
            this.lblCpfEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpfEncontrado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCpfEncontrado.Location = new System.Drawing.Point(201, 9);
            this.lblCpfEncontrado.Name = "lblCpfEncontrado";
            this.lblCpfEncontrado.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCpfEncontrado.Size = new System.Drawing.Size(0, 13);
            this.lblCpfEncontrado.TabIndex = 34;
            // 
            // msktxtCPFCli
            // 
            this.msktxtCPFCli.Location = new System.Drawing.Point(95, 6);
            this.msktxtCPFCli.Mask = "###.###.###-##";
            this.msktxtCPFCli.Name = "msktxtCPFCli";
            this.msktxtCPFCli.Size = new System.Drawing.Size(100, 20);
            this.msktxtCPFCli.TabIndex = 33;
            this.msktxtCPFCli.TextChanged += new System.EventHandler(this.msktxtCPFCli_TextChanged);
            this.msktxtCPFCli.Leave += new System.EventHandler(this.msktxtCPFCli_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "CPF do Cliente";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(95, 32);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(189, 21);
            this.cmbCurso.TabIndex = 35;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Curso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nome Turma";
            // 
            // rdCPFCli
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Location = new System.Drawing.Point(618, 30);
            this.rdNome.Name = "rdCPFCli";
            this.rdNome.Size = new System.Drawing.Size(88, 17);
            this.rdNome.TabIndex = 40;
            this.rdNome.Text = "Nome Cliente";
            this.rdNome.UseVisualStyleBackColor = true;
            this.rdNome.CheckedChanged += new System.EventHandler(this.rdNome_CheckedChanged);
            // 
            // rdCodigo
            // 
            this.rdCodigo.AutoSize = true;
            this.rdCodigo.Checked = true;
            this.rdCodigo.Location = new System.Drawing.Point(485, 30);
            this.rdCodigo.Name = "rdCodigo";
            this.rdCodigo.Size = new System.Drawing.Size(88, 17);
            this.rdCodigo.TabIndex = 39;
            this.rdCodigo.TabStop = true;
            this.rdCodigo.Text = "Código Curso";
            this.rdCodigo.UseVisualStyleBackColor = true;
            this.rdCodigo.CheckedChanged += new System.EventHandler(this.rdCodigo_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 9);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Pesquisar";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(480, 6);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(218, 20);
            this.txtConsulta.TabIndex = 38;
            this.txtConsulta.TextChanged += new System.EventHandler(this.txtConsulta_TextChanged);
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
            this.CPFClientee,
            this.cpfInstrutor,
            this.numeropessoas,
            this.btnAlterar,
            this.btnExcluir});
            this.dtgCurso.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgCurso.Location = new System.Drawing.Point(0, 132);
            this.dtgCurso.MultiSelect = false;
            this.dtgCurso.Name = "dtgCurso";
            this.dtgCurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgCurso.RowHeadersWidth = 20;
            this.dtgCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCurso.Size = new System.Drawing.Size(752, 231);
            this.dtgCurso.TabIndex = 43;
            this.dtgCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCurso_CellClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodCurso";
            this.Codigo.HeaderText = "Cod. Curso";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "CursoNome";
            this.Nome.HeaderText = "Nome Curso";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 160;
            // 
            // CPFClientee
            // 
            this.CPFClientee.DataPropertyName = "CPFCliente";
            this.CPFClientee.HeaderText = "CPF Cliente";
            this.CPFClientee.Name = "CPFClientee";
            this.CPFClientee.ReadOnly = true;
            this.CPFClientee.Width = 120;
            // 
            // cpfInstrutor
            // 
            this.cpfInstrutor.DataPropertyName = "CliNome";
            this.cpfInstrutor.HeaderText = "Cliente";
            this.cpfInstrutor.Name = "cpfInstrutor";
            this.cpfInstrutor.ReadOnly = true;
            this.cpfInstrutor.Width = 130;
            // 
            // numeropessoas
            // 
            this.numeropessoas.DataPropertyName = "Turma";
            this.numeropessoas.HeaderText = "Turma";
            this.numeropessoas.Name = "numeropessoas";
            this.numeropessoas.ReadOnly = true;
            this.numeropessoas.Width = 150;
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
            this.btnClear.Location = new System.Drawing.Point(163, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 34);
            this.btnClear.TabIndex = 42;
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
            this.btnSave.Location = new System.Drawing.Point(55, 86);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 34);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Items.AddRange(new object[] {
            "202",
            "203",
            "204"});
            this.cmbTurma.Location = new System.Drawing.Point(95, 59);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(189, 21);
            this.cmbTurma.TabIndex = 35;
            this.cmbTurma.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectedIndexChanged);
            // 
            // frmLD_Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 363);
            this.Controls.Add(this.dtgCurso);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdNome);
            this.Controls.Add(this.rdCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.lblCpfEncontrado);
            this.Controls.Add(this.msktxtCPFCli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmLD_Matricula";
            this.Text = "Matricular Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLD_Matricula_FormClosed);
            this.Load += new System.EventHandler(this.frmLD_Matricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCpfEncontrado;
        private System.Windows.Forms.MaskedTextBox msktxtCPFCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.RadioButton rdCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.DataGridView dtgCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPFClientee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfInstrutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeropessoas;
        private System.Windows.Forms.DataGridViewButtonColumn btnAlterar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExcluir;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbTurma;
    }
}