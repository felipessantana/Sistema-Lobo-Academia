using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Entidades;
using Sistema.Model;

namespace Sistema.View
{
    public partial class frmCadUsuario : Form
    {
        UsuarioEnt objTabela = new UsuarioEnt();
        
        public frmCadUsuario()
        {
            InitializeComponent();
        }
        private void HabilitarCampos()
        {
            textCadNome.Enabled = true;
            textCadUsuario.Enabled = true;
            textCadSenha.Enabled = true;
            
        }
        private void DesabilitarCampos()
        {
            textCadNome.Enabled = false;
            textCadUsuario.Enabled = false;
            textCadSenha.Enabled = false;
            
        }
        private void LimparCampos()
        {
            
            textCadNome.Text = String.Empty; 
            textCadUsuario.Text = String.Empty;
            textCadSenha.Text = String.Empty;
            txtCodigo.Text = String.Empty;
        }




        private void btnNovo_Click(object sender, EventArgs e)
        {
            
            opc = "Novo";
            IniciarOpc();
            HabilitarCampos();
            LimparCampos();
                       
        }
        private string opc = String.Empty;
        private void IniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    break;

                case "Salvar":
                    
                     try
                     {
                         objTabela.Nome = textCadNome.Text;
                         objTabela.Usuario = textCadUsuario.Text;
                         objTabela.Senha = textCadSenha.Text;



                         int x = UsuarioModel.Inserir(objTabela);
                         if (x > 0)
                         {
                             MessageBox.Show(string.Format("Usuário " + textCadNome.Text + " foi Cadastrado!"));

                         }
                         else
                         {
                             MessageBox.Show("Não Cadastrado!");
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Ocorreu um erro ao Salvar" + ex.Message);

                     }

                    break;
                case "Excluir":
                    try
                    {
                        objTabela.Id = Convert.ToInt32(txtCodigo.Text);
                        


                        int x = UsuarioModel.Excluir(objTabela);
                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Usuário " + textCadNome.Text + " foi Excluido!"));
                        }
                        else
                        {
                            MessageBox.Show("Não Excluido!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Excluir" + ex.Message);

                    }

                    break;
                case "Editar":
                    
                    try
                     {
                         objTabela.Id = Convert.ToInt32(txtCodigo.Text);
                         objTabela.Nome = textCadNome.Text;
                         objTabela.Usuario = textCadUsuario.Text;
                         objTabela.Senha = textCadSenha.Text;
                         


                         int x = UsuarioModel.Editar(objTabela);
                         if (x > 0)
                         {
                             MessageBox.Show(string.Format("Usuário " + textCadNome.Text + " foi Editado!"));
                         }
                         else
                         {
                             MessageBox.Show("Não Alterado!");
                         }
                     }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro ao Editar" + ex.Message);

                    }
                    
                    
                    break;

                default:
                    break;
            }
        }

        

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                
            
                
                string nome = textCadNome.Text;
                string usuario = textCadUsuario.Text;
                string senha = textCadSenha.Text;


                Validacoes.Validacoes validacoes = new Validacoes.Validacoes();
                DialogResult status = validacoes.ValidarCamposCadastrosUsuario(nome, usuario, senha);
                if(status == DialogResult.OK)
                {
                    opc = "Salvar";
                    IniciarOpc();
                    ListarGrid();
                    LimparCampos();
                    DesabilitarCampos();
                }
                               
            }
            

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro na Tabela abaixo!!");
                return;
            }
            opc = "Excluir";
            IniciarOpc();
            ListarGrid();
            LimparCampos();
            DesabilitarCampos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == String.Empty)
            {
                MessageBox.Show("Selecione um registro na Tabela abaixo!!");
                return;
            }
            opc = "Editar";
            IniciarOpc();
            ListarGrid();
            DesabilitarCampos();
            LimparCampos();

        }
        private void ListarGrid()
        {
            try
            {
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                lista = new UsuarioModel().Lista();
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar Dados" + ex.Message);
            }
        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGrid.CurrentRow.Cells["id"].Value.ToString();
            textCadNome.Text = dataGrid.CurrentRow.Cells["nome"].Value.ToString();
            textCadUsuario.Text = dataGrid.CurrentRow.Cells["usuario"].Value.ToString();
            textCadSenha.Text = dataGrid.CurrentRow.Cells["senha"].Value.ToString();
            HabilitarCampos();
        }

        private void labelCadUsuario_Click(object sender, EventArgs e)
        {

        }

        private void textCadUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
