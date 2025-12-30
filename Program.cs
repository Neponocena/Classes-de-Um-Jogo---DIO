using System;

namespace JogoAventura
{
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
            int idade;
            if(int.TryParse(Console.ReadLine(), out idade))
            {
                Console.WriteLine("Digite somente números");
                Console.ReadKey();
              
            }
           

            Console.WriteLine("");

            Console.WriteLine("Qual o tipo do Heroi");
            Console.WriteLine(" - Guerreiro");
            Console.WriteLine(" - Mago");
            Console.WriteLine(" - Ninja");
            Console.WriteLine(" - Monge");
            Console.WriteLine("====================");
            Console.WriteLine("Digite o Tipo Escolhido");

           
            string tipo = Console.ReadLine().ToLower();
            Console.WriteLine("=======================");

            Heroi heroi = new Heroi( nome, idade, tipo);

            Console.WriteLine("=====Ataque do Heroi=====");
            Console.WriteLine("");
            heroi.Atacar();

            Console.ReadKey();
            

        }
    }

}