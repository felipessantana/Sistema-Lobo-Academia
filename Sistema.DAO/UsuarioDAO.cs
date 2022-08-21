using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sistema.Entidades;

namespace Sistema.DAO
{
    public class UsuarioDAO
    {
        public int Inserir(UsuarioEnt objTabela)
        {

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"INSERT INTO Usuarios (nome, usuario, senha) VALUES(@nome, @usuario, @senha)";
                
                cn.Parameters.AddWithValue("@nome", objTabela.Nome);
                cn.Parameters.AddWithValue("@usuario", objTabela.Usuario);
                cn.Parameters.AddWithValue("@senha", objTabela.Senha);
                
                
                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public int Editar(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"UPDATE Usuarios SET nome = @nome, usuario = @usuario, senha = @senha where id = @id";

               

                cn.Parameters.AddWithValue("@nome", objTabela.Nome);
                cn.Parameters.AddWithValue("@usuario", objTabela.Usuario);
                cn.Parameters.AddWithValue("@senha", objTabela.Senha);
                cn.Parameters.AddWithValue("@id", objTabela.Id);

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public int Excluir(UsuarioEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"DELETE FROM usuarios where id = @id";


                
                cn.Parameters.AddWithValue("@id", objTabela.Id);
                
                cn.Connection = con;


                int qtd = cn.ExecuteNonQuery();
                Console.Write(qtd);
                return qtd;

            }
        }

        public List<UsuarioEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = @"SELECT id,nome,usuario,senha FROM Usuarios ORDER BY id DESC";

              
                cn.Connection = con;

                SqlDataReader dr;
                List<UsuarioEnt> lista = new List<UsuarioEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);
                        

                        lista.Add(dado);
                    }
                }
                return lista;

            }
        }

        public UsuarioEnt Login(UsuarioEnt obj)
        {
            using (SqlConnection con = new SqlConnection())

            {
                con.ConnectionString = Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                
                cn.CommandText = @"SELECT USUARIO, SENHA from Usuarios where usuario = @usuario AND senha = @senha";

               
                cn.Parameters.AddWithValue("@usuario", obj.Usuario);
                cn.Parameters.AddWithValue("@senha", obj.Senha);
                cn.Connection = con;


                SqlDataReader dr;


                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        UsuarioEnt dado = new UsuarioEnt();
                        dado.Usuario = Convert.ToString(dr["usuario"]);
                        dado.Senha = Convert.ToString(dr["senha"]);

                    }
                    return obj;
                }
                else
                {
                    obj.Usuario = null;
                    obj.Senha = null;
                    return null;
                }
                


            }
        }

       
    }
}
