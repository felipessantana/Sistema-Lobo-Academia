﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema.DAO;
using Sistema.Entidades;


namespace Sistema.Model
{
    public class UsuarioModel
    {
        public static int Inserir(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Inserir(objTabela);
        }

        public UsuarioEnt Login(UsuarioEnt obj)
        {
            return new UsuarioDAO().Login(obj);
        }

        public List<UsuarioEnt> Lista()
        {
            return new UsuarioDAO().Lista();
        }

        public static int Excluir(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Excluir(objTabela);
        }

        public static int Editar(UsuarioEnt objTabela)
        {
            return new UsuarioDAO().Editar(objTabela);
        }
    }
}
