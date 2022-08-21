using Sistema.Entidades;
using Sistema.Model;
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
    public partial class frmFuncionario : Form
    {
        FuncionarioEnt objTabela = new FuncionarioEnt();
        public frmFuncionario()
        {
            InitializeComponent();
        }

        private void btnAFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                label15.Text = "Caminho da Imagem: " + openFileDialog1.SafeFileName.ToString();
            }
        }
        private void HabilitarCampos()
        {
            textDtCadastro.Enabled          = true;
            textNomeFuncionario.Enabled     = true;
            textDtNascimento.Enabled        = true;
            textRg.Enabled                  = true;
            textCpf.Enabled                 = true;
            textCel.Enabled                 = true;
            textEnd.Enabled                 = true;
            textBairro.Enabled              = true;
            textCep.Enabled                 = true;
            textCidade.Enabled              = true;
            textUf.Enabled                  = true;
            textEmail.Enabled               = true;
            textConfef.Enabled              = true;
            textCargo.Enabled               = true;

        }
        private void DesabilitarCampos()
        {
            textDtCadastro.Enabled          = false;
            textNomeFuncionario.Enabled     = false;
            textDtNascimento.Enabled        = false;
            textRg.Enabled                  = false;
            textCpf.Enabled                 = false;
            textCel.Enabled                 = false;
            textEnd.Enabled                 = false;
            textBairro.Enabled              = false;
            textCep.Enabled                 = false;
            textCidade.Enabled              = false;
            textUf.Enabled                  = false;
            textEmail.Enabled               = false;
            textConfef.Enabled              = false;
            textCargo.Enabled               = false;
        }
        private void LimparCampos()
        {
            txtCodigo.Text              = String.Empty;
            textDtCadastro.Text         = String.Empty;
            textNomeFuncionario.Text    = String.Empty;
            textDtNascimento.Text       = String.Empty;
            textRg.Text                 = String.Empty;
            textCpf.Text                = String.Empty;
            textCel.Text                = String.Empty;
            textEnd.Text                = String.Empty;
            textBairro.Text             = String.Empty;
            textCep.Text                = String.Empty;
            textCidade.Text             = String.Empty;
            textUf.Text                 = String.Empty;
            textEmail.Text              = String.Empty;
            textConfef.Text             = String.Empty;
            textCargo.Text              = String.Empty;
        }
        

        private void btnNovo_Click(object sender, EventArgs e)
        {
            {
                opc = "Novo";
                IniciarOpc();
                HabilitarCampos();
                LimparCampos();
            }
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
                        objTabela.Dt_cadastro           = textDtCadastro.Text;
                        objTabela.Nome_funcionario      = textNomeFuncionario.Text;
                        objTabela.Dt_nascimento         = textDtNascimento.Text;
                        objTabela.Rg                    = textRg.Text;
                        objTabela.Cpf                   = textCpf.Text;
                        objTabela.Telefone              = textCel.Text;
                        objTabela.Endereco              = textEnd.Text;
                        objTabela.Bairro                = textBairro.Text;
                        objTabela.Cep                   = textCep.Text;
                        objTabela.Cidade                = textCidade.Text;
                        objTabela.Uf                    = textUf.Text;
                        objTabela.Email                 = textEmail.Text;
                        objTabela.Confef                = textConfef.Text;
                        objTabela.Cargo                 = textCargo.Text;

                        objTabela.UrlFoto = label15.Text;

                        int x = FuncionariosModel.Inserir(objTabela);
                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Funcionario " + textNomeFuncionario.Text + " foi Cadastrado!"));

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



                        int x = FuncionariosModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Funcionario " + textNomeFuncionario.Text + " foi Excluido!"));
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
                        objTabela.Id                    = Convert.ToInt32(txtCodigo.Text);
                        objTabela.Dt_cadastro           = textDtCadastro.Text;
                        objTabela.Nome_funcionario      = textNomeFuncionario.Text;
                        objTabela.Dt_nascimento         = textDtNascimento.Text;
                        objTabela.Rg                    = textRg.Text;
                        objTabela.Cpf                   = textCpf.Text;
                        objTabela.Telefone              = textCel.Text;
                        objTabela.Endereco              = textEnd.Text;
                        objTabela.Bairro                = textBairro.Text;
                        objTabela.Cep                   = textCep.Text;
                        objTabela.Cidade                = textCidade.Text;
                        objTabela.Uf                    = textUf.Text;
                        objTabela.Email                 = textEmail.Text;
                        objTabela.Confef                = textConfef.Text;
                        objTabela.Cargo                 = textCargo.Text;

                        objTabela.UrlFoto = label15.Text;

                        int x = FuncionariosModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Funcionario " + textNomeFuncionario.Text + " foi Editado!"));
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
                case "Buscar":

                    try
                    {
                        objTabela.Nome_funcionario = txtBuscar.Text;
                        List<FuncionarioEnt> lista = new List<FuncionarioEnt>();
                        lista = new FuncionariosModel().Buscar(objTabela);

                        dataGrid.AutoGenerateColumns = false;
                        dataGrid.DataSource = lista;

                        label6.Text = "Total de Registros: " + dataGrid.RowCount.ToString();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Erro ao Listar Dados" + ex.Message);
                    }

                    break;

                default:
                    break;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text)){

                string dt_cadastro          = textDtCadastro.Text;
                string nome_funcionario     = textNomeFuncionario.Text;
                string dt_nascimento        = textDtNascimento.Text;
                string rg                   = textRg.Text;
                string cpf                  = textCpf.Text;
                string cargo                = textCargo.Text;
                string endereco             = textEnd.Text;
                string bairro               = textBairro.Text;
                string cep                  = textCep.Text;
                string cidade               = textCidade.Text;
                string uf                   = textUf.Text;
                string telefone             = textCel.Text;
                string email                = textEmail.Text;

                Validacoes.Validacoes validacoes = new Validacoes.Validacoes();
                DialogResult status = validacoes.ValidarCamposFuncionario(dt_cadastro, nome_funcionario, dt_nascimento, rg, cpf, cargo, endereco, bairro, cep, cidade, uf, telefone,email);
                
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
            LimparCampos();
            DesabilitarCampos();
        }
        private void ListarGrid()
        {
            try
            {
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();
                lista = new FuncionariosModel().Lista();
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar Dados" + ex.Message);
            }
        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text              = dataGrid.CurrentRow.Cells["id"].Value.ToString();
            textDtCadastro.Text         = dataGrid.CurrentRow.Cells["Dt_cadastro"].Value.ToString();
            textNomeFuncionario.Text    = dataGrid.CurrentRow.Cells["nome_funcionario"].Value.ToString();
            textDtNascimento.Text       = dataGrid.CurrentRow.Cells["Dt_nascimento"].Value.ToString();
            textRg.Text                 = dataGrid.CurrentRow.Cells["Rg"].Value.ToString();
            textCpf.Text                = dataGrid.CurrentRow.Cells["Cpf"].Value.ToString();
            textEnd.Text                = dataGrid.CurrentRow.Cells["Endereco"].Value.ToString();
            textBairro.Text             = dataGrid.CurrentRow.Cells["Bairro"].Value.ToString();
            textCep.Text                = dataGrid.CurrentRow.Cells["Cep"].Value.ToString();
            textCidade.Text             = dataGrid.CurrentRow.Cells["Cidade"].Value.ToString();
            textEmail.Text              = dataGrid.CurrentRow.Cells["Email"].Value.ToString();
            textCel.Text                = dataGrid.CurrentRow.Cells["telefone"].Value.ToString();
            textConfef.Text             = dataGrid.CurrentRow.Cells["confef"].Value.ToString();
            textCargo.Text              = dataGrid.CurrentRow.Cells["cargo"].Value.ToString();
            pictureBox1.ImageLocation   = dataGrid.CurrentRow.Cells["Url_foto"].Value.ToString();
            HabilitarCampos();
        }
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == String.Empty)
            {
                ListarGrid();
                return;
            }
            opc = "Buscar";
            IniciarOpc();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            opc = "Buscar";
            IniciarOpc();
        }

        private void frmFuncionario_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        
    }
}
