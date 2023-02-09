using System;

namespace ativ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double N1, N2, N3, N4, N5, soma, mediana, media;

            Console.WriteLine("Escreva o primeiro numero");
            N1 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escreva o segundo numero");
            N2 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escreva o terceiro numero");
            N3 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escreva o quarto numero");
            N4 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Escreva o quinto numero");
            N5 = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            mediana = N3;

            soma = N1 + N2 + N3 + N4 + N5;

            media = N1 + N2 + N3 + N4 + N5;

            media = media / 5;

            Console.WriteLine("MÉDIA" + media);
            Console.WriteLine("Mediana" + mediana);
            Console.WriteLine("Soma" + soma);
            Console.ReadKey();
        }
    }
}
 
