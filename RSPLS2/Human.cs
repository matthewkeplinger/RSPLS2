using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS2
{
    class Human : Player
    {
        public override void PlayersChoice()
        {
            Console.WriteLine("Choose a number for the corresponding gesture:\n1-Rock\n2-Paper\n3-Scissors\n4-Lizard\n5-Spock");

        }
    }
}
