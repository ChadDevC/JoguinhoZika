using System;
using System.Collections.Generic;
using System.Text;

namespace JogoZika
{
    public class Personagem
    {
        //up
        public string Nome { get; set; }
        public decimal Exp { get; set; }



        public string Classe { get; set; }
        public string Linhagem { get; set; }
        public string CidadeNatal { get; set; }
        public string CidadeAtual { get; set; }

        public int Level
        {
            get
            {
                int nivel = 1;
                if (Exp > 100) { nivel = 2;}
                if (Exp > 200) { nivel = 3;}
                if (Exp > 300) { nivel = 4;}


                int level = nivel;
                return level;

            }

        }

        public Personagem() { }

        public Personagem(
        string Nome,
        decimal Exp,
        string Classe,
        string Linhagem,
        string CidadeNatal,
        string CidadeAtual)
        {
            this.Nome = Nome;
            this.Exp = Exp;
            this.Classe = Classe;
            this.Linhagem = Linhagem;
            this.CidadeNatal = CidadeNatal;
            this.CidadeAtual = CidadeAtual;
        }
    }
}
