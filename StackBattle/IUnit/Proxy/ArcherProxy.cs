using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class ArcherProxy : AbstractProxy, IUnit, ISpecialAbility, IHealable
    {
        private Archer _archer;
        public string ID 
        { 
            get => _archer.ID;
            set => _archer.ID = value;
        }
        public int Attack
        {
            get => _archer.Attack;
            set => _archer.Attack = value;
        }
        public int HitPoints
        {
            get => _archer.HitPoints;
            set => _archer.HitPoints = value;
        }
        public int Defense
        {
            get => _archer.Defense;
            set => _archer.Defense = value;
        }
        public int Range
        {
            get => _archer.Range;
            set => _archer.Range = value;
        }
        public int Strength
        {
            get => _archer.Strength;
            set => _archer.Strength = value;
        }
        public int MaxHP
        {
            get => _archer.MaxHP;
            set => _archer.MaxHP = value;
        }
        public UnitType Type { get { return _archer.Type; } }
        public ArcherProxy(Archer archer)
        {
            this._archer = archer;
        }

        public void TakeDamage(IUnit attacker, bool isSADamage = false)
        {
            if (HitPoints == 0) return;
            _archer.TakeDamage(attacker, isSADamage);
            if (!isSADamage)
                LogTakeDamage(this, attacker);
            if (this.HitPoints == 0)
                LogDeath(this, attacker);
        }

        public string GetUnitStats()
        {
            return _archer.GetUnitStats();
        }

        public int Action(ArmiesRange armies)
        {
            int pos = _archer.Action(armies);
            if (pos >= 0)
                LogSpecialAbility(armies.enemyArmy[pos]);
            return pos;
        }

        public void Heal(int hp)
        {
            _archer.Heal(hp);
        }

        protected override void LogSpecialAbility(IUnit target)
        {
            using (StreamWriter specialAbilityLog = new(_specialAbilityLog, true))
            {
                string targetInfo = target.GetUnitStats();
                string casterInfo = this.GetUnitStats();
                int defMod = Battle.DefenseMod;
                int damage = (int)Math.Round((double)this.Strength * ((double)defMod / (double)(defMod + target.Defense)));
                string logLine = $"Turn {Battle.TurnCount:D5} | {casterInfo} shot with a bow {targetInfo} dealing {damage} damage";
                specialAbilityLog.WriteLine(logLine);
            }
        }
    }
}
