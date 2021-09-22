using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS2
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        public Game()
        {
            this.playerOne = SetUpPlayerOne;
            this.playerTwo = GameType();
        }

        public void RunGame()
        {
            GameIntro();
            DisplayRules();
            GameType();
        }

        public static void GameIntro()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("***********************************************");
        }

        public static void DisplayRules()
        {
            Console.WriteLine("RULES:");
            Console.WriteLine("__________________________________________________________________________________");
            Console.WriteLine("The game is a first to 3 format played either against another human, or a computer");
            Console.WriteLine("Each player will choose a gesture");
            Console.WriteLine("Paper disproves Spock and covers Rock");
            Console.WriteLine("Rock crushes Scissors and Lizard");
            Console.WriteLine("Scissors cut Paper and decapitate Lizard");
            Console.WriteLine("Lizard poisons Spock and eats Paper");
            Console.WriteLine("Spock smashes Scissors and vaporizes Rock");
        }

        //Set up decision for 2 player or Human vs. Computer
        public void GameType()
        {
            int gameType;
            Console.WriteLine("Choose your adversary:\n1-Human (Two Player game)\n2-Computer");
            gameType = int.Parse(Console.ReadLine());

            if (gameType == 1)
            {
                playerTwo = new Human("Player Two");
                Console.WriteLine("A Duel!");
            }
            else if (gameType == 2)
            { 
                playerTwo = new Computer();
                Console.WriteLine("Don't let the machines win!");
            }

        }

        public void RoundWinner()
        {
            if (PlayerOne.choice == PlayerTwo.choice)
            {
                Console.WriteLine("Tie Game: No Points Awarded");
            }
            else if (PlayerOne.choice == 1 && (PlayerTwo.choice == 3 || PlayerTwo.choice == 4)){
                Console.WriteLine("Player One Wins!");
            }
        }

    }
}
