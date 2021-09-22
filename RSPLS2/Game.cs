using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS2
{
    public class Game
    {
        public void RunGame()
        {
            GameIntro();
            DisplayRules();
        }

        public void GameIntro()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("***********************************************");
        }

        public void DisplayRules()
        {
            Console.WriteLine("The game is a best of 3 format played either against another human, or a computer");
            Console.WriteLine("Each player will choose a gesture");
            Console.WriteLine("Paper disproves Spock and covers Rock");
            Console.WriteLine("Rock crushes Scissors and Lizard");
            Console.WriteLine("Scissors cut Paper and decapitate Lizard");
            Console.WriteLine("Lizard poisons Spock and eats Paper");
            Console.WriteLine("Spock smashes Scissors and vaporizes Rock");
        }

    }
}
