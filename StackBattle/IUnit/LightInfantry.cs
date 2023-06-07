using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class LightInfantry : AbstractUnit, ISpecialAbility, IHealable, ICloneableUnit
    {
        public override UnitType Type { get { return UnitType.LightInfantry; } }
        public int Range { get => 1; set { } }
        public int Strength { get; set; }
        public int MaxHP { get; set; }

        public LightInfantry()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
            Strength = 0;
            MaxHP = 0;
            ID = "";
        }
        public LightInfantry(int attack, int defense, int hitPoints, int strength, string id)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
            Strength = strength;
            MaxHP = HitPoints;
            ID = id;
        }
        LightInfantry(LightInfantry prototype, int newIndex)
        {
            this.Attack = prototype.Attack;
            this.Defense = prototype.Defense;
            this.HitPoints = prototype.HitPoints;
            this.Strength = prototype.Strength;
            this.MaxHP = prototype.MaxHP;
            string[] sepid = prototype.ID.Split('#');
            this.ID = sepid[0] + "#" + newIndex.ToString();
            
        }

        public void Heal(int hp)
        {
            if (HitPoints + hp > MaxHP)
            {
                HitPoints = MaxHP;
            }
            else HitPoints += hp;
        }

        public ICloneableUnit Clone(Army army)
        {
            return new LightInfantry(this, army.NextIndex++);
        }

        public int Action(ArmiesRange armies)
        {
            Random random = new((int)DateTime.Now.Ticks);
            for (int i = 1; i < armies.fArea.Count; i++)
            {
                if (armies.friendlyArmy[armies.fArea[i]] is IBuffable buffunit)
                {
                    if (random.NextDouble() < (double)Strength / ((double)Battle.Price / 2.0))
                    {
                        List<Buffs> buffs = GetBuffs(buffunit);
                        double chance = random.NextDouble();
                        if (chance < 1.0/2.0 && !buffs.Contains(Buffs.Helmet))
                        {
                            HelmetBuff helmet = new(buffunit);
                            armies.friendlyArmy.Units.RemoveAt(armies.fArea[i]);
                            armies.friendlyArmy.Units.Insert(armies.fArea[i], helmet);
                            return armies.fArea[i];
                        }
                        else if (chance >= 1.0 / 2.0 && chance < 1.0/2.0 + 1.0/3.0 && !buffs.Contains(Buffs.Shield))
                        {
                            ShieldBuff shield = new(buffunit);
                            armies.friendlyArmy.Units.RemoveAt(armies.fArea[i]);
                            armies.friendlyArmy.Units.Insert(armies.fArea[i], shield);
                            return armies.fArea[i];
                        }
                        else if (!buffs.Contains(Buffs.Horse))
                        {
                            HorseBuff horse = new(buffunit);
                            armies.friendlyArmy.Units.RemoveAt(armies.fArea[i]);
                            armies.friendlyArmy.Units.Insert(armies.fArea[i], horse);
                            return armies.fArea[i];
                        }
                    }
                }
            }
            return -1;
		}
		
        public override string GetUnitStats()
        {
            return $"{ID} Light Infantry [{HitPoints}/{Attack}/{Defense}/{Range}/{Strength}]";
        }

        List<Buffs> GetBuffs(IBuffable buffunit)
        {
            List<Buffs> buffs = new();

            Stack<IBuffable> buffstack = new Stack<IBuffable>();
            buffstack.Push(buffunit);
            while (buffstack.Pop() is AbstractBuff bunit)
            {
                if (bunit is HelmetBuff)
                {
                    buffs.Add(Buffs.Helmet);
                    buffstack.Push(bunit.GetBuffable());
                    continue;
                }
                if (bunit is HorseBuff)
                {
                    buffs.Add(Buffs.Horse);
                    buffstack.Push(bunit.GetBuffable());
                    continue;
                }
                if (bunit is ShieldBuff)
                {
                    buffs.Add(Buffs.Shield);
                    buffstack.Push(bunit.GetBuffable());
                    continue;
                }
            }
            return buffs;
        }
    }
}
