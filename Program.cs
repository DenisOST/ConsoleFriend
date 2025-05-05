using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFriend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как тебя зовут? ");
            var name = Console.ReadLine();
            Console.WriteLine(Friend.GetGreeting(name));

            while (true)
            {
                Console.Write("Ты: ");
                var input = Console.ReadLine();

                if (input == "пока" || input == "выход")
                {
                    Console.WriteLine("Пока! Был рад пообщаться.");
                    break;
                }

                Console.WriteLine("Друг: " + Friend.GetResponse(input));
            }
        }
    }
}
