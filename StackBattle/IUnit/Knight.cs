using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Knight : AbstractUnit
    {
        public override UnitType Type { get { return UnitType.Knight; } }
        public Knight()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
            ID = "";
        }
        public Knight(int attack, int defense, int hitPoints, string id)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
            ID = id;
        }

        public override string GetUnitStats()
        {
            return $"{ID} Knight [{HitPoints}/{Attack}/{Defense}]";
        }
    }
}
