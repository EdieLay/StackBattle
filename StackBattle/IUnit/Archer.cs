﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Archer : AbstractUnit, ISpecialAbility, IHealable
    {
        public override UnitType Type { get { return UnitType.Archer; } }
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

        public void Action(ArmiesRange armies)
        {
            for (int i = 0; i < armies.eArea.Count; i++) // проходим вражескую армиюю с вычетом позиции нашего юнита
            {
                var rand = new Random((int)DateTime.Now.Ticks);
                double value = rand.NextDouble();
                if (value < 0.5) // шанс попасть
                {
                    armies.enemyArmy[armies.eArea[i]].TakeDamage(Strength);
                    break;
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

        public override string GetUnitStats()
        {
            return $"Archer [{HitPoints}/{Attack}/{Defense}/{Range}/{Strength}]";
        }
    }
}
