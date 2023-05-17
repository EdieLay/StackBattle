using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Warlock : AbstractUnit, ISpecialAbility, IHealable
    {
        public int Range { get; set; }
        public int Strength { get; set; }
        public int MaxHP { get; set; }

        public Warlock()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
            Range = 0;
            Strength = 0;
            MaxHP = 0;
        }
        public Warlock(int attack, int defense, int hitPoints, int range, int strength)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
            Range = range;
            Strength = strength;
            MaxHP = hitPoints;
        }

        public void Action(Army friendlyArmy, Army enemyArmy)
        {
            int pos = friendlyArmy.Units.IndexOf(this);
            int armyStartInRange = pos - Range < 0 ? 0 : pos - Range;
            int armyEndInRange = pos + Range >= friendlyArmy.ArmySize ? friendlyArmy.ArmySize - 1 : pos + Range;
            for (int i = armyStartInRange; i <= armyEndInRange; i++)
            {
                if (friendlyArmy[i].HitPoints > 0 && friendlyArmy[i] is ICloneableUnit prototype)
                {
                    var rand = new Random((int)DateTime.Now.Ticks);
                    double value = rand.Next();
                    if (value < (double)Strength / 100.0)
                    {
                        IUnit clone = prototype.Clone() as IUnit;
                        friendlyArmy.InsertClonedUnit(pos + 1, clone);
                    }
                }
            }
        }

        public void Heal(int hp)
        {
            if (HitPoints + hp > MaxHP)
            {
                HitPoints = MaxHP;
            }
            else HitPoints += hp;
        }
    }
}
