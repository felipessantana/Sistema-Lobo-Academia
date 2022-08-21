using Sistema.DAO;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    public class TreinoModel
    {
        public static int Inserir(TreinoEnt objTabela)
        {
            return new TreinoDAO().Inserir(objTabela);
        }
        public List<TreinoEnt> Lista()
        {
            return new TreinoDAO().Lista();
        }

        public static int Excluir(TreinoEnt objTabela)
        {
            return new TreinoDAO().Excluir(objTabela);
        }

        public static int Editar(TreinoEnt objTabela)
        {
            return new TreinoDAO().Editar(objTabela);
        }

        public List<TreinoEnt> Buscar(TreinoEnt objTabela)
        {
            return new TreinoDAO().Buscar(objTabela);
        }
    }
}
