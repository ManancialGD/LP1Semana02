using System;
using System.Net;

namespace ChatGPTOne
{
    class Program
    {
        static string question, response;
        static bool isDone = false;
        static void Main(string[] args)
        {

            
            while (!isDone)
            {
                Console.Write("Ask your question: ");
                question = Console.ReadLine();
                switch(question)
                {
                    case "EXIT":
                        isDone = true;
                        break;
                    default:
                        response = "Speak english, alien";
                        Console.WriteLine(response);
                        break;
                }


            }
        }
    }
}
