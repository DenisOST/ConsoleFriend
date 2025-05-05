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

        public static string GetResponse(string message)
        {
            var msg = message.ToLower();

            if (msg.Contains("погода"))
                return "Сегодня ясно и солнечно!";

            return "Я тебя не понимаю. Спроси что-нибудь другое.";
        }
    }
}
