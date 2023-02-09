using System;

namespace ativ3
{
    class Program
    {
        static void Main(string[] args)
        {
            string jogador1, jogador2;
            string palavra1, palavra2, palavra3, palavra4, palavra5;
            string palavraDoJogo;
            string palavra;
            int tentativas1 = 0, tentativas2 = 0;
            string vencedor;

            Console.WriteLine("Digite o nome do jogador 1: ");
            jogador1 = Console.ReadLine();

            Console.WriteLine("Digite o nome do jogador 2:");
            jogador2 = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("--- " + jogador1 + ", suas 5 palavras ---");
            Console.WriteLine("Digite a 1° palavra:");
            palavra1 = Console.ReadLine();
            Console.WriteLine("Digite a 2 palavra:");
            palavra2 = Console.ReadLine();
            Console.WriteLine("Digite a 3 palavra:");
            palavra3 = Console.ReadLine();
            Console.WriteLine("Digite a 4 palavra:");
            palavra4 = Console.ReadLine();
            Console.WriteLine("Digite a 5 palavra:");
            palavra5 = Console.ReadLine();

            Console.Clear();

            Random randNum = new Random();
            int num = randNum.Next(4);

            if (num == 0)
            {
                palavraDoJogo = palavra1;
            }
            else if (num == 1)
            {
                palavraDoJogo = palavra2;
            }
            else if (num == 2)
            {
                palavraDoJogo = palavra3;
            }
            else if (num == 3)
            {
                palavraDoJogo = palavra4;
            }
            else
            {
                palavraDoJogo = palavra5;
            }

            do
            {
                tentativas2++;
                Console.WriteLine(jogador2 + " tente adivinhar a palavra: ");
                palavra = Console.ReadLine();
            } while (palavra != palavraDoJogo);

            Console.Clear();

            Console.WriteLine(jogador2 + " adivinhou em " + tentativas2 + " tentativas.");

            Console.WriteLine("\n --- " + jogador2 + ", suas 5 palavras ---");
            Console.WriteLine("Digite a 1° palavra:");
            palavra1 = Console.ReadLine();
            Console.WriteLine("Digite a 2 palavra:");
            palavra2 = Console.ReadLine();
            Console.WriteLine("Digite a 3 palavra:");
            palavra3 = Console.ReadLine();
            Console.WriteLine("Digite a 4 palavra:");
            palavra4 = Console.ReadLine();
            Console.WriteLine("Digite a 5 palavra:");
            palavra5 = Console.ReadLine();

            Console.Clear();

            Random randNum2 = new Random();
            int num2 = randNum.Next(4);

            if (num2 == 0)
            {
                palavraDoJogo = palavra1;
            }
            else if (num2 == 1)
            {
                palavraDoJogo = palavra2;
            }
            else if (num2 == 2)
            {
                palavraDoJogo = palavra3;
            }
            else if (num2 == 3)
            {
                palavraDoJogo = palavra4;
            }
            else
            {
                palavraDoJogo = palavra5;
            }

            do
            {
                tentativas1++;
                Console.WriteLine("Tente adivinhar a palavra: ");
                palavra = Console.ReadLine();
            } while (palavra != palavraDoJogo);

            Console.Clear();

            Console.WriteLine(jogador1 + " adivinhou em " + tentativas1 + " tentativas");

            if (tentativas1 > tentativas2)
            {
                vencedor = jogador2;
            }
            else if (tentativas1 < tentativas2)
            {
                vencedor = jogador1;
            }
            else
            {
                vencedor = "empate";
            }

            Console.WriteLine("O vencedor foi " + vencedor + " \n Obrigado por jogar :o");

            Console.ReadKey();
        }
    }
}
