using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class HeavyInfantry : AbstractUnit, IBuffable
    {
        public override UnitType Type { get { return UnitType.HeavyInfantry; } }
        public HeavyInfantry()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
            ID = "";
        }
        public HeavyInfantry(int attack, int defense, int hitPoints, string id)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
            ID = id;
        }

        public override string GetUnitStats()
        {
            return $"{ID} Heavy Infantry [{HitPoints}/{Attack}/{Defense}]";
        }
    }
}
