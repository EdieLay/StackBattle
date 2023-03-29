using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Archer : AbstractUnit, ISpecialAbility, IHealable
    {
        public int Range { get; set; }
        public int Strength { get; set; }
        public int MaxHP { get; set; }

        public Archer()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
            Range = 0;
            Strength = 0;
            MaxHP = 0;
        }
        public Archer(int attack, int defense, int hitPoints, int range, int strength)
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
            throw new NotImplementedException();
        }

        public void Heal(int hp)
        {
            throw new NotImplementedException();
        }
    }
}
