using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Battle
    {
        Army FirstArmy { get; set; }
        Army SecondArmy { get; set; }

        public Battle()
        {
            FirstArmy = new Army();
            SecondArmy = new Army();
        }

        void DoTurn(bool isFirstArmyTurn)
        {

        }
        void ClearField()
        {

        }
    }
}
