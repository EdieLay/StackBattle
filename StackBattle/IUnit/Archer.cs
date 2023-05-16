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
            int pos = friendlyArmy.Units.IndexOf(this); //получаем позицию юнита в армии
            for (int i = 0; i < Range - pos && i < enemyArmy.ArmySize; i++) // проходим вражескую армиюю с вычетом позиции нашего юнита
            {
                if (i == Range - pos - 1 || i == enemyArmy.ArmySize - 1) // если дошли до края рэнжи, то используем абилку
                {
                    enemyArmy[i].TakeDamage(Strength);
                    break;
                }
                var rand = new Random((int)DateTime.Now.Ticks);
                double value = rand.NextDouble();
                if (value < 0.5) // пока не дошли до края рэнжи, решаем рандомно
                {
                    enemyArmy[i].TakeDamage(Strength);
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
    }
}
