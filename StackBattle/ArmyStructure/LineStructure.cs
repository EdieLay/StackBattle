using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class LineStructure : IArmyStructure
    {
        public bool DoTurn(Army firstArmy, Army secondArmy)
        {
            if (firstArmy.Units.Count == 0 || secondArmy.Units.Count == 0)
                return false;

            int maxArmyLength = Math.Max(firstArmy.ArmySize, secondArmy.ArmySize);
            for (int i = 0; i < maxArmyLength; i++)
            {
                if (i < firstArmy.ArmySize)
                {
                    if (firstArmy[i] is IDressBuff dressBuff)
                    {
                        ArmiesRange armies = new(firstArmy, secondArmy);
                        GetAreasInRange(i, 1, armies);
                        dressBuff.DressBuff(armies);
                    }
                }
                if (i < secondArmy.ArmySize)
                {
                    if (secondArmy[i] is IDressBuff dressBuff)
                    {
                        ArmiesRange armies = new(secondArmy, firstArmy);
                        GetAreasInRange(i, 1, armies);
                        dressBuff.DressBuff(armies);
                    }
                }
            }

            int minArmyLength = Math.Min(firstArmy.ArmySize, secondArmy.ArmySize);
            for (int i = 0; i < minArmyLength; i++)
            {
                secondArmy[i].TakeDamage(firstArmy[i].Attack);
                Battle.TakeOffBuff(ref firstArmy[i]);
                firstArmy[i].TakeDamage(secondArmy[i].Attack);
                Battle.TakeOffBuff(ref secondArmy[i]);
            }

            
            for (int i = minArmyLength; i < maxArmyLength; i++)
            {
                if (i < firstArmy.ArmySize)
                {
                    if (firstArmy[i] is ISpecialAbility saunit)
                    {
                        ArmiesRange armies = new(firstArmy, secondArmy);
                        GetAreasInRange(i, saunit.Range, armies);
                        saunit.Action(armies);
                    }
                }
                if (i < secondArmy.ArmySize)
                {
                    if (secondArmy[i] is ISpecialAbility saunit)
                    {
                        ArmiesRange armies = new(secondArmy, firstArmy);
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

            for (int i = armyStartInRange; i < armies.enemyArmy.ArmySize; i++)
                armies.eArea.Add(i);
        }
    }
}