using System;
using System.Data.SqlTypes;
using System.IO.Compression;

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
            
            string ataque = "ataque desconhecido";

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

}