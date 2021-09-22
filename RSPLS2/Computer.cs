using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS2
{
    class Computer : Player
    {
        public Computer()
        {
            this.name = "Computer";
        }
        public override void PlayersChoice()
        {
            throw new NotImplementedException();
        }
    }
}
