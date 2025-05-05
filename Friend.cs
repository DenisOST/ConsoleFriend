using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFriend
{
    public class Friend
    {
        public static string GetGreeting(string name)
        {
            return $"Привет, {name}! Как дела?";
        }
    }
}
