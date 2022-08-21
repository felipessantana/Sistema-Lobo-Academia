using Sistema.Entidades;
using Sistema.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema.View
{
    public partial class frmTreino : Form
    {
        TreinoEnt objTabela = new TreinoEnt();
        public frmTreino()
        {
            InitializeComponent();
        }
        private void HabilitarCampos()
        {
            textNometreino.Enabled = true;
            

        }
        private void DesabilitarCampos()
        {
            textNometreino.Enabled = false;
        }
        private void LimparCampos()
        {
           
            textNometreino.Text = string.Empty;
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
                        
                        objTabela.Nome_treino = textNometreino.Text;

                        

                        int x = TreinoModel.Inserir(objTabela);
                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Treino " + textNometreino.Text + " foi Cadastrado!"));

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



                        int x = TreinoModel.Excluir(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Treino " + textNometreino.Text + " foi Excluido!"));
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
                        objTabela.Nome_treino = textNometreino.Text;
                        

                        int x = TreinoModel.Editar(objTabela);

                        if (x > 0)
                        {
                            MessageBox.Show(string.Format("Treino " + textNometreino.Text + " foi Editado!"));
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
                        objTabela.Nome_treino = txtBuscar.Text;
                        List<TreinoEnt> lista = new List<TreinoEnt>();
                        lista = new TreinoModel().Buscar(objTabela);

                        dataGrid.AutoGenerateColumns = false;
                        dataGrid.DataSource = lista;
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

                string nometreino = textNometreino.Text;
                

                Validacoes.Validacoes validacoes = new Validacoes.Validacoes();
                DialogResult status = validacoes.ValidarCamposTreino(nometreino);

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
        private void ListarGrid()
        {
            try
            {
                List<TreinoEnt> lista = new List<TreinoEnt>();
                lista = new TreinoModel().Lista();
                dataGrid.AutoGenerateColumns = false;
                dataGrid.DataSource = lista;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao Listar Dados" + ex.Message);
            }
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
        

        private void frmTreino_Load(object sender, EventArgs e)
        {
            ListarGrid();
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGrid.CurrentRow.Cells["id"].Value.ToString();
            textNometreino.Text = dataGrid.CurrentRow.Cells["nome_treino"].Value.ToString();

            HabilitarCampos();

        }

        
    }
}
