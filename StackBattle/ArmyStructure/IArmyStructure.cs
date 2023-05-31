using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal interface IArmyStructure
    {
        void DoTurn(Army firstArmy, Army secondArmy);
    }
}
