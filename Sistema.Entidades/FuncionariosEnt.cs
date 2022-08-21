using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class FuncionariosEnt
    {
        private int id;
        private string dt_cadastro;
        private string nome_funcionario;
        private string dt_nascimento;
        private string confef;
        private string rg;
        private string cpf;
        private string celular01;
        private string endereco;
        private string bairro;
        private string cep;
        private string cidade;
        private string uf;
        private string cargo;
        private string email;
        private string url_foto;

        public int Id { get => id; set => id = value; }
        public string Dt_cadastro { get => dt_cadastro; set => dt_cadastro = value; }

        public string Dt_nascimento { get => dt_nascimento; set => dt_nascimento = value; }
        public string Confef { get => confef; set => confef = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Celular01 { get => celular01; set => celular01 = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Email { get => email; set => email = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string Nome_funcionario { get => nome_funcionario; set => nome_funcionario = value; }
        public string Url_foto { get => url_foto; set => url_foto = value; }
    }
}
