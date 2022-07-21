using System;
using System.Collections.Generic;
using System.Linq;

namespace JogoZika
{
    class Program
    {

        static void Main(string[] args)
        {
            string nome = "Bigodezinho";
            decimal exp = 5050.50m;
            int level = 100;
            string classe = "Ladino";
            string linhagem = "Meio-Elfo";
            string cidadeInicial = "Konoha";
            string cidadeAtual = "Aldeia da areia";

            List<Personagem> Personagem = new List<Personagem>();
            Personagem personagem = new Personagem();

            personagem.nome = nome;
            personagem.exp= exp;
            personagem.level= level;
            personagem.classe = classe;
            personagem.linhagem= linhagem;
            personagem.cidadeInicial= cidadeInicial;
            personagem.cidadeAtual = cidadeAtual;

            MostrarPesonagem(personagem);
            
        }
        public static void MostrarPesonagem(Personagem personagem)
        {
            Console.WriteLine("Nome: " + personagem.nome);
            Console.WriteLine("Experiência: " + personagem.exp);
            Console.WriteLine("Level: " + personagem.level);
            Console.WriteLine("Classe: " + personagem.classe);
            Console.WriteLine("Linhagem: " + personagem.linhagem);
            Console.WriteLine("Cidade natal: " + personagem.cidadeInicial);
            Console.WriteLine("Cidade atual: " + personagem.cidadeAtual);
        }
    }
}
