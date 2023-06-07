using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class HealerProxy : AbstractProxy, IUnit, ISpecialAbility, IHealable
    {
        private Healer _healer;
        public string ID
        {
            get => _healer.ID;
            set => _healer.ID = value;
        }
        public int Attack
        {
            get => _healer.Attack;
            set => _healer.Attack = value;
        }
        public int HitPoints
        {
            get => _healer.HitPoints;
            set => _healer.HitPoints = value;
        }
        public int Defense
        {
            get => _healer.Defense;
            set => _healer.Defense = value;
        }
        public int Range
        {
            get => _healer.Range;
            set => _healer.Range = value;
        }
        public int Strength
        {
            get => _healer.Strength;
            set => _healer.Strength = value;
        }
        public int MaxHP
        {
            get => _healer.MaxHP;
            set => _healer.MaxHP = value;
        }
        public UnitType Type { get { return _healer.Type; } }
        public HealerProxy(Healer healer)
        {
            this._healer = healer;
        }

        public void TakeDamage(IUnit attacker, bool isSADamage = false)
        {
            if (isSADamage)
                LogSpecialAbility(attacker, this);
            else LogTakeDamageAndDeath(this, attacker);

            _healer.TakeDamage(attacker, isSADamage);
            if (this.HitPoints == 0)
                LogDeath(this, attacker);
        }

        public string GetUnitStats()
        {
            return _healer.GetUnitStats();
        }

        public int Action(ArmiesRange armies)
        {
            return _healer.Action(armies);
        }

        public void Heal(int hp)
        {
            _healer.Heal(hp);
        }

        protected override void LogSpecialAbility(IUnit caster, IUnit target)
        {
            using (StreamWriter specialAbilityLog = new(_specialAbilityLog, true))
            {
                string targetInfo = target.GetUnitStats();
                string casterInfo = caster.GetUnitStats();
                int healedHitPoints = Math.Min((target as IHealable).MaxHP, target.HitPoints + (caster as ISpecialAbility).Strength) - target.HitPoints;
                string logLine = $"Turn {Battle.TurnCount:D5} | {casterInfo} heals {targetInfo} healed {healedHitPoints} hit point(s)";
                specialAbilityLog.WriteLine(logLine);
            }
        }
    }
}
