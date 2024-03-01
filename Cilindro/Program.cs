using System;

namespace Cilindro
{
    class Program
    {
        static float r;
        static float a;
        static float V;
        static float Sa;

        static void Main(string[] args)
        {
            Console.Write("Enter the radius of a cylinder: ");
            string inputTMP = Console.ReadLine();

            if (float.TryParse(inputTMP, out float radius))
            {
                r = radius;
            }
            else
            {
                Console.WriteLine("Invalid input for radius.");
                return;
            }

            Console.Write("Enter the height of a cylinder: ");
            inputTMP = Console.ReadLine();

            if (float.TryParse(inputTMP, out float altura))
            {
                a = altura;
            }
            else
            {
                Console.WriteLine("Invalid input for height.");
                return;
            }

            V = MathF.PI * r * r * a;
            Console.WriteLine("The Volume of your Cylinder is: {0:F2}", V);

            Sa = 2f * MathF.PI * r * (r + a);
            Console.WriteLine("The Surface Area of your Cylinder is: {0:F2}", Sa);
        }
    }
}
