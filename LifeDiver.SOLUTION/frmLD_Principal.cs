using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeDiver.SOLUTION
{
    public partial class frmLD_Principal : Form
    {
        public frmLD_Principal()
        {
            InitializeComponent();
        }

        //Janelas Ativadas?
        public static bool boolCliente = false;
        public static bool boolInstrutor = false;
        public static bool boolEquip = false;
        public static bool boolSupp = false;
        public static bool boolCurso = false;
        public static bool boolPacote = false;
        //
        public static bool boolAgenda = false;
        public static bool boolMatricula = false;
        public static bool boolVenda = false;


        #region ControlesJanela

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LD_Principal_Load(object sender, EventArgs e)
        {

            MdiClient ctlMDI;
            //' Loop through all of the form's controls looking
            //' for the control of type MdiClient.
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    // Attempt to cast the control to type MdiClient.
                    ctlMDI = (MdiClient)ctl;

                    // Set the BackColor of the MdiClient control.
                    ctlMDI.BackColor = this.BackColor;
                }
                catch (InvalidCastException exc)
                {
                    // Catch and ignore the error if casting failed.
                    Console.Write(exc.ToString()); //gambiarra pra não aparecer o warning
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerDate_Tick(object sender, EventArgs e)
        {
            stLblDate.Text = DateTime.Now.ToString();
        }

#endregion

        private void btnCli_Click(object sender, EventArgs e)
        {
            
            if (!boolCliente)
            {
                frmLD_Cliente janelaCliente = new frmLD_Cliente();
                janelaCliente.MdiParent = this;
                janelaCliente.Show();
                boolCliente = true;
            }
            
        }

        private void btnInstru_Click(object sender, EventArgs e)
        {
            if (!boolInstrutor)
            {
                frmLD_Instrutor janelaInstrutor = new frmLD_Instrutor();
                janelaInstrutor.MdiParent = this;
                janelaInstrutor.Show();
                boolInstrutor = true;
            }
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            if (!boolEquip)
            {
                frmLD_Equipamento janelaEquip = new frmLD_Equipamento();
                janelaEquip.MdiParent = this;
                janelaEquip.Show();
                boolEquip = true;
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (!boolSupp)
            {
                frmLD_Suplemento janelaSupp = new frmLD_Suplemento();
                janelaSupp.MdiParent = this;
                janelaSupp.Show();
                boolSupp = true;
            }
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            if (!boolCurso)
            {
                frmLD_Curso janelaCurso = new frmLD_Curso();
                janelaCurso.MdiParent = this;
                janelaCurso.Show();
                boolCurso = true;
            }
        }

        private void btnPack_Click(object sender, EventArgs e)
        {
            if (!boolPacote)
            {
                frmLD_Pacote janelaPack = new frmLD_Pacote();
                janelaPack.MdiParent = this;
                janelaPack.Show();
                boolPacote = true;
            }
        }

        private void btnAgenda(object sender, EventArgs e)
        {
            if (!boolAgenda)
            {
                frmLD_Agenda janelaAgenda = new frmLD_Agenda();
                janelaAgenda.MdiParent = this;
                janelaAgenda.Show();
                boolAgenda = true;
            }
        }

        private void btnMatri_Click(object sender, EventArgs e)
        {
            if (!boolMatricula)
            {
                frmLD_Matricula janelaMatri = new frmLD_Matricula();
                janelaMatri.MdiParent = this;
                janelaMatri.Show();
                boolMatricula = true;
            }
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            if(!boolVenda)
            {
                frmLD_Venda janelaVenda = new frmLD_Venda();
                janelaVenda.MdiParent = this;
                janelaVenda.Show();
                boolVenda = true;
            }

        }


    }
}
