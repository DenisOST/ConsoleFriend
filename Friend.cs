﻿using System;
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
                return "сегодня ясно и солнечно!";

            if (msg.Contains("анекдот"))
                return "вот тебе анекдот:\r\nЕдут два армяна инвалида по пустыне. Видят лампу, потерли ее и вылез Джин\r\n- Я исполню одно желание. Но вас двое - желание будет пополам на двоих работать\r\nАрмяне посовещались и говорят ему\r\n- Мы хотим снова ходить\r\n- Хорошо. Но желание надо разделить, ходить вы будете по очереди\r\nИ выдал им нарды";

            if (msg.Contains("экзамен"))
                return "экзамен по Тестированию будет 10 мая, подготовься!";

            return "Я тебя не понимаю. Спроси что-нибудь другое.";
        }

        public static bool ShouldExit(string input)
        {
            var msg = input.ToLower();
            return msg == "пока" || msg == "выход";
        }
    }
}
