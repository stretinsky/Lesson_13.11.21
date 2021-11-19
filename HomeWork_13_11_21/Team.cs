using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_13_11_21
{
    class Team
    {
        public string country;
        public string[] players;
        public IGame Game;
        public Team(string country, string[] players, IGame game)
        {
            this.country = country;
            this.players = players;
            Game = game;
        }
        public void PlayGame()
        {
            Console.Write($"{country} --> ");
            Game.PlayGame();
        }
    }
}
