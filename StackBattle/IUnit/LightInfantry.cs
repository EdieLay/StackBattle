using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class LightInfantry : AbstractUnit, IHealable
    {
        public int MaxHP { get; set; }

        public LightInfantry()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
        }
        public LightInfantry(int attack, int defense, int hitPoints)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
        }

        public void Heal(int hp)
        {
            throw new NotImplementedException();
        }
    }
}
