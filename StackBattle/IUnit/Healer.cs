using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Healer : AbstractUnit, ISpecialAbility, IHealable
    {
        public override UnitType Type { get { return UnitType.Healer; } }
        public int Range { get; set; }
        public int Strength { get; set; }
        public int MaxHP { get; set; }

        public Healer()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
            Range = 0;
            Strength = 0;
            MaxHP = 0;
        }
        public Healer(int attack, int defense, int hitPoints, int range, int strength)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
            Range = range;
            Strength = strength;
            MaxHP = hitPoints;
        }

        public int Action(ArmiesRange armies)
        {
            for (int i = 0; i < armies.fArea.Count; i++) 
            {
                if (armies.friendlyArmy[armies.fArea[i]] is IHealable unit && armies.friendlyArmy[armies.fArea[i]].HitPoints > 0)
                {
                    var rand = new Random((int)DateTime.Now.Ticks);
                    if (rand.NextDouble() < 0.1) 
                    {
                        unit.Heal(Strength);
                        return armies.fArea[i];
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
            return $"Healer [{HitPoints}/{Attack}/{Defense}/{Range}/{Strength}]";
        }
    }
}
