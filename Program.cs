using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terminal_intro_c_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Initializing a project
            Console.WriteLine("Welcome to Introduction to C#");
            Console.WriteLine("What is your name?");

            var name = Console.ReadLine();
            Console.WriteLine($"Greetings {name} I'm pleased to meet you.\n What is your age?");
            var age = Console.ReadLine();

            Console.WriteLine($"How wonderful. Correct me if im wrong.. Your name is {name} and you're {age} years old?");
            var answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine($"How awesome, i'm happy i had the chance to meet you ! {name}");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine(" Im sad to hear that i was wrong, but its okay.");
                Console.ReadKey();
            }
            return;
        }
    }
}
