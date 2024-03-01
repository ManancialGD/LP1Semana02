using System;

namespace SmoothOperator
{
    class Program
    {
        static byte n;

        static void Main(string[] args)
        {
            Console.Write("Insira um número inteiro não-negativo: ");

            if (byte.TryParse(Console.ReadLine(), out byte userInput))
            {
                n = userInput;

                n = (byte)(n - 1);
                Console.WriteLine(n);

                n = (byte)(n + 1);
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro não-negativo.");
            }
        }
    }
}
