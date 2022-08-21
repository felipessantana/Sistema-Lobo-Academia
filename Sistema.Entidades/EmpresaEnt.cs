using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class EmpresaEnt
    {
        private int id;
        private string cnpj;
        private string nome_empresa;
        private string razao_social;
        private string endereco;
        private string bairro;
        private string cidade;
        private string uf;
        private string cep;
        private string email;
        private string telefone;
        private string urlFoto;
        

        public int Id { get => id; set => id = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Razao_social { get => razao_social; set => razao_social = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Email { get => email; set => email = value; }
       
        public string Cidade { get => cidade; set => cidade = value; }
        public string Nome_empresa { get => nome_empresa; set => nome_empresa = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string UrlFoto { get => urlFoto; set => urlFoto = value; }
    }
}
