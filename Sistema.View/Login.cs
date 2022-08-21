using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Model;
using Sistema.Entidades;


namespace Sistema.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string login = textUsuario.Text;
                string senha = textSenha.Text;

                Validacoes.Validacoes validacoes = new Validacoes.Validacoes();
                DialogResult status = validacoes.ValidarLoginInserido(login,senha);


                if (status == DialogResult.OK)
                {

                    UsuarioEnt obj = new UsuarioEnt();
                    obj.Usuario = textUsuario.Text;
                    obj.Senha = textSenha.Text;



                    obj = new UsuarioModel().Login(obj);

                    if (obj != null)
                    {
                        frmMDI frm = new frmMDI();
                        this.Hide();
                        frm.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("Login inválido");
                    }
                }
                
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Logar " + ex.Message);
            }
        }
    }
}
