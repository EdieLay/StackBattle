﻿using System;
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

            int maxArmyLength = Math.Max(firstArmy.ArmySize, secondArmy.ArmySize);
            for (int i = 0; i < maxArmyLength; i++)
            {
                ApplyBuffs(i, firstArmy, secondArmy);
            }

            secondArmy[0].TakeDamage(firstArmy[0].Attack);
            firstArmy[0].TakeDamage(secondArmy[0].Attack);

            for (int i = 1; i < maxArmyLength; i++)
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

            int enemyEndInRange = range - position >= armies.enemyArmy.ArmySize ? armies.enemyArmy.ArmySize : range - position;
            for (int i = 0; i < enemyEndInRange; i++)
                armies.eArea.Add(i);
        }
    }
}
