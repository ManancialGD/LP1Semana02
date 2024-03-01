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
                    case "Shush":
                        response = "...";
                        Console.WriteLine(response);
                        break;
                    case "あ":
                        response = "Why you speaking chinese?";
                        Console.WriteLine(response);
                        break;
                    case "Cristiano Ronaldo":
                        response = "Siiuuuuuuu";
                        Console.WriteLine(response);
                        break;
                    case "":
                        response = "Nice choice of words";
                        Console.WriteLine(response);
                        break;
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
