using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class LightInfantry : AbstractUnit, IHealable, ICloneableUnit
    {
        public override UnitType Type { get { return UnitType.LightInfantry; } }
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
        LightInfantry(LightInfantry prototype)
        {
            this.Attack = prototype.Attack;
            this.Defense = prototype.Defense;
            this.HitPoints = prototype.HitPoints;
            this.MaxHP = prototype.MaxHP;
        }

        public void Heal(int hp)
        {
            if (HitPoints + hp > MaxHP)
            {
                HitPoints = MaxHP;
            }
            else HitPoints += hp;
        }

        public ICloneableUnit Clone()
        {
            return new LightInfantry(this);
        }
    }
}
