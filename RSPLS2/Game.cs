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
            this.playerOne = CreatePlayer();
            this.playerTwo = CreateOpponent();
        }

        public void RunGame()
        {
            GameIntro();
            DisplayRules();
        }
        //Generic 90's DOS intro
        public static void GameIntro()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("***********************************************");
        }
        //Display Rules for Players
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
        //Create a player instance for Player One and set a name
        public static Player CreatePlayer()
        {
            Player playerOne;
            Console.WriteLine("Player 1, Enter your name: ");
            string name = Console.ReadLine();
            playerOne = new Human(name, 0, "none");
            return playerOne;

        }

        //Set up decision for 2 player or Human vs. Computer
        public Player CreateOpponent()
        {
            int gameType;
            Console.WriteLine("Choose your adversary:\n1-Human (Two Player game)\n2-Computer");
            gameType = int.Parse(Console.ReadLine());

            if (gameType == 1)
            {
                Console.WriteLine("Player Two, enter your name: ");
                string name = Console.ReadLine();
                playerTwo = new Human(name, 0, "none");
                Console.WriteLine("A Duel!");
            }
            else if (gameType == 2)
            { 
                playerTwo = new Computer();
                Console.WriteLine("Don't let the machines win!");
            }
            return playerTwo;

        }

        public void CreateRound()
        {
            while(playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.choice = this.playerOne.ChoosePlayerGesture();
                Console.WriteLine("{0} chose {1}", playerOne.name, playerOne.choice);
                playerTwo.choice = this.playerTwo.ChoosePlayerGesture();
                Console.WriteLine("{0} chose {1}", playerTwo.name, playerTwo.choice);
                DetermineRoundWinner(playerOne.choice, playerTwo.choice);

            }
            if(playerOne.score == 2)
            {
                Console.WriteLine("{0} Wins!", playerOne.name);
            }
            else
            {
                Console.WriteLine("{0} Wins!", playerTwo.name);
            }
        }
        //Determine the round winner based on Player One's move using if/else if, increment winner score
        public void DetermineRoundWinner(string p1Choice, string p2Choice)
        {
            if (p1Choice == p2Choice)
            {
                Console.WriteLine("Tie Game: No Points Awarded");
            }
            else if (p1Choice == "Rock"  && (p2Choice =="Scissors" || p2Choice == "Lizard")){
                PlayerOneWins();
            }
            else if (p1Choice == "Paper" && (p2Choice == "Rock" || p2Choice == "Spock"))
            {
                PlayerOneWins();
            }
            else if (p1Choice == "Scissors" && (p2Choice == "Paper" || p2Choice == "Lizard")) 
            { 
                PlayerOneWins();
            }
            else if (p1Choice == "Lizard" && (p2Choice == "Scissors" || p2Choice == "Rock"))
            {
                PlayerOneWins();
            }
            else if (p1Choice == "Spock" && (p2Choice == "Paper" || p2Choice == "Lizard"))
            {
                PlayerOneWins();
            }
            else
            {
                Console.WriteLine("{0} Wins!", playerTwo.name);
                playerTwo.score ++;
            }
        }

        public void PlayerOneWins()
        {
            Console.WriteLine("{0} Wins!", playerOne.name);
            playerOne.score ++;
        }
            

    }
}
