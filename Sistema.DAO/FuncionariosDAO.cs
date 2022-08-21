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
    public class FuncionariosDAO
    {
        public int Inserir(FuncionarioEnt objTabela)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"INSERT INTO Funcionarios (dt_cadastro, nome_funcionario, dt_nascimento, rg, cpf, confef, cargo, cep, 
                                                            endereco, bairro, cidade, uf, email, telefone, url_foto ) 
                                                            VALUES(@dt_cadastro, @nome_funcionario, @dt_nascimento, @rg, @cpf, @confef, @cargo, @cep, 
                                                            @endereco, @bairro, @cidade, @uf,  @email, @telefone, @url_foto)";

                cn.Parameters.AddWithValue("@dt_cadastro", objTabela.Dt_cadastro);
                cn.Parameters.AddWithValue("@nome_funcionario", objTabela.Nome_funcionario);
                cn.Parameters.AddWithValue("@dt_nascimento", objTabela.Dt_nascimento);
                cn.Parameters.AddWithValue("@rg", objTabela.Rg);
                cn.Parameters.AddWithValue("@cpf", objTabela.Cpf);
                cn.Parameters.AddWithValue("@confef", objTabela.Confef);
                cn.Parameters.AddWithValue("@cargo", objTabela.Cargo);
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

        public List<FuncionarioEnt> Buscar(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id, dt_cadastro, nome_funcionario, dt_nascimento, rg, cpf, confef, cargo, cep, 
                                                endereco, bairro,  CONCAT(CIDADE,' - ',UF) AS CIDADE, email, telefone  
                                                FROM Funcionarios WHERE nome_funcionario LIKE @nome_funcionario";

                cn.Parameters.AddWithValue("@nome_funcionario", objTabela.Nome_funcionario + "%");

                cn.Connection = con;

                SqlDataReader dr;
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncionarioEnt dado = new FuncionarioEnt();
                        dado.Id                     = Convert.ToInt32(dr["id"]);
                        dado.Dt_cadastro            = Convert.ToString(dr["dt_cadastro"]);
                        dado.Nome_funcionario       = Convert.ToString(dr["nome_funcionario"]);
                        dado.Dt_nascimento          = Convert.ToString(dr["dt_nascimento"]);
                        dado.Rg                     = Convert.ToString(dr["rg"]);
                        dado.Cpf                    = Convert.ToString(dr["cpf"]);
                        dado.Confef                 = Convert.ToString(dr["confef"]);
                        dado.Cargo                  = Convert.ToString(dr["cargo"]);
                        dado.Cep                    = Convert.ToString(dr["cep"]);
                        dado.Endereco               = Convert.ToString(dr["endereco"]);
                        dado.Bairro                 = Convert.ToString(dr["bairro"]);
                        dado.Cidade                 = Convert.ToString(dr["cidade"]);
                        dado.Email                  = Convert.ToString(dr["email"]);
                        dado.Telefone               = Convert.ToString(dr["telefone"]);
                        


                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }

        public int Editar(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"UPDATE Funcionarios SET dt_cadastro = @dt_cadastro, nome_funcionario = @nome_funcionario, 
dt_nascimento = @dt_nascimento, rg = @rg, cpf = @cpf, confef = @confef, 
cargo = @cargo, cep = @cep, endereco = @endereco, bairro = @bairro, cidade = @cidade, 
uf = @uf, email = @email, telefone = @telefone, url_foto = @url_foto where id = @id";



                cn.Parameters.AddWithValue("@dt_cadastro", objTabela.Dt_cadastro);
                cn.Parameters.AddWithValue("@nome_funcionario", objTabela.Nome_funcionario);
                cn.Parameters.AddWithValue("@dt_nascimento", objTabela.Dt_nascimento);
                cn.Parameters.AddWithValue("@rg", objTabela.Rg);
                cn.Parameters.AddWithValue("@cpf", objTabela.Cpf);
                cn.Parameters.AddWithValue("@confef", objTabela.Confef);
                cn.Parameters.AddWithValue("@cargo", objTabela.Cargo);
                cn.Parameters.AddWithValue("@cep", objTabela.Cep);
                cn.Parameters.AddWithValue("@endereco", objTabela.Endereco);
                cn.Parameters.AddWithValue("@bairro", objTabela.Bairro);
                cn.Parameters.AddWithValue("@cidade", objTabela.Cidade);
                cn.Parameters.AddWithValue("@uf", objTabela.Uf);
                cn.Parameters.AddWithValue("@email", objTabela.Email);
                cn.Parameters.AddWithValue("@telefone", objTabela.Telefone);
                cn.Parameters.AddWithValue("@url_foto", objTabela.UrlFoto);
                cn.Parameters.AddWithValue("@id", objTabela.Id);


                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public int Excluir(FuncionarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"DELETE FROM Funcionarios where id = @id";



                cn.Parameters.AddWithValue("@id", objTabela.Id);

                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public List<FuncionarioEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id, dt_cadastro, nome_funcionario, dt_nascimento, rg, cpf, confef, cargo, cep, endereco, bairro, 
 CONCAT(CIDADE,' - ',UF) AS CIDADE, email, url_foto, telefone  FROM Funcionarios ORDER BY id DESC";


                cn.Connection = con;

                SqlDataReader dr;
                List<FuncionarioEnt> lista = new List<FuncionarioEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        FuncionarioEnt dado = new FuncionarioEnt();
                        dado.Id                     = Convert.ToInt32(dr["id"]);
                        dado.Dt_cadastro            = Convert.ToString(dr["dt_cadastro"]);
                        dado.Nome_funcionario       = Convert.ToString(dr["nome_funcionario"]);
                        dado.Dt_nascimento          = Convert.ToString(dr["dt_nascimento"]);
                        dado.Rg                     = Convert.ToString(dr["rg"]);
                        dado.Cpf                    = Convert.ToString(dr["cpf"]);
                        dado.Confef                 = Convert.ToString(dr["confef"]);
                        dado.Cargo                  = Convert.ToString(dr["cargo"]);
                        dado.Cep                    = Convert.ToString(dr["cep"]);
                        dado.Endereco               = Convert.ToString(dr["endereco"]);
                        dado.Bairro                 = Convert.ToString(dr["bairro"]);
                        dado.Cidade                 = Convert.ToString(dr["cidade"]);
                        dado.Email                  = Convert.ToString(dr["email"]);
                        dado.Telefone               = Convert.ToString(dr["telefone"]);
                        dado.UrlFoto                = Convert.ToString(dr["url_foto"]);

                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }

    }
}
