using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class LightInfantry : AbstractUnit, IHealable, ICloneableUnit, IDressBuff
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

        public bool DressBuff(List<IUnit> area)
        {
            int count = 0;
            for (int i = 0; i < area.Count; i++)
            {
                if (area[i] is IBuffable) count++;
            }
            if (count == 0) return false;

            Random random = new((int)DateTime.Now.Ticks);
            int countIndex = 0; 
            count = random.Next(1, count);
            for (int i = 0; i < area.Count; i++)
            {
                if (area[i] is IBuffable && countIndex != count) countIndex++;
                if (countIndex == count)
                {
                    int chance = 120;
                    int r = random.Next(1, chance); // 1/2 - шлем, 1/3 - щит, 1/6 - лошадь

                    if (r <= chance / 6 && area[i] is not HorseBuff)
                    {
                        HorseBuff horseBuff = new((IBuffable)area[i]);
                        area[i] = horseBuff;
                        return true;
                    }
                    else if (r > chance / 6 && r <= chance / 2 && area[i] is not ShieldBuff)
                    {
                        ShieldBuff shieldBuff = new((IBuffable)area[i]);
                        area[i] = shieldBuff;
                        return true;
                    }
                    else if (area[i] is not HelmetBuff)
                    {
                        HelmetBuff helmet = new((IBuffable)area[i]);
                        area[i] = helmet;
                        return true;
                    }
                }
            }

            return false;
		}
		
        public override string GetUnitStats()
        {
            return $"Light Infantry [{HitPoints}/{Attack}/{Defense}]";
        }
    }
}
