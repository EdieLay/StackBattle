using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal interface IArmyStructure
    {
        bool DoTurn(Army firstArmy, Army secondArmy); // true - смогли сделать ход, false - одна из армий пустая

        void GetAreasInRange(int position, int range, ArmiesRange armies);
    }
}
