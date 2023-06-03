using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal abstract class AbstractUnit : IUnit
    {
        private int _attack;
        private int _defense;
        private int _hitPoints;
        abstract public UnitType Type { get; }
        public virtual int Attack { 
            get 
            { 
                if (HitPoints == 0)
                    return 0;
                return _attack;
            }
            set
            {
                if (value < 0) value = 0;
                _attack = value;
            }
        }
        public virtual int Defense { 
            get
            {
                return _defense;
            }
            set
            {
                if (value < 0) value = 0;
                _defense = value;
            }
        }
        public virtual int HitPoints {
            get
            {
                return _hitPoints;
            }
            set
            {
                if (value < 0) value = 0; 
                _hitPoints = value;
            }
        }

        public AbstractUnit()
        {
            Attack = 0;
            Defense = 0;
            HitPoints = 0;
        }
        public AbstractUnit(int attack, int defense, int hitPoints)
        {
            Attack = attack;
            Defense = defense;
            HitPoints = hitPoints;
        }

        public void TakeDamage(int damage)
        {
            int defMod = Battle.DefenseMod;
            HitPoints -= (int)Math.Floor((double)damage * ((double)defMod/(double)(defMod + Defense)));
        }

        public abstract string GetUnitStats();
    }
}
