using System;
using System.Collections.Generic;
using System.Text;

namespace CatalogoFilmes
{
    public class Filme
    {
        public string nome;
        public string genero;
        public int ano;
        public int duracao;
        public string estudio, diretor, pais;

        public Filme(string nome, string genero, int ano, int duracao, string estudio,
            string diretor, string pais)
        {
            this.nome = nome;
            this.genero = genero;
            this.ano = ano;
            this.duracao = duracao;
            this.estudio = estudio;
            this.diretor = diretor;
            this.pais = pais;
        }
    }
}
