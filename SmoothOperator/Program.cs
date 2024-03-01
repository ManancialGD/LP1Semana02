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

                // Operação de decremento
                n = (byte)(n - 1);
                Console.WriteLine($"Resultado da operação de decremento de n: {n}");

                // Operação de incremento
                n = (byte)(n + 1);
                Console.WriteLine($"Resultado da operação de incremento de n: {n}");

                // Operação de divisão por 2
                n = (byte)(n / 2);
                Console.WriteLine($"Resultado da operação de divisão por 2 de n: {n}");

                // Operação de shift left por 3
                n = (byte)(n << 3);
                Console.WriteLine($"Resultado da operação de shift left por 3 de n: {n}");

                // Operação de XOR com 5
                n = (byte)(n ^ 5);
                Console.WriteLine($"Resultado da operação de XOR com 5 de n: {n}");

                // Verifica se é maior que 10
                bool isMaiorQue10 = n > 10;
                Console.WriteLine($"É maior que 10? {isMaiorQue10}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Certifique-se de inserir um número inteiro não-negativo.");
            }
        }
    }
}
