using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class StackStructure : ArmyStructure
    {
        public override bool DoTurn(Army firstArmy, Army secondArmy)
        {
            if (firstArmy.Units.Count == 0 || secondArmy.Units.Count == 0) 
                return false;

            secondArmy[0].TakeDamage(firstArmy[0].Attack);
            if (secondArmy[0] is AbstractBuff buffunit2)
                TakeOffBuff(secondArmy, buffunit2, 0);
            firstArmy[0].TakeDamage(secondArmy[0].Attack);
            if (firstArmy[0] is AbstractBuff buffunit1)
                TakeOffBuff(firstArmy, buffunit1, 0);

            int faiter = 1, saiter = 1;
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
            for (int i = armyStartInRange; i < position; i++)
                armies.fArea.Add(i);
            for (int i = position + 1; i <= armyEndInRange; i++)
                armies.fArea.Add(i);

            int enemyEndInRange = range - position >= armies.enemyArmy.ArmySize ? armies.enemyArmy.ArmySize : range - position;
            for (int i = 0; i < enemyEndInRange; i++)
                armies.eArea.Add(i);
        }
    }
}
