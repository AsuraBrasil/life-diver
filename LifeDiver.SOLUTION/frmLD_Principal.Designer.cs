namespace LifeDiver.SOLUTION
{
    partial class frmLD_Principal
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
            this.components = new System.ComponentModel.Container();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.stLbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stLblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.painelcontrol = new System.Windows.Forms.Panel();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnVenda = new System.Windows.Forms.Button();
            this.btnCli = new System.Windows.Forms.Button();
            this.btnMatri = new System.Windows.Forms.Button();
            this.btnPack = new System.Windows.Forms.Button();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnInstru = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnCurso = new System.Windows.Forms.Button();
            this.btnEquip = new System.Windows.Forms.Button();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.statusBar.SuspendLayout();
            this.painelcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stLbl1,
            this.stLblDate});
            this.statusBar.Location = new System.Drawing.Point(0, 758);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1264, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // stLbl1
            // 
            this.stLbl1.Name = "stLbl1";
            this.stLbl1.Size = new System.Drawing.Size(265, 17);
            this.stLbl1.Text = "Life Diver - Sua Operadora de Mergulho Turístico";
            // 
            // stLblDate
            // 
            this.stLblDate.Margin = new System.Windows.Forms.Padding(970, 3, 0, 2);
            this.stLblDate.Name = "stLblDate";
            this.stLblDate.Size = new System.Drawing.Size(0, 17);
            // 
            // painelcontrol
            // 
            this.painelcontrol.AutoSize = true;
            this.painelcontrol.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.painelcontrol.Controls.Add(this.picTitulo);
            this.painelcontrol.Controls.Add(this.picLogo);
            this.painelcontrol.Controls.Add(this.btnClose);
            this.painelcontrol.Controls.Add(this.btnMaximize);
            this.painelcontrol.Controls.Add(this.btnMinimize);
            this.painelcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelcontrol.Location = new System.Drawing.Point(0, 0);
            this.painelcontrol.Name = "painelcontrol";
            this.painelcontrol.Size = new System.Drawing.Size(1264, 61);
            this.painelcontrol.TabIndex = 1;
            // 
            // picTitulo
            // 
            this.picTitulo.BackgroundImage = global::LifeDiver.SOLUTION.Properties.Resources.life_diver_logo;
            this.picTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picTitulo.Location = new System.Drawing.Point(111, 3);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(500, 55);
            this.picTitulo.TabIndex = 5;
            this.picTitulo.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = global::LifeDiver.SOLUTION.Properties.Resources.scuba1;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Location = new System.Drawing.Point(3, 3);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(102, 53);
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::LifeDiver.SOLUTION.Properties.Resources.LD_close1;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.Location = new System.Drawing.Point(1210, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_maximize;
            this.btnMaximize.Location = new System.Drawing.Point(1169, 5);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(40, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_minimize2;
            this.btnMinimize.Location = new System.Drawing.Point(1128, 5);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMenu.Controls.Add(this.btnVenda);
            this.panelMenu.Controls.Add(this.btnCli);
            this.panelMenu.Controls.Add(this.btnMatri);
            this.panelMenu.Controls.Add(this.btnPack);
            this.panelMenu.Controls.Add(this.btnAgendamento);
            this.panelMenu.Controls.Add(this.btnInstru);
            this.panelMenu.Controls.Add(this.btnSupp);
            this.panelMenu.Controls.Add(this.btnCurso);
            this.panelMenu.Controls.Add(this.btnEquip);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 61);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(114, 697);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVenda.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnVenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btnVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVenda.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonShop;
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenda.Location = new System.Drawing.Point(-3, 543);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(120, 70);
            this.btnVenda.TabIndex = 8;
            this.btnVenda.Text = "Realizar Venda";
            this.btnVenda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // btnCli
            // 
            this.btnCli.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCli.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCli.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCli.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonCli1;
            this.btnCli.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCli.Location = new System.Drawing.Point(-4, 0);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(120, 70);
            this.btnCli.TabIndex = 1;
            this.btnCli.Text = "Clientes";
            this.btnCli.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCli.UseVisualStyleBackColor = false;
            this.btnCli.Click += new System.EventHandler(this.btnCli_Click);
            // 
            // btnMatri
            // 
            this.btnMatri.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMatri.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMatri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnMatri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btnMatri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatri.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMatri.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonMatricular;
            this.btnMatri.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMatri.Location = new System.Drawing.Point(-4, 475);
            this.btnMatri.Name = "btnMatri";
            this.btnMatri.Size = new System.Drawing.Size(120, 70);
            this.btnMatri.TabIndex = 7;
            this.btnMatri.Text = "Matricular Cliente";
            this.btnMatri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMatri.UseVisualStyleBackColor = false;
            this.btnMatri.Click += new System.EventHandler(this.btnMatri_Click);
            // 
            // btnPack
            // 
            this.btnPack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPack.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnPack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPack.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPack.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonPack;
            this.btnPack.Location = new System.Drawing.Point(-4, 204);
            this.btnPack.Name = "btnPack";
            this.btnPack.Size = new System.Drawing.Size(120, 70);
            this.btnPack.TabIndex = 3;
            this.btnPack.Text = "Pacotes Mergulho";
            this.btnPack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPack.UseVisualStyleBackColor = false;
            this.btnPack.Click += new System.EventHandler(this.btnPack_Click);
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgendamento.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnAgendamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btnAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSalmon;
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgendamento.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonAgenda;
            this.btnAgendamento.Location = new System.Drawing.Point(-4, 408);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(120, 70);
            this.btnAgendamento.TabIndex = 6;
            this.btnAgendamento.Text = "Agendar Pacote";
            this.btnAgendamento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgendamento.UseVisualStyleBackColor = false;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgenda);
            // 
            // btnInstru
            // 
            this.btnInstru.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInstru.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInstru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnInstru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInstru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstru.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstru.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInstru.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonInstru;
            this.btnInstru.Location = new System.Drawing.Point(-4, 68);
            this.btnInstru.Name = "btnInstru";
            this.btnInstru.Size = new System.Drawing.Size(120, 70);
            this.btnInstru.TabIndex = 1;
            this.btnInstru.Text = "Instrutores";
            this.btnInstru.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInstru.UseVisualStyleBackColor = false;
            this.btnInstru.Click += new System.EventHandler(this.btnInstru_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupp.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSupp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnSupp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSupp.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonSuppl;
            this.btnSupp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupp.Location = new System.Drawing.Point(-4, 340);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(120, 70);
            this.btnSupp.TabIndex = 5;
            this.btnSupp.Text = "Suplementos";
            this.btnSupp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSupp.UseVisualStyleBackColor = false;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnCurso
            // 
            this.btnCurso.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCurso.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCurso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnCurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurso.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurso.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCurso.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonCursos;
            this.btnCurso.Location = new System.Drawing.Point(-4, 136);
            this.btnCurso.Name = "btnCurso";
            this.btnCurso.Size = new System.Drawing.Size(120, 70);
            this.btnCurso.TabIndex = 2;
            this.btnCurso.Text = "Cursos";
            this.btnCurso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCurso.UseVisualStyleBackColor = false;
            this.btnCurso.Click += new System.EventHandler(this.btnCurso_Click);
            // 
            // btnEquip
            // 
            this.btnEquip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEquip.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEquip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnEquip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnEquip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquip.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquip.Image = global::LifeDiver.SOLUTION.Properties.Resources.LD_buttonEquip;
            this.btnEquip.Location = new System.Drawing.Point(-4, 272);
            this.btnEquip.Name = "btnEquip";
            this.btnEquip.Size = new System.Drawing.Size(120, 70);
            this.btnEquip.TabIndex = 4;
            this.btnEquip.Text = "Equipamentos";
            this.btnEquip.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEquip.UseVisualStyleBackColor = false;
            this.btnEquip.Click += new System.EventHandler(this.btnEquip_Click);
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // frmLD_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1264, 780);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.painelcontrol);
            this.Controls.Add(this.statusBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmLD_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life Diver - Mergulho Turístico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LD_Principal_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.painelcontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.Panel painelcontrol;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Button btnCli;
        private System.Windows.Forms.Button btnPack;
        private System.Windows.Forms.Button btnEquip;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnInstru;
        private System.Windows.Forms.Button btnCurso;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnMatri;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ToolStripStatusLabel stLbl1;
        private System.Windows.Forms.ToolStripStatusLabel stLblDate;
        private System.Windows.Forms.Timer timerDate;
    }
}

