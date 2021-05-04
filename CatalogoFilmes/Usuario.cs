using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoFilmes
{
    public class Usuario
    {
        public string login;
        public string senha;
        public List<Filme> filmesParaAssistir;
        public List<Filme> filmesAssistidos;

        public Usuario(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
            this.filmesParaAssistir = new List<Filme>();
            this.filmesAssistidos = new List<Filme>();
        }

        public bool verificarSenha(string login, string senha)
        {
            if(this.login.Equals(login) && this.senha.Equals(senha))
            {
                return true;
            }
            return false;
        }


    }
}
