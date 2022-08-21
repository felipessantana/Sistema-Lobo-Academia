using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAO;


namespace Sistema.Model
{
    public class FuncionariosModel
    {


        public List<FuncionarioEnt> Lista()
        { 
            return new FuncionariosDAO().Lista();
        }

        public static int Inserir(FuncionarioEnt objTabela)
        {
            return new FuncionariosDAO().Inserir(objTabela);
        }

        public static int Editar(FuncionarioEnt objTabela) 
        {
            return new FuncionariosDAO().Editar(objTabela);
        }

        public List<FuncionarioEnt> Buscar(FuncionarioEnt objTabela) 
        {
            return new FuncionariosDAO().Buscar(objTabela);

        }

        public static int Excluir(FuncionarioEnt objTabela)
        {
            return new FuncionariosDAO().Excluir(objTabela);
        }
        
    }
}
