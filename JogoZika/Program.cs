using System;
using System.Collections.Generic;

namespace JogoZika
{
    class Program
    {
        static void Main(string[] args)
        {
            //comentario 
            string nome = "Luiz";
            decimal exp = 5050.500m;
            string classe = "Mago";
            string linhagem = "Humano";
            string cidadeNatal = "Konoha";
            string cidadeAtual = "Aldeia da areia";



            List<Personagem> Personagens = new List<Personagem>();
           

            Personagem personagem = new Personagem(nome, exp, classe, linhagem, cidadeNatal, cidadeAtual);


            //Personagem personagem = new Personagem();
            //personagem.Nome = nome;
            //personagem.Exp = exp;            
            //personagem.Classe = classe;
            //personagem.Linhagem = linhagem;
            //personagem.CidadeNatal = cidadeNatal;
            //personagem.CidadeAtual = cidadeAtual;

            //Personagens.Add(personagem);

            MostrarPesonagem(personagem);



        }
        public static void MostrarPesonagem(Personagem personagem)
        {
            Console.WriteLine("Nome: " + personagem.Nome);
            Console.WriteLine("Experiência: " + personagem.Exp);
            Console.WriteLine("Classe: " + personagem.Classe);
            Console.WriteLine("Linhagem: " + personagem.Linhagem);
            Console.WriteLine("Cidade natal: " + personagem.CidadeNatal);
            Console.WriteLine("Cidade atual: " + personagem.CidadeAtual);
        }
    }
}
