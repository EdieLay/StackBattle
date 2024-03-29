﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    enum ArmyStructures
    {
        Stack = 0,
        Line,
        Triplet
    }
    internal abstract class ArmyStructure
    {
        public abstract bool DoTurn(Army firstArmy, Army secondArmy); // true - смогли сделать ход, false - одна из армий пустая

        public abstract void GetAreasInRange(int position, int range, ArmiesRange armies);

        public void ApplySpecialAbility(ref int position, Army firstArmy, Army secondArmy)
        {
            if (position < firstArmy.ArmySize)
            {
                if (firstArmy[position] is ISpecialAbility saunit)
                {
                    ArmiesRange armies = new(firstArmy, secondArmy);
                    GetAreasInRange(position, saunit.Range, armies);
                    int targetpos = saunit.Action(armies);
                    if (targetpos >= 0 && (firstArmy[position].Type == UnitType.Archer))
                    {
                        if (secondArmy[targetpos] is AbstractBuff buffunit)
                            TakeOffBuff(secondArmy, buffunit, targetpos);
                    }
                    else if (targetpos >= 0 && (firstArmy[position].Type == UnitType.Warlock))
                        position++;
                }
            }
        }

        public void TakeOffBuff(Army army, AbstractBuff buffunit, int pos)
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            if (rand.NextDouble() < 0.4)
            {
                IBuffable tempunit = buffunit.GetBuffable();
                army.Units.RemoveAt(pos);
                army.Units.Insert(pos, tempunit);
            }
        }
    }
}
