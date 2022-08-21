using Sistema.Entidades;
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

namespace Sistema.View
{
    public partial class frmEmpresas : Form
    {
        EmpresaEnt objTabela = new EmpresaEnt(); 
        
        public frmEmpresas()
        {
            InitializeComponent();
        }

       

        private void btnAFoto_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                label2.Text = "Caminho da Imagem: " + openFileDialog1.SafeFileName.ToString();
            }
        }

        private void HabilitarCampos()
        {
            textNomeEmp.Enabled  = true;
            textRSocial.Enabled  = true;
            textCnpj.Enabled     = true;
            textCep.Enabled      = true;
            textEnd.Enabled      = true;
            textBairro.Enabled   = true;
            textCidade.Enabled   = true;
            textUf.Enabled       = true;
            textEmail.Enabled    = true;
            textTelefone.Enabled = true;
            
        }
        private void DesabilitarCampos()
        {
            textNomeEmp.Enabled  = false;
            textRSocial.Enabled  = false; 
            textCnpj.Enabled     = false;
            textCep.Enabled      = false;
            textEnd.Enabled      = false;
            textBairro.Enabled   = false;
            textCidade.Enabled   = false;
            textUf.Enabled       = false;
            textEmail.Enabled    = false;
            textTelefone.Enabled = false;
            
        }
        private void LimparCampos()
        {
            txtCodigo.Text      = String.Empty; 
            textNomeEmp.Text    = String.Empty;
            textRSocial.Text    = String.Empty;
            textCnpj.Text       = String.Empty;
            textCep.Text        = String.Empty;
            textEnd.Text        = String.Empty;
            textBairro.Text     = String.Empty;
            textCidade.Text     = String.Empty;
            textUf.Text         = String.Empty;
            textEmail.Text      = String.Empty;
            textTelefone.Text   = String.Empty;
           
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


                            objTabela.Nome_empresa  = textNomeEmp.Text;
                            objTabela.Razao_social  = textRSocial.Text;
                            objTabela.Cnpj          = textCnpj.Text;
                            objTabela.Cep           = textCep.Text;
                            objTabela.Endereco      = textEnd.Text;
                            objTabela.Bairro        = textBairro.Text;
                            objTabela.Cidade        = textCidade.Text;
                            objTabela.Uf            = textUf.Text;
                            objTabela.Email         = textEmail.Text;
                            objTabela.Telefone      = textTelefone.Text;


                            objTabela.UrlFoto = label2.Text;

                            int x = EmpresaModel.Inserir(objTabela);
                            if (x > 0)
                            {
                                MessageBox.Show(string.Format("Empresa " + textNomeEmp.Text + " foi Cadastrado!"));

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



                        int x = EmpresaModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Empresa " + textNomeEmp.Text + " foi Excluido!"));
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
                        objTabela.Id            = Convert.ToInt32(txtCodigo.Text);
                        objTabela.Nome_empresa  = textNomeEmp.Text;
                        objTabela.Razao_social  = textRSocial.Text;
                        objTabela.Cnpj          = textCnpj.Text;
                        objTabela.Cep           = textCep.Text;
                        objTabela.Endereco      = textEnd.Text;
                        objTabela.Bairro        = textBairro.Text;
                        objTabela.Cidade        = textCidade.Text;
                        objTabela.Uf            = textUf.Text;
                        objTabela.Email         = textEmail.Text;
                        objTabela.Telefone      = textTelefone.Text;

                        objTabela.UrlFoto = label2.Text;

                        int x = EmpresaModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Empresa " + textNomeEmp.Text + " foi Editado!"));
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
                        objTabela.Nome_empresa = txtBuscar.Text;
                        List<EmpresaEnt> lista = new List<EmpresaEnt>();
                        lista = new EmpresaModel().Buscar(objTabela);

                        dataGrid.AutoGenerateColumns = false;
                        dataGrid.DataSource = lista;

                        label1.Text = "Total de Registros: "+ dataGrid.RowCount.ToString();
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
                string nome_empresa     = textNomeEmp.Text;
                string razao_social     = textRSocial.Text;
                string cnpj             = textCnpj.Text;
                string cep              = textCep.Text;
                string endereco         = textEnd.Text;
                string bairro           = textBairro.Text;
                string cidade           = textCidade.Text;
                string uf               = textUf.Text;
                string email            = textEmail.Text;
                string telefone         = textTelefone.Text;


                Validacoes.Validacoes validacoes = new Validacoes.Validacoes();
                DialogResult status = validacoes.ValidarCamposEmpresa(nome_empresa, razao_social, cnpj, cep, endereco, bairro, cidade, uf, email, telefone);
                

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
                List<EmpresaEnt> lista = new List<EmpresaEnt>();
                lista = new EmpresaModel().Lista();
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar Dados" + ex.Message);
            }
        }
        private void frmEmpresascs_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }


        

        private void dataGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text               = dataGrid.CurrentRow.Cells[0].Value.ToString();
            textNomeEmp.Text             = dataGrid.CurrentRow.Cells["Nome_empresa"].Value.ToString();
            textRSocial.Text             = dataGrid.CurrentRow.Cells["Razao_social"].Value.ToString();
            textCnpj.Text                = dataGrid.CurrentRow.Cells["cnpj"].Value.ToString();
            textCep.Text                 = dataGrid.CurrentRow.Cells["cep"].Value.ToString();
            textEnd.Text                 = dataGrid.CurrentRow.Cells["endereco"].Value.ToString();
            textBairro.Text              = dataGrid.CurrentRow.Cells["bairro"].Value.ToString();
            textCidade.Text              = dataGrid.CurrentRow.Cells["cidade"].Value.ToString();
            textEmail.Text               = dataGrid.CurrentRow.Cells["email"].Value.ToString();
            textTelefone.Text            = dataGrid.CurrentRow.Cells["telefone"].Value.ToString();
            pictureBox1.ImageLocation    = dataGrid.CurrentRow.Cells["UrlFoto"].Value.ToString();

            HabilitarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscar.Text == String.Empty)
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

       
    }
}
