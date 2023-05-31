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

        public void Action(Army friendlyArmy, Army enemyArmy, List<int> fArea, List<int> eArea)
        {
            int pos = friendlyArmy.Units.IndexOf(this); //получаем позицию юнита в армии
            for (int i = 0; i < fArea.Count; i++) 
            {
                if (friendlyArmy[fArea[i]] is IHealable unit && friendlyArmy[fArea[i]].HitPoints > 0)
                {
                    var rand = new Random((int)DateTime.Now.Ticks);
                    double value = rand.NextDouble();
                    if (value < 0.5) 
                    {
                        unit.Heal(Strength);
                        break;
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

        public override string GetUnitStats()
        {
            return $"Healer [{HitPoints}/{Attack}/{Defense}/{Range}/{Strength}]";
        }
    }
}
