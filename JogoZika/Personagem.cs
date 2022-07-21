using System;
using System.Collections.Generic;
using System.Text;

namespace JogoZika
{
    class Personagem
    {
        public string nome { get; set; }
        public decimal exp { get; set; }
        public int level { get; set; }
        public string classe { get; set; }
        public string linhagem { get; set; }
        public string cidadeInicial { get; set; }
        public string cidadeAtual { get; set; }

        public Personagem() { }

        public Personagem(string nome, decimal exp, int level, string classe, string linhagem, string cidadeInicial, string cidadeAtual)
        {
            this.nome = nome;
            this.exp = exp;
            this.level = level;
            this.classe = classe;
            this.linhagem = linhagem;
            this.cidadeInicial = cidadeInicial;
            this.cidadeAtual = cidadeAtual;
        }

    }

}

