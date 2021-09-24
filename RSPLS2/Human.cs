using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS2
{
    class Human : Player
    {
        public Human(string name, int score, string choice)
        {
            this.name = name;
            this.score = score;
            this.choice = choice;
        }
        public override string ChoosePlayerGesture()
        {
            Console.WriteLine("\n{0}, Choose your move (Enter the number next to the move):\n1-Rock\n2-Paper\n3-Scissors\n4-Lizard\n5-Spock\nYour Selection: ", this.name);
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;
            return this.gestureChoices[choice];

            
        }
    }
}
