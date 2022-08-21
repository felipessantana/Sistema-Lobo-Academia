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
    public partial class frmAlunos : Form
    {
        AlunosEnt objTabela = new AlunosEnt();
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void btnAFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                label3.Text = openFileDialog1.FileName.ToString();
            }
        }
        private void HabilitarCampos()
        {
            textDtCadastro.Enabled = true;
            textNomeAluno.Enabled = true;
            textDtNascimento.Enabled = true;
            textRg.Enabled = true;
            textCpf.Enabled = true;
            textCel01.Enabled = true;
            textCel02.Enabled = true;
            textPeso.Enabled = true;
            textAltura.Enabled = true;
            textEnd.Enabled = true;
            textBairro.Enabled = true;
            textCep.Enabled = true;
            textCidade.Enabled = true;
            textUf.Enabled = true;
            textEmail.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            textDtCadastro.Enabled = false;
            textNomeAluno.Enabled = false;
            textDtNascimento.Enabled = false;
            textRg.Enabled = false;
            textCpf.Enabled = false;
            textCel01.Enabled = false;
            textCel02.Enabled = false;
            textPeso.Enabled = false;
            textAltura.Enabled = false;
            textEnd.Enabled = false;
            textBairro.Enabled = false;
            textCep.Enabled = false;
            textCidade.Enabled = false;
            textUf.Enabled = false;
            textEmail.Enabled = false;
        }
        private void LimparCampos()
        {
            txtCodigo.Text = String.Empty;
            textDtCadastro.Text = String.Empty;
            textNomeAluno.Text = String.Empty;
            textDtNascimento.Text = String.Empty;
            textRg.Text = String.Empty;
            textCpf.Text = String.Empty;
            textCel01.Text = String.Empty;
            textCel02.Text = String.Empty;
            textPeso.Text = String.Empty;
            textAltura.Text = String.Empty;
            textEnd.Text = String.Empty;
            textBairro.Text = String.Empty;
            textCep.Text = String.Empty;
            textCidade.Text = String.Empty;
            textUf.Text = String.Empty;
            textEmail.Text = String.Empty;
        }

        private void ListarGrid()
        {
            try
            {
                List<AlunosEnt> lista = new List<AlunosEnt>();
                lista = new AlunosModel().Lista();
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar Dados" + ex.Message);
            }
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
                            objTabela.Dt_cadastro       = textDtCadastro.Text;
                            objTabela.Nome_alunos       = textNomeAluno.Text;
                            objTabela.Dt_nascimento     = textDtNascimento.Text;
                            objTabela.Rg                = textRg.Text;
                            objTabela.Cpf               = textCpf.Text;
                            objTabela.Celular01         = textCel01.Text;
                            objTabela.Celular02         = textCel02.Text;
                            objTabela.Peso              = textPeso.Text;
                            objTabela.Altura            = textAltura.Text;
                            objTabela.Endereco          = textEnd.Text;
                            objTabela.Bairro            = textBairro.Text;
                            objTabela.Cep               = textCep.Text;
                            objTabela.Cidade            = textCidade.Text;
                            objTabela.Uf                = textUf.Text;
                            objTabela.Email             = textEmail.Text;

                            
                            objTabela.UrlFoto = label3.Text;


                            int x = AlunosModel.Inserir(objTabela);
                            if (x > 0)
                            {
                                MessageBox.Show(string.Format("Aluno " + textNomeAluno.Text + " foi Cadastrado!"));

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



                        int x = AlunosModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Aluno " + textNomeAluno.Text + " foi Excluido!"));
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
                            objTabela.Id                = Convert.ToInt32(txtCodigo.Text);
                            objTabela.Dt_cadastro       = textDtCadastro.Text;
                            objTabela.Nome_alunos       = textNomeAluno.Text;
                            objTabela.Dt_nascimento     = textDtNascimento.Text;
                            objTabela.Rg                = textRg.Text;
                            objTabela.Cpf               = textCpf.Text;
                            objTabela.Celular01         = textCel01.Text;
                            objTabela.Celular02         = textCel02.Text;
                            objTabela.Peso              = textPeso.Text;
                            objTabela.Altura            = textAltura.Text;
                            objTabela.Endereco          = textEnd.Text;
                            objTabela.Bairro            = textBairro.Text;
                            objTabela.Cep               = textCep.Text;
                            objTabela.Cidade            = textCidade.Text;
                            objTabela.Uf                = textUf.Text;
                            objTabela.Email             = textEmail.Text;

                            objTabela.UrlFoto = label3.Text;

                            int x = AlunosModel.Editar(objTabela);

                            if (x > 0)
                            {
                                MessageBox.Show(string.Format("Empresa " + textNomeAluno.Text + " foi Editado!"));
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
                        objTabela.Nome_alunos = txtBuscar.Text;
                        List<AlunosEnt> lista = new List<AlunosEnt>();
                        lista = new AlunosModel().Buscar(objTabela);

                        dataGrid.AutoGenerateColumns = false;
                        dataGrid.DataSource = lista;

                        label18.Text = "Total de Registros: " + dataGrid.RowCount.ToString();
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
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {

                string dt_cadastro       = textDtCadastro.Text;
                string nome_alunos       = textNomeAluno.Text;
                string dt_nascimento     = textDtNascimento.Text;
                string rg                = textRg.Text;
                string cpf               = textCpf.Text;
                string celular01         = textCel01.Text;
                string celular02         = textCel02.Text;
                string peso              = textPeso.Text;
                string altura            = textAltura.Text;
                string endereco          = textEnd.Text;
                string bairro            = textBairro.Text;
                string cep               = textCep.Text;
                string cidade            = textCidade.Text;
                string uf                = textUf.Text;
                string email             = textEmail.Text;


                Validacoes.Validacoes validacoes = new Validacoes.Validacoes();
                DialogResult status = validacoes.ValidarCamposAluno(dt_cadastro, nome_alunos, dt_nascimento, rg, cpf, celular01, peso, altura, endereco, bairro, cep, cidade, uf, email);

                if (status == DialogResult.OK)
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

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text              = dataGrid.CurrentRow.Cells[0].Value.ToString();
            textDtCadastro.Text         = dataGrid.CurrentRow.Cells["dt_cadastro"].Value.ToString();
            textNomeAluno.Text          = dataGrid.CurrentRow.Cells["nome_alunos"].Value.ToString();
            textDtNascimento.Text       = dataGrid.CurrentRow.Cells["dt_nascimento"].Value.ToString();
            textCpf.Text                = dataGrid.CurrentRow.Cells["Cpf"].Value.ToString();
            textPeso.Text               = dataGrid.CurrentRow.Cells["Peso"].Value.ToString();
            textAltura.Text             = dataGrid.CurrentRow.Cells["Altura"].Value.ToString();
            textEnd.Text                = dataGrid.CurrentRow.Cells["Endereco"].Value.ToString();
            textBairro.Text             = dataGrid.CurrentRow.Cells["Bairro"].Value.ToString();
            textCep.Text                = dataGrid.CurrentRow.Cells["Cep"].Value.ToString();
            textCidade.Text             = dataGrid.CurrentRow.Cells["Cidade"].Value.ToString();
            textEmail.Text              = dataGrid.CurrentRow.Cells["Email"].Value.ToString();
            textCel01.Text              = dataGrid.CurrentRow.Cells["celular01"].Value.ToString();
            textCel02.Text              = dataGrid.CurrentRow.Cells["celular02"].Value.ToString();
            pictureBox1.ImageLocation   = dataGrid.CurrentRow.Cells["UrlFoto"].Value.ToString();

            HabilitarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
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

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        
    }
}