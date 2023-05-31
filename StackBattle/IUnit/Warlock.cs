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

        public void Action(Army friendlyArmy, Army enemyArmy, List<int> fArea, List<int> eArea)
        {
            int pos = friendlyArmy.Units.IndexOf(this);
            int armyStartInRange = pos - Range < 0 ? 0 : pos - Range;
            int armyEndInRange = pos + Range >= friendlyArmy.ArmySize ? friendlyArmy.ArmySize - 1 : pos + Range;
            for (int i = 0; i < fArea.Count; i++)
            {
                if (friendlyArmy[fArea[i]].HitPoints > 0 && friendlyArmy[fArea[i]] is ICloneableUnit prototype)
                {
                    var rand = new Random((int)DateTime.Now.Ticks);
                    double value = rand.NextDouble();
                    if (value < (double)Strength / 100.0)
                    {
                        IUnit clone = prototype.Clone() as IUnit;
                        friendlyArmy.InsertClonedUnit(pos, clone);
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
            return $"Warlock [{HitPoints}/{Attack}/{Defense}/{Range}/{Strength}]";
        }
    }
}
