using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class WarlockProxy : AbstractProxy, IUnit, ISpecialAbility, IHealable
    {
        private Warlock _warlock;
        public string ID
        {
            get => _warlock.ID;
            set => _warlock.ID = value;
        }
        public int Attack
        {
            get => _warlock.Attack;
            set => _warlock.Attack = value;
        }
        public int HitPoints
        {
            get => _warlock.HitPoints;
            set => _warlock.HitPoints = value;
        }
        public int Defense
        {
            get => _warlock.Defense;
            set => _warlock.Defense = value;
        }
        public int Range
        {
            get => _warlock.Range;
            set => _warlock.Range = value;
        }
        public int Strength
        {
            get => _warlock.Strength;
            set => _warlock.Strength = value;
        }
        public int MaxHP
        {
            get => _warlock.MaxHP;
            set => _warlock.MaxHP = value;
        }
        public UnitType Type { get { return _warlock.Type; } }
        public WarlockProxy(Warlock warlock)
        {
            this._warlock = warlock;
        }

        public void TakeDamage(IUnit attacker, bool isSADamage = false)
        {
            if (isSADamage)
                LogSpecialAbility(attacker, this);
            else LogTakeDamageAndDeath(this, attacker);

            _warlock.TakeDamage(attacker, isSADamage);
            if (this.HitPoints == 0)
                LogDeath(this, attacker);
        }

        public string GetUnitStats()
        {
            return _warlock.GetUnitStats();
        }

        public int Action(ArmiesRange armies)
        {
            int pos = _warlock.Action(armies);
            if (pos >= 0)
                LogSpecialAbility(this, armies.friendlyArmy[pos]);
            return pos;
        }

        public void Heal(int hp)
        {
            _warlock.Heal(hp);
        }

        protected override void LogSpecialAbility(IUnit caster, IUnit target)
        {
            using (StreamWriter specialAbilityLog = new(_specialAbilityLog, true))
            {
                string targetInfo = target.GetUnitStats();
                string casterInfo = caster.GetUnitStats();
                string logLine = $"Turn {Battle.TurnCount:D5} | {casterInfo} cloned {targetInfo}";
                specialAbilityLog.WriteLine(logLine);
            }
        }
    }
}
