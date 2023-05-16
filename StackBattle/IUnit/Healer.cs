using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Healer : AbstractUnit, ISpecialAbility, IHealable
    {
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

        public void Action(Army friendlyArmy, Army enemyArmy)
        {
            int pos = friendlyArmy.Units.IndexOf(this); //получаем позицию юнита в армии
            for (int i = 0; i < Range - pos; i++) // проходим вражескую армиюю с вычетом позиции нашего юнита
            {
                if (i == Range - pos) // если дошли до края рэнжи, то используем абилку
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
            throw new NotImplementedException();
        }
    }
}
