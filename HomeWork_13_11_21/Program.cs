﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_11_21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGame> games = new List<IGame> { new Beach(), new Fishing(), new Hill(), new Mousetrap(), new Postmen(), new Sea() };
            string[] russianPlayers = new string[15] { "Иван", "Андрей", "Яков", "Юрий", "Татьяна", "Мария", "Авдотья", "Елизавета", "Станислав", "Любава", "Богдан", "Никита", "Владимир", "Любава", "Руслан" };
            string[] francePlayers = new string[15] { "Жоффруа", "Жорж", "Жоржетта", "Жеральд", "Жерар", "Жизель", "Жак", "Жан-луи", "Жозе", "Жозэф", "Изабель", "Жаннет", "Жоан", "Жереми", "Жанна" };
            string[] chinaPlayers = new string[15] { "Айминь", "Гуанхуй", "Минчжу", "Мэйли", "Синьхуа", "Сюин", "Сюли", "Сяомин", "Цзиньхуа", "Чанчунь", "Чуньхау", "Чуньшень", "Юйлань", "Юйминь", "Юйхуа" };
            string[] ukrainePlayers = new string[15] { "Микито", "Левко", "Дмитро", "Олена", "Ярина", "Микола", "Авдотья", "Петро", "Олеся", "Олександра", "Богдан", "Дiана", "Ангелiна", "Данило", "Софiя" };
            Team Russia;
            Team France;
            Team China;
            Team Ukraine;
            foreach (var game in games)
            {
                Russia = new Team("Россия", russianPlayers, game);
                France = new Team("Франция", francePlayers, game);
                China = new Team("Китай", chinaPlayers, game);
                Ukraine = new Team("Украина", ukrainePlayers, game);
                Russia.PlayGame();
                France.PlayGame();
                China.PlayGame();
                Ukraine.PlayGame();
                Console.WriteLine();
            }
        }
    }
}
