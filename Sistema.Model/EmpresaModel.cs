using Sistema.DAO;
using Sistema.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Model
{
    public class EmpresaModel
    {
        public static int Inserir(EmpresaEnt objTabela)
        {
            return new EmpresaDAO().Inserir(objTabela);
        }

        public List<EmpresaEnt> Lista()
        {
            return new EmpresaDAO().Lista();
        }

        public static int Excluir(EmpresaEnt objTabela)
        {
            return new EmpresaDAO().Excluir(objTabela);
        }

        public static int Editar(EmpresaEnt objTabela)
        {
            return new EmpresaDAO().Editar(objTabela);
        }

        public List<EmpresaEnt> Buscar(EmpresaEnt objTabela)
        {
           return new EmpresaDAO().Buscar(objTabela);
        }
    }
}
