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
            CreateRound();
        }
        //Generic 90's DOS intro
        public static void GameIntro()
        {
            Console.WriteLine("\nWelcome to Rock, Paper, Scissors, Lizard, Spock");
            Console.WriteLine("***********************************************\n");
        }
        //Display Rules for Players
        public static void DisplayRules()
        {
            Console.WriteLine("\n                   RULES:");
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Paper disproves Spock and covers Rock");
            Console.WriteLine("Rock crushes Scissors and Lizard");
            Console.WriteLine("Scissors cut Paper and decapitate Lizard");
            Console.WriteLine("Lizard poisons Spock and eats Paper");
            Console.WriteLine("Spock smashes Scissors and vaporizes Rock\n");
        }
        //Create a player instance for Player One and set a name
        public static Player CreatePlayer()
        {
            Player playerOne;
            Console.WriteLine("Player 1, Enter your name: \n");
            string name = Console.ReadLine();
            playerOne = new Human(name, 0, "none");
            return playerOne;

        }

        //Set up decision for 2 player or Human vs. Computer, if neither then re-initiate and try again
        public Player CreateOpponent()
        {
            int gameType;
            Console.WriteLine("\nChoose your adversary:\n1-Human (Two Player game)\n2-Computer\nYour Selection: ");
            gameType = int.Parse(Console.ReadLine());

            if (gameType == 1)
            {
                Console.WriteLine("Player Two, enter your name: ");
                string name = Console.ReadLine();
                playerTwo = new Human(name, 0, "none");
                Console.WriteLine("\nOpponents Confirmed: {0} vs. {1}", playerOne.name, playerTwo.name);
            }
            else if (gameType == 2)
            { 
                playerTwo = new Computer();
                Console.WriteLine("\nOpponents Confirmed: {0} vs. {1}", playerOne.name, playerTwo.name);
            }
            else
            {
                CreateOpponent();
            }
            return playerTwo;

        }
        //Each player chooses their gesture, outputs to console and determines who won the round through DetermineRoundWinner;
        //Conditional to call overall winner if either player has two points (logical winner in best of 3)
        public void CreateRound()
        {
            while(playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.choice = this.playerOne.ChoosePlayerGesture();
                playerTwo.choice = this.playerTwo.ChoosePlayerGesture();
                Console.WriteLine("\n{0} chose {1}", playerOne.name, playerOne.choice);
                Console.WriteLine("{0} chose {1}", playerTwo.name, playerTwo.choice);
                DetermineRoundWinner(playerOne.choice, playerTwo.choice);
            }
            if(playerOne.score == 2 || playerTwo.score == 2)
            {
                OverallWinner();
            }
    
        }

        //Determine the round winner based on Player One's move using if/else if, increment winner score
        public void DetermineRoundWinner(string PlayerOneChoice, string PlayerTwoChoice)
        {
            if (PlayerOneChoice == PlayerTwoChoice)
            {
                Console.WriteLine("Tie Game: No Points Awarded");
            }
            else if (PlayerOneChoice == "Rock"  && (PlayerTwoChoice =="Scissors" || PlayerTwoChoice == "Lizard")){
                PlayerOneWins(PlayerOneChoice, PlayerTwoChoice);
            }
            else if (PlayerOneChoice == "Paper" && (PlayerTwoChoice == "Rock" || PlayerTwoChoice == "Spock"))
            {
                PlayerOneWins(PlayerOneChoice, PlayerTwoChoice);
            }
            else if (PlayerOneChoice == "Scissors" && (PlayerTwoChoice == "Paper" || PlayerTwoChoice == "Lizard")) 
            {
                PlayerOneWins(PlayerOneChoice, PlayerTwoChoice);
            }
            else if (PlayerOneChoice == "Lizard" && (PlayerTwoChoice == "Scissors" || PlayerTwoChoice == "Rock"))
            {
                PlayerOneWins(PlayerOneChoice, PlayerTwoChoice);
            }
            else if (PlayerOneChoice == "Spock" && (PlayerTwoChoice == "Paper" || PlayerTwoChoice == "Lizard"))
            {
                PlayerOneWins(PlayerOneChoice, PlayerTwoChoice);
            }
            else
            {
                PlayerTwoWins(PlayerOneChoice, PlayerTwoChoice);
            }
        }

        //Write Player victories to console, increment appropriate player score
        public void PlayerOneWins(string PlayerOneChoice, string PlayerTwoChoice )
        {
            Console.WriteLine("{0} beats {1}, {2} wins this round!", PlayerOneChoice, PlayerTwoChoice, playerOne.name);
            playerOne.score ++;
        }
        public void PlayerTwoWins(string PlayerOneChoice, string PlayerTwoChoice)
        {
            Console.WriteLine("{0} beats {1}, {2} wins this round!", PlayerTwoChoice, PlayerOneChoice, playerTwo.name);
            playerTwo.score++;
        }

        //Determine overall winner
        public void OverallWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine("\n{0} WINS THE GAME!!!", playerOne.name);
            }
            else
            {
                Console.WriteLine("\n{0} WINS THE GAME!!!", playerTwo.name);
            }
        }
    }
}
