using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal abstract class ArmyStructure
    {
        public abstract bool DoTurn(Army firstArmy, Army secondArmy); // true - смогли сделать ход, false - одна из армий пустая

        public abstract void GetAreasInRange(int position, int range, ArmiesRange armies);

        public void ApplySpecialAbility(int position, Army firstArmy, Army secondArmy)
        {
            if (position < firstArmy.ArmySize)
            {
                if (firstArmy[position] is ISpecialAbility saunit)
                {
                    ArmiesRange armies = new(firstArmy, secondArmy);
                    GetAreasInRange(position, saunit.Range, armies);
                    saunit.Action(armies);
                }
            }
            if (position < secondArmy.ArmySize)
            {
                if (secondArmy[position] is ISpecialAbility saunit)
                {
                    ArmiesRange armies = new(secondArmy, firstArmy);
                    GetAreasInRange(position, saunit.Range, armies);
                    saunit.Action(armies);
                }
            }
        }

        public void ApplyBuffs(int position, Army firstArmy, Army secondArmy)
        {
            if (position < firstArmy.ArmySize)
            {
                if (firstArmy[position] is IDressBuff dressBuff)
                {
                    ArmiesRange armies = new(firstArmy, secondArmy);
                    GetAreasInRange(position, 1, armies);
                    dressBuff.DressBuff(armies);
                }
            }
            if (position < secondArmy.ArmySize)
            {
                if (secondArmy[position] is IDressBuff dressBuff)
                {
                    ArmiesRange armies = new(secondArmy, firstArmy);
                    GetAreasInRange(position, 1, armies);
                    dressBuff.DressBuff(armies);
                }
            }
        }
    }
}
