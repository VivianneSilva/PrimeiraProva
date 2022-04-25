using System;

namespace ProvaJogo
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int resposta = 3;
            int palpite;
            int jogadas = 0;
            int tentativas = 5;
            string[] errou = {
                "Voce errou!!!",
                "iiiiih, errado",
                "Não foi desta vez!",
                "Ta dificil é?!"
            };
            
            while (tentativas > 0)
            {
                    Random random = new Random();
                    int frase = random.Next(0, 4);

                    Console.WriteLine("Digite seu palpite de 0 a 10");
                palpite = int.Parse(Console.ReadLine());
                tentativas--;
                jogadas++;
                if (palpite == resposta)
                {
                    Console.WriteLine("Parabens voce acertou!");
                    Console.WriteLine($"Foram necessarias {jogadas} jogadas");
                    Console.WriteLine($"Restou apenas {tentativas} tentativas");
                    tentativas = 0;
                }
                else
                {
                    Console.WriteLine(errou[frase]);

                    Console.WriteLine($"Resta apenas {tentativas} tentativas");

                }
               
            }
            Console.WriteLine("Tentativas Esgotadas!!! Reinicie o jogo para jogar Novamente.");
        
        }
    }
}
