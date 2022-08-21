using Sistema.DAO;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    public class AlunosModel
    {
        public static int Inserir(AlunosEnt objTabela)
        {
            return new AlunosDAO().Inserir(objTabela);
        }

        public List<AlunosEnt> Lista()
        {
            return new AlunosDAO().Lista();
        }

        public static int Excluir(AlunosEnt objTabela)
        {
            return new AlunosDAO().Excluir(objTabela);
        }

        public static int Editar(AlunosEnt objTabela)
        {
            return new AlunosDAO().Editar(objTabela);
        }

        public List<AlunosEnt> Buscar(AlunosEnt objTabela)
        {
            return new AlunosDAO().Buscar(objTabela);
        }

        
    }
}
