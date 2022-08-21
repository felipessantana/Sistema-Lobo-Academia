using System.Windows.Forms;

namespace Sistema.View.Validacoes
{
    public class Validacoes
    {

        public DialogResult ValidarLoginInserido(string login, string senha)
        {

            if (string.IsNullOrEmpty(login))
            {
                MessageBox.Show("Campo Usuário está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Campo Senha está vazio");
                return DialogResult.Cancel;
            }
            else
            {
                return DialogResult.OK;
            }

        }
        public DialogResult ValidarCamposCadastrosUsuario(string nome, string usuario, string senha)
        {
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Campo Nome está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(usuario)) 
            {
                MessageBox.Show("Campo Usuário está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Campo Senha está vazio");
                return DialogResult.Cancel;
            }

            else
            {
                return DialogResult.OK;
            }
        }
        public DialogResult ValidarCamposEmpresa(string nome_emprasa, string razao_social, string cnpj, string cep, string endereco, string bairro, string cidade, string uf, string email, string telefone)
        {
            if (string.IsNullOrEmpty(nome_emprasa))
            {
                MessageBox.Show("Campo Nome empresa está vazio");
                return DialogResult.Cancel;

            }
            else if (string.IsNullOrEmpty(razao_social))
            {
                MessageBox.Show("Campo Razão Social está vazio");
                return DialogResult.Cancel;

            }
            else if (string.IsNullOrWhiteSpace(cnpj))
            {
                MessageBox.Show("Campo CNPJ está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Campo CEP está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Campo Endereço está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(bairro))
            {
                MessageBox.Show("Campo Bairro está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cidade))
            {
                MessageBox.Show("Campo Cidade está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(uf))
            {
                MessageBox.Show("Campo UF está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Campo Telefone vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Campo E-mail vazio");
                return DialogResult.Cancel;
            }
            
            else
            {
                return DialogResult.OK;
            }


        }

        public DialogResult ValidarCamposAluno(string dt_cadastro, string nome_alunos, string dt_nascimento, string rg, string cpf, string celular01, string peso, string altura, string endereco, string bairro, string cep, string cidade, string uf, string email)
        {
            if (string.IsNullOrEmpty(dt_cadastro))
            {
                MessageBox.Show("Campo Data de Cadastro está vazio");
                return DialogResult.Cancel;

            }
            else if (string.IsNullOrEmpty(nome_alunos))
            {
                MessageBox.Show("Campo Nome do Aluno está vazio");
                return DialogResult.Cancel;

            }
            else if (string.IsNullOrWhiteSpace(dt_nascimento))
            {
                MessageBox.Show("Campo Data de Nascimento está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(rg))
            {
                MessageBox.Show("Campo RG está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Campo CPF está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(celular01))
            {
                MessageBox.Show("Campo Celular01 está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(altura))
            {
                MessageBox.Show("Campo Altura está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(peso))
            {
                MessageBox.Show("Campo Peso está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Campo Endereço está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(bairro))
            {
                MessageBox.Show("Campo Bairro está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Campo CEP está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cidade))
            {
                MessageBox.Show("Campo Cidade está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(uf))
            {
                MessageBox.Show("Campo UF está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Campo E-mail vazio");
                return DialogResult.Cancel;
            }

            else
            {
                return DialogResult.OK;
            }
        }
        public DialogResult ValidarCamposFuncionario(string dt_cadastro, string nome_funcionario, string dt_nascimento, string rg, string cpf, string telefone, string cargo, string endereco, string bairro, string cep, string cidade, string uf, string email)
        {
            if (string.IsNullOrEmpty(dt_cadastro))
            {
                MessageBox.Show("Campo Data de Cadastro está vazio");
                return DialogResult.Cancel;

            }
            else if (string.IsNullOrEmpty(nome_funcionario))
            {
                MessageBox.Show("Campo Nome do Funcionario está vazio");
                return DialogResult.Cancel;

            }
            else if (string.IsNullOrWhiteSpace(dt_nascimento))
            {
                MessageBox.Show("Campo Data de Nascimento está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(rg))
            {
                MessageBox.Show("Campo RG está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cpf))
            {
                MessageBox.Show("Campo CPF está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cargo))
            {
                MessageBox.Show("Campo Cargo está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cep))
            {
                MessageBox.Show("Campo CEP está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(endereco))
            {
                MessageBox.Show("Campo Endereço está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(bairro))
            {
                MessageBox.Show("Campo Bairro está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(cidade))
            {
                MessageBox.Show("Campo Cidade está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(uf))
            {
                MessageBox.Show("Campo UF está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Campo Telefone está vazio");
                return DialogResult.Cancel;
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Campo E-mail vazio");
                return DialogResult.Cancel;
            }

            else
            {
                return DialogResult.OK;
            }
        }
        public DialogResult ValidarCamposTreino(string nome_treino)
        {
            if (string.IsNullOrEmpty(nome_treino))
            {
                MessageBox.Show("Campo Nome do Treino está vazio");
                return DialogResult.Cancel;

            }
            else
            {
                return DialogResult.OK;
            }
        }
    }
    
}
