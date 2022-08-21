using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Entidades
{
    public class TreinoEnt
    {
        private int id;
        private string nome_treino;

        public int Id { get => id; set => id = value; }
        public string Nome_treino { get => nome_treino; set => nome_treino = value; }
    }
}
