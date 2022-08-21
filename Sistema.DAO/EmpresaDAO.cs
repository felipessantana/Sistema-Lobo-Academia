using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAO
{
    public  class EmpresaDAO
    {
        public int Inserir(EmpresaEnt objTabela)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"INSERT INTO Empresa (nome_empresa, razao_social, cnpj, cep, endereco, bairro, cidade, uf, 
                                                        email, telefone, url_foto ) VALUES(@nome_empresa, @razao_social, @cnpj, @cep, 
                                                        @endereco, @bairro, @cidade, @uf, @email, @telefone, @url_foto)";

                cn.Parameters.AddWithValue("@nome_empresa", objTabela.Nome_empresa);
                cn.Parameters.AddWithValue("@razao_social", objTabela.Razao_social);
                cn.Parameters.AddWithValue("@cnpj", objTabela.Cnpj);
                cn.Parameters.AddWithValue("@cep", objTabela.Cep);
                cn.Parameters.AddWithValue("@endereco", objTabela.Endereco);
                cn.Parameters.AddWithValue("@bairro", objTabela.Bairro);
                cn.Parameters.AddWithValue("@cidade", objTabela.Cidade);
                cn.Parameters.AddWithValue("@uf", objTabela.Uf);
                cn.Parameters.AddWithValue("@email", objTabela.Email);
                cn.Parameters.AddWithValue("@telefone", objTabela.Telefone);
                cn.Parameters.AddWithValue("@url_foto", objTabela.UrlFoto);

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public List<EmpresaEnt> Buscar(EmpresaEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id,nome_empresa, razao_social, cnpj, cep, endereco, bairro,  
                                CONCAT(CIDADE,' - ',UF) AS CIDADE, email, telefone  FROM Empresa WHERE nome_empresa LIKE @nome_empresa";

                cn.Parameters.AddWithValue("@nome_empresa", objTabela.Nome_empresa + "%");

                cn.Connection = con;

                SqlDataReader dr;
                List<EmpresaEnt> lista = new List<EmpresaEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EmpresaEnt dado = new EmpresaEnt();
                        dado.Id                 = Convert.ToInt32(dr["id"]);
                        dado.Nome_empresa       = Convert.ToString(dr["nome_empresa"]);
                        dado.Razao_social       = Convert.ToString(dr["razao_social"]);
                        dado.Cnpj               = Convert.ToString(dr["cnpj"]);
                        dado.Cep                = Convert.ToString(dr["cep"]);
                        dado.Endereco           = Convert.ToString(dr["endereco"]);
                        dado.Bairro             = Convert.ToString(dr["bairro"]);
                        dado.Cidade             = Convert.ToString(dr["cidade"]);
                        dado.Email              = Convert.ToString(dr["email"]);
                        dado.Telefone           = Convert.ToString(dr["telefone"]);
                       

                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }

        public int Editar(EmpresaEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"UPDATE Empresa SET nome_empresa = @nome_empresa, razao_social = @razao_social,
                    cnpj = @cnpj, cep = @cep, endereco = @endereco, bairro = @bairro, cidade = @cidade, 
uf = @uf, email = @email, telefone = @telefone, url_foto = @url_foto where id = @id";



                cn.Parameters.AddWithValue("@nome_empresa", objTabela.Nome_empresa);
                cn.Parameters.AddWithValue("@razao_social", objTabela.Razao_social);
                cn.Parameters.AddWithValue("@cnpj", objTabela.Cnpj);
                cn.Parameters.AddWithValue("@cep", objTabela.Cep);
                cn.Parameters.AddWithValue("@endereco", objTabela.Endereco);
                cn.Parameters.AddWithValue("@bairro", objTabela.Bairro);
                cn.Parameters.AddWithValue("@cidade", objTabela.Cidade);
                cn.Parameters.AddWithValue("@uf", objTabela.Uf);
                cn.Parameters.AddWithValue("@email", objTabela.Email);
                cn.Parameters.AddWithValue("@id", objTabela.Id);
                cn.Parameters.AddWithValue("@telefone", objTabela.Telefone);
                cn.Parameters.AddWithValue("@url_foto", objTabela.UrlFoto);

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public int Excluir(EmpresaEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"DELETE FROM Empresa where id = @id";


               
                cn.Parameters.AddWithValue("@id", objTabela.Id);

                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public List<EmpresaEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id,nome_empresa, razao_social, cnpj, cep, endereco, bairro, cidade, uf, email, telefone, url_foto  FROM Empresa ORDER BY id DESC";


                cn.Connection = con;

                SqlDataReader dr;
                List<EmpresaEnt> lista = new List<EmpresaEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EmpresaEnt dado = new EmpresaEnt();
                        dado.Id                 = Convert.ToInt32(dr["id"]);
                        dado.Nome_empresa       = Convert.ToString(dr["nome_empresa"]);
                        dado.Razao_social       = Convert.ToString(dr["razao_social"]);
                        dado.Cnpj               = Convert.ToString(dr["cnpj"]);
                        dado.Cep                = Convert.ToString(dr["cep"]);
                        dado.Endereco           = Convert.ToString(dr["endereco"]);
                        dado.Bairro             = Convert.ToString(dr["bairro"]);
                        dado.Cidade             = Convert.ToString(dr["cidade"]);
                        dado.Uf                 = Convert.ToString(dr["uf"]);
                        dado.Email              = Convert.ToString(dr["email"]);
                        dado.Telefone           = Convert.ToString(dr["telefone"]);
                        dado.UrlFoto            = Convert.ToString(dr["url_foto"]);

                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }

        
    }
}
