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
        public List<string> gestureChoices;

        //Constructor to add choices for gesture
        public Player()
        {
           //Create a list of Gesture Choices for player to select
           this.gestureChoices = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        public virtual string ChoosePlayerGesture()
        {
            Random random = new Random();
            int randomInt = random.Next(5);
            return this.gestureChoices[randomInt];
        }


    }
}