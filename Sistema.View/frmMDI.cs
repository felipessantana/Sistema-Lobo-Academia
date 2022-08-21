using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        

        

        

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUsuario frm = new frmCadUsuario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void EmpresaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEmpresas frm = new frmEmpresas();
            frm.MdiParent = this;
            frm.Show();
        }

        private void AlunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAlunos frm = new frmAlunos();
            frm.MdiParent= this;
            frm.Show();
        }

        private void FuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionario frm = new frmFuncionario();
            frm.MdiParent = this;
            frm.Show();
        }

        

        private void treinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTreino frm = new frmTreino();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
