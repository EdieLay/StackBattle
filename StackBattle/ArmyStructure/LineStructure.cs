using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

            int minArmyLength = Math.Min(firstArmy.ArmySize, secondArmy.ArmySize);
            for (int i = 0; i < minArmyLength; i++)
            {
                secondArmy[i].TakeDamage(firstArmy[i]);
                if (secondArmy[i] is AbstractBuff buffunit2)
                    TakeOffBuff(secondArmy, buffunit2, i);
                firstArmy[i].TakeDamage(secondArmy[i]);
                if (firstArmy[i] is AbstractBuff buffunit1)
                    TakeOffBuff(firstArmy, buffunit1, i);
            }

            int faiter = minArmyLength, saiter = minArmyLength;
            while (faiter < Math.Max(firstArmy.ArmySize, secondArmy.ArmySize) || saiter < Math.Max(firstArmy.ArmySize, secondArmy.ArmySize))
            {
                ApplySpecialAbility(ref faiter, firstArmy, secondArmy);
                ApplySpecialAbility(ref saiter, secondArmy, firstArmy);
                faiter++;
                saiter++;
            }

            return true;
        }

        public override void GetAreasInRange(int position, int range, ArmiesRange armies)
        {
            int armyStartInRange = position - range < 0 ? 0 : position - range;
            int armyEndInRange = position + range >= armies.friendlyArmy.ArmySize ? armies.friendlyArmy.ArmySize - 1 : position + range;
            armies.fArea.Add(position);
            for (int i = armyStartInRange; i < position; i++)
                armies.fArea.Add(i);
            for (int i = position + 1; i <= armyEndInRange; i++)
                armies.fArea.Add(i);

            for (int i = armyStartInRange; i < armies.enemyArmy.ArmySize; i++)
                armies.eArea.Add(i);
        }
    }
}