using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS2
{
    abstract class Player
    {
        //player attributes
        public string name;
        public int score;
        public string choice;

        //Create a list of Gesture Choices for player to select
        public List<string> GestureChoices = new List<string>();

        //Constructor to add choices for gesture
        public Player()
        {
            GestureChoices.Add("Rock");
            GestureChoices.Add("Paper");
            GestureChoices.Add("Scissors");
            GestureChoices.Add("Lizard");
            GestureChoices.Add("Spock");
        }

        //Usable by players, do not need to define here
        public abstract void playersChoice();

    }
