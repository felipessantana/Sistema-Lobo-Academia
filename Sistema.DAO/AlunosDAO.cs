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
    public class AlunosDAO
    {
        public int Inserir(AlunosEnt objTabela)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"INSERT INTO Alunos (dt_cadastro, nome_alunos, dt_nascimento, rg, cpf, celular01, celular02, endereco, bairro, cep, cidade, uf, email, altura, peso,url_foto ) VALUES(@dt_cadastro, @nome_alunos, @dt_nascimento, @rg, @cpf, @celular01, @celular02, @endereco, @bairro, @cep, @cidade, @uf, @email, @altura, @peso ,@url_foto)";

                cn.Parameters.AddWithValue("@dt_cadastro", objTabela.Dt_cadastro);
                cn.Parameters.AddWithValue("@nome_alunos", objTabela.Nome_alunos);
                cn.Parameters.AddWithValue("@dt_nascimento", objTabela.Dt_nascimento);
                cn.Parameters.AddWithValue("@rg", objTabela.Rg);
                cn.Parameters.AddWithValue("@cpf", objTabela.Cpf);
                cn.Parameters.AddWithValue("@celular01", objTabela.Celular01);
                cn.Parameters.AddWithValue("@celular02", objTabela.Celular02);
                cn.Parameters.AddWithValue("@endereco", objTabela.Endereco);
                cn.Parameters.AddWithValue("@bairro", objTabela.Bairro);
                cn.Parameters.AddWithValue("@cep", objTabela.Cep);
                cn.Parameters.AddWithValue("@cidade", objTabela.Cidade);
                cn.Parameters.AddWithValue("@uf", objTabela.Uf);
                cn.Parameters.AddWithValue("@email", objTabela.Email);
                cn.Parameters.AddWithValue("@altura", objTabela.Altura);
                cn.Parameters.AddWithValue("@peso", objTabela.Peso);
                cn.Parameters.AddWithValue("@url_foto", objTabela.UrlFoto);


                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public List<AlunosEnt> Buscar(AlunosEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id, dt_cadastro, nome_alunos, dt_nascimento, rg, cpf, celular01, celular02,  endereco, bairro, cep,  CONCAT(CIDADE,' - ',UF) AS CIDADE,email, altura, peso  FROM Alunos WHERE nome_alunos LIKE @nome_alunos";

                cn.Parameters.AddWithValue("@nome_alunos", objTabela.Nome_alunos + "%");

                cn.Connection = con;

                SqlDataReader dr;
                List<AlunosEnt> lista = new List<AlunosEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AlunosEnt dado = new AlunosEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Dt_cadastro = Convert.ToString(dr["dt_cadastro"]);
                        dado.Nome_alunos = Convert.ToString(dr["nome_alunos"]);
                        dado.Dt_nascimento = Convert.ToString(dr["dt_nascimento"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Celular01 = Convert.ToString(dr["celular01"]);
                        dado.Celular02 = Convert.ToString(dr["celular02"]);
                        dado.Endereco = Convert.ToString(dr["endereco"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Cep = Convert.ToString(dr["cep"]);
                        dado.Cidade = Convert.ToString(dr["cidade"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Altura = Convert.ToString(dr["altura"]);
                        dado.Peso = Convert.ToString(dr["peso"]);

                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }

        public int Editar(AlunosEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Alunos SET dt_cadastro = @dt_cadastro, nome_alunos = @nome_alunos," +
                    " dt_nascimento = @dt_nascimento, rg = @rg, cpf = @cpf, celular01 = @celular01, celular02 = @celular02, endereco = @endereco, bairro = @bairro, cep = @cep, cidade = @cidade, uf = @uf, email = @email, altura = @altura, peso = @peso, url_foto = @url_foto  where id = @id";



                cn.Parameters.AddWithValue("@dt_cadastro", objTabela.Dt_cadastro);
                cn.Parameters.AddWithValue("@nome_alunos", objTabela.Nome_alunos);
                cn.Parameters.AddWithValue("@dt_nascimento", objTabela.Dt_nascimento);
                cn.Parameters.AddWithValue("@rg", objTabela.Rg);
                cn.Parameters.AddWithValue("@cpf", objTabela.Cpf);
                cn.Parameters.AddWithValue("@celular01", objTabela.Celular01);
                cn.Parameters.AddWithValue("@celular02", objTabela.Celular02);
                cn.Parameters.AddWithValue("@endereco", objTabela.Endereco);
                cn.Parameters.AddWithValue("@bairro", objTabela.Bairro);
                cn.Parameters.AddWithValue("@cep", objTabela.Cep);
                cn.Parameters.AddWithValue("@cidade", objTabela.Cidade);
                cn.Parameters.AddWithValue("@uf", objTabela.Uf);
                cn.Parameters.AddWithValue("@email", objTabela.Email);
                cn.Parameters.AddWithValue("@altura", objTabela.Altura);
                cn.Parameters.AddWithValue("@peso", objTabela.Peso);
                cn.Parameters.AddWithValue("@id", objTabela.Id);
                cn.Parameters.AddWithValue("@url_foto", objTabela.UrlFoto);

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public int Excluir(AlunosEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Alunos where id = @id";



                cn.Parameters.AddWithValue("@id", objTabela.Id);

                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public List<AlunosEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id, dt_cadastro, nome_alunos, dt_nascimento, rg, cpf, celular01, celular02, endereco, bairro, cep, cidade, uf, email, altura, peso, url_foto  FROM Alunos ORDER BY id DESC";



                cn.Connection = con;

                SqlDataReader dr;
                List<AlunosEnt> lista = new List<AlunosEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AlunosEnt dado = new AlunosEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Dt_cadastro = Convert.ToString(dr["dt_cadastro"]);
                        dado.Nome_alunos = Convert.ToString(dr["nome_alunos"]);
                        dado.Dt_nascimento = Convert.ToString(dr["dt_nascimento"]);
                        dado.Rg = Convert.ToString(dr["rg"]);
                        dado.Cpf = Convert.ToString(dr["cpf"]);
                        dado.Celular01 = dr["celular01"].ToString();
                        dado.Celular02 = Convert.ToString(dr["celular02"]);
                        dado.Endereco = Convert.ToString(dr["endereco"]);
                        dado.Bairro = Convert.ToString(dr["bairro"]);
                        dado.Cep = Convert.ToString(dr["cep"]);
                        dado.Cidade = Convert.ToString(dr["cidade"]);
                        dado.Uf = Convert.ToString(dr["uf"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Altura = Convert.ToString(dr["altura"]);
                        dado.Peso = Convert.ToString(dr["peso"]);
                        dado.UrlFoto = Convert.ToString(dr["url_foto"]);

                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }
    }
}
