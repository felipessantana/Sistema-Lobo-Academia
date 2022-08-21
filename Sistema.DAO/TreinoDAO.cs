using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.DAO
{
    public class TreinoDAO
    {
        public int Inserir(TreinoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"INSERT INTO Treino (nome_treino) VALUES(@nome_treino)";

                cn.Parameters.AddWithValue("@nome_treino", objTabela.Nome_treino);
                

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }
        public List<TreinoEnt> Buscar(TreinoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id, nome_treino FROM Treino WHERE nome_treino LIKE @nome_treino";

                cn.Parameters.AddWithValue("@nome_treino", objTabela.Nome_treino + "%");

                cn.Connection = con;

                SqlDataReader dr;
                List<TreinoEnt> lista = new List<TreinoEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TreinoEnt dado = new TreinoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome_treino = Convert.ToString(dr["nome_treino"]);
                      

                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }

        public int Editar(TreinoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"UPDATE Treino SET nome_treino = @nome_treino where id = @id";



                cn.Parameters.AddWithValue("@nome_treino", objTabela.Nome_treino);
                cn.Parameters.AddWithValue("@id", objTabela.Id);


                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public int Excluir(TreinoEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"DELETE FROM Treino where id = @id";



                cn.Parameters.AddWithValue("@id", objTabela.Id);

                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        

        public List<TreinoEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id, nome_treino FROM Treino ORDER BY id DESC";


                cn.Connection = con;

                SqlDataReader dr;
                List<TreinoEnt> lista = new List<TreinoEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        TreinoEnt dado = new TreinoEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome_treino = Convert.ToString(dr["nome_treino"]);
                        

                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }
    }
}

