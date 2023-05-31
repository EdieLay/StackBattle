using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class TripletStructure : ArmyStructure
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

            int countAttackUnit = Math.Min(3, maxArmyLength);
            for (int i = 0; i < countAttackUnit; i++)
            {
                secondArmy[i].TakeDamage(firstArmy[i].Attack);
                firstArmy[i].TakeDamage(secondArmy[i].Attack);
            }

            for (int i = countAttackUnit; i < maxArmyLength; i++)
            {
                ApplySpecialAbility(i, firstArmy, secondArmy);
            }

            return true;
        }
        public override void GetAreasInRange(int position, int range, ArmiesRange armies)
        {
            int armyStartInRangeX = position - range * 3 < 0 ? 0 : position - range * 3;
            int armyEndInRangeX = position + range * 3 >= armies.friendlyArmy.ArmySize ? armies.friendlyArmy.ArmySize - 1 : position + range * 3;

            for (int i = armyStartInRangeX; i < position; i++)
            {
                int armyStartInRangeY = i - range < 3 * (i / 3) ? 3 * (i / 3) : i - range;
                int armyEndInRangeY = i + range >= Math.Min(armies.enemyArmy.ArmySize, 3 * (i / 3) + 2)
                    ? Math.Min(armies.enemyArmy.ArmySize, 3 * (i / 3) + 2) : i + range;

                for (int j = armyStartInRangeY; j <= armyEndInRangeY; j++)
                    armies.fArea.Add(j);
            }
            for (int i = position; i <= position; i++)
            {
                int armyStartInRangeY = i - range < 3 * (i / 3) ? 3 * (i / 3) : i - range;
                int armyEndInRangeY = i + range >= Math.Min(armies.enemyArmy.ArmySize, 3 * (i / 3) + 2)
                    ? Math.Min(armies.enemyArmy.ArmySize, 3 * (i / 3) + 2) : i + range;

                for (int j = armyStartInRangeY; j <= armyEndInRangeY; j++)
                    if (j != position) armies.fArea.Add(j);
            }
            for (int i = position + 1; i <= armyEndInRangeX; i++)
            {
                int armyStartInRangeY = i - range < 3 * (i / 3) ? 3 * (i / 3) : i - range;
                int armyEndInRangeY = i + range >= Math.Min(armies.enemyArmy.ArmySize, 3 * (i / 3) + 2)
                    ? Math.Min(armies.enemyArmy.ArmySize, 3 * (i / 3) + 2) : i + range;

                for (int j = armyStartInRangeY; j <= armyEndInRangeY; j++)
                    armies.fArea.Add(j);
            }

            // нужно написать для вражеско1 армии
            int enemyStartInRangeX = position - range * 3 < 0 ? 0 : position - range * 3;
            int enemyEndInRangeX = position + range * 3 >= armies.friendlyArmy.ArmySize ? armies.friendlyArmy.ArmySize - 1 : position + range * 3;

            int enemyEndInRange = range - position >= armies.enemyArmy.ArmySize ? armies.enemyArmy.ArmySize : range - position;
            for (int i = 0; i < enemyEndInRange; i++)
                armies.eArea.Add(i);


            //int armyStartInRangeY = position - range < 0 ? 0 : position - range;
            //int armyEndInRangeY = position + range >= armies.friendlyArmy.ArmySize ? armies.friendlyArmy.ArmySize - 1 : position + range;
            //for (int i = armyStartInRangeX; i < position; i++)
            //    armies.fArea.Add(i);
            //for (int i = position + 1; i <= armyEndInRangeX; i++)
            //    armies.fArea.Add(i);

            //for (int i = armyStartInRangeX; i < armies.enemyArmy.ArmySize; i++)
            //    armies.eArea.Add(i);
        }
    }
}
