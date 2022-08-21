using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class AlunosEnt
    {
        private int id;
        private string dt_cadastro;
        private string nome_alunos;
        private string dt_nascimento;
        private string rg;
        private string cpf;
        private string celular01;
        private string celular02;
        private string endereco;
        private string bairro;
        private string cep;
        private string cidade;
        private string uf;
        private string email;
        private string altura;
        private string peso;
        private string urlFoto;

        public int Id { get => id; set => id = value; }
        public string Dt_cadastro { get => dt_cadastro; set => dt_cadastro = value; }
        public string Nome_alunos { get => nome_alunos; set => nome_alunos = value; }
        public string Dt_nascimento { get => dt_nascimento; set => dt_nascimento = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Celular01 { get => celular01; set => celular01 = value; }
        public string Celular02 { get => celular02; set => celular02 = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Email { get => email; set => email = value; }
        public string Altura { get => altura; set => altura = value; }
        public string Peso { get => peso; set => peso = value; }

        public string  UrlFoto{ get => urlFoto; set => urlFoto =  value; }
    }
}
