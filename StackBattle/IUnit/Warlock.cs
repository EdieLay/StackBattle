using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Warlock : AbstractUnit, ISpecialAbility, IHealable
    {
        public override UnitType Type { get { return UnitType.Warlock; } }
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
            ID = "";
        }
        public Warlock(int attack, int defense, int hitPoints, int range, int strength, string id)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
            Range = range;
            Strength = strength;
            MaxHP = hitPoints;
            ID = id;
        }

        public int Action(ArmiesRange armies)
        {
            for (int i = 0; i < armies.fArea.Count; i++)
            {
                if (armies.friendlyArmy[armies.fArea[i]].HitPoints > 0 && armies.friendlyArmy[armies.fArea[i]] is ICloneableUnit prototype)
                {
                    var rand = new Random((int)DateTime.Now.Ticks);
                    if (rand.NextDouble() < (double)Strength / (double)Battle.Price)
                    {
                        int warlockpos = armies.friendlyArmy.Units.IndexOf(this);
                        int clonepos = armies.fArea[i];
                        IUnit clone = prototype.Clone(armies.friendlyArmy) as IUnit;
                        armies.friendlyArmy.InsertClonedUnit(warlockpos, clone);
                        if (clonepos < warlockpos)
                            return clonepos;
                        return clonepos + 1;
                    }
                }
            }
            return -1;
        }

        public void Heal(int hp)
        {
            if (HitPoints + hp > MaxHP)
            {
                HitPoints = MaxHP;
            }
            else HitPoints += hp;
        }

        public override string GetUnitStats()
        {
            return $"{ID} Warlock [{HitPoints}/{Attack}/{Defense}/{Range}/{Strength}]";
        }
    }
}
