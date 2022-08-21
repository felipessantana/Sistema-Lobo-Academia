using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class FuncionarioEnt
    {
        private int id;
        private string dt_cadastro;
        private string nome_funcionario;
        private string dt_nascimento;
        private string rg;
        private string cpf;
        private string confef;
        private string cargo;
        private string cep;
        private string endereco;
        private string bairro;
        private string cidade;
        private string uf;
        private string telefone;
        private string email;
        private string urlFoto;



        public int Id { get => id; set => id = value; }
        public string Dt_cadastro { get => dt_cadastro; set => dt_cadastro = value; }
        public string Nome_funcionario { get => nome_funcionario; set => nome_funcionario = value; }
        public string Dt_nascimento { get => dt_nascimento; set => dt_nascimento = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Confef { get => confef; set => confef = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string UrlFoto
        {
            get => urlFoto; set => urlFoto = value;

        }
    }
}

