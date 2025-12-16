using System;
using System.Data.SqlTypes;

namespace JogoAventura
{
    public class Heroi
    {
        public string Nome {get; set; }
        public int Idade{get;set; }
        public string Tipo {get;set; }

        public Heroi(string nome, int idade, string tipo)
        {
            Nome = nome;
            Idade = idade;
            Tipo = tipo;
        }

        public void Atacar()
        {
            string ataque = "ataque desconheido";

            switch (Tipo)
            {
                case "mago": ataque = "Magia"; break;
                case "guerreiro": ataque = "Espada"; break;
                case "monge": ataque = "Artes Marciais"; break;
                case "ninja": ataque = "Shuriken"; break;
                default: break;
            }

            Console.WriteLine($"{Tipo} {Nome} atacou usando {ataque}");
        }


    }

        class Program
    {
        static void Main(String[] args)
        {

            Console.Clear();

            Console.WriteLine("Seu Heroi");
            Console.WriteLine("-----------");

            Console.WriteLine("Nome do Heroi");
            Console.WriteLine("==============");
            string nome = Console.ReadLine();
            
            Console.WriteLine("");

            Console.WriteLine("Idade do heroi");
            Console.WriteLine("===============");
            int idade = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            Console.WriteLine("Qual o tipo do Heroi");
            Console.WriteLine(" - guerreiro");
            Console.WriteLine(" - mago");
            Console.WriteLine(" - ninja");
            Console.WriteLine(" - monge");
            Console.WriteLine("====================");
            Console.WriteLine("Digite o Tipo Escolhido");

            string tipo = Console.ReadLine();
            Console.WriteLine("=======================");

            Heroi heroi = new Heroi( nome, idade, tipo);

            Console.WriteLine("=====Ataque do Heroi=====");
            Console.WriteLine("");
            heroi.Atacar();

            Console.ReadKey();
        }
    }

}