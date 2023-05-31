using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class StackStructure : IArmyStructure
    {
        public bool DoTurn(Army firstArmy, Army secondArmy)
        {
            if (firstArmy.Units.Count == 0 || secondArmy.Units.Count == 0) 
                return false;

            secondArmy[0].TakeDamage(firstArmy[0].Attack);
            firstArmy[0].TakeDamage(secondArmy[0].Attack);
            

            return true;
        }
    }
}
