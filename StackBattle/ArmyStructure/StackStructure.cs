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

            int maxArmyLength = Math.Max(firstArmy.ArmySize, secondArmy.ArmySize);
            for (int i = 0; i < maxArmyLength; i++)
            {
                if (i < firstArmy.ArmySize)
                {
                    if (firstArmy[i] is ISpecialAbility saunit)
                    {
                        ArmiesRange armies = new ArmiesRange(firstArmy, secondArmy);
                        GetAreasInRange(i, saunit.Range, armies);
                        saunit.Action(armies);
                    }
                }
            }

            return true;
        }

        public void GetAreasInRange(int position, int range, ArmiesRange armies)
        {
            int armyStartInRange = position - range < 0 ? 0 : position - range;
            int armyEndInRange = position + range >= armies.friendlyArmy.ArmySize ? armies.friendlyArmy.ArmySize - 1 : position + range;
            for (int i = armyStartInRange; i < position; i++)
                armies.fArea.Add(i);
            for (int i = position + 1; i <= armyEndInRange; i++)
                armies.fArea.Add(i);
            // не сделан подсчёт индексов вражеской армии
        }
    }
}
