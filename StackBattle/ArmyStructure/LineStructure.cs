using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class LineStructure : ArmyStructure
    {
        public override bool DoTurn(Army firstArmy, Army secondArmy)
        {
            if (firstArmy.Units.Count == 0 || secondArmy.Units.Count == 0)
                return false;

            int maxArmyLength = Math.Max(firstArmy.ArmySize, secondArmy.ArmySize);
            for (int i = 0; i < maxArmyLength; i++)
            {
                ApplyBuffs(i, firstArmy, secondArmy);
            }

            int minArmyLength = Math.Min(firstArmy.ArmySize, secondArmy.ArmySize);
            for (int i = 0; i < minArmyLength; i++)
            {
                secondArmy[i].TakeDamage(firstArmy[i].Attack);
                firstArmy[i].TakeDamage(secondArmy[i].Attack);
            }

            
            for (int i = minArmyLength; i < maxArmyLength; i++)
            {
                ApplySpecialAbility(i, firstArmy, secondArmy);
            }

            return true;
        }

        public override void GetAreasInRange(int position, int range, ArmiesRange armies)
        {
            int armyStartInRange = position - range < 0 ? 0 : position - range;
            int armyEndInRange = position + range >= armies.friendlyArmy.ArmySize ? armies.friendlyArmy.ArmySize - 1 : position + range;
            for (int i = armyStartInRange; i < position; i++)
                armies.fArea.Add(i);
            for (int i = position + 1; i <= armyEndInRange; i++)
                armies.fArea.Add(i);

            for (int i = armyStartInRange; i < armies.enemyArmy.ArmySize; i++)
                armies.eArea.Add(i);
        }
    }
}