using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class LightInfantryProxy : AbstractProxy, IUnit, ISpecialAbility, IHealable, ICloneableUnit
    {
        private LightInfantry _lightInfantry;
        public string ID
        {
            get => _lightInfantry.ID;
            set => _lightInfantry.ID = value;
        }
        public int Attack
        {
            get => _lightInfantry.Attack;
            set => _lightInfantry.Attack = value;
        }
        public int HitPoints
        {
            get => _lightInfantry.HitPoints;
            set => _lightInfantry.HitPoints = value;
        }
        public int Defense
        {
            get => _lightInfantry.Defense;
            set => _lightInfantry.Defense = value;
        }
        public int Range
        {
            get => _lightInfantry.Range;
            set => _lightInfantry.Range = value;
        }
        public int Strength
        {
            get => _lightInfantry.Strength;
            set => _lightInfantry.Strength = value;
        }
        public int MaxHP
        {
            get => _lightInfantry.MaxHP;
            set => _lightInfantry.MaxHP = value;
        }
        public UnitType Type { get { return _lightInfantry.Type; } }
        public LightInfantryProxy(LightInfantry lightInfantry)
        {
            this._lightInfantry = lightInfantry;
        }

        public void TakeDamage(IUnit attacker, bool isSADamage = false)
        {
            if (isSADamage)
                LogSpecialAbility(attacker, this);
            else LogTakeDamageAndDeath(this, attacker);

            _lightInfantry.TakeDamage(attacker, isSADamage);
            if (this.HitPoints == 0)
                LogDeath(this, attacker);
        }

        public string GetUnitStats()
        {
            return _lightInfantry.GetUnitStats();
        }

        public int Action(ArmiesRange armies)
        {
            int pos = _lightInfantry.Action(armies);
            if (pos >= 0)
                LogSpecialAbility(this, armies.friendlyArmy[pos]);
            return pos;
        }

        public void Heal(int hp)
        {
            _lightInfantry.Heal(hp);
        }

        protected override void LogSpecialAbility(IUnit caster, IUnit target)
        {
            using (StreamWriter specialAbilityLog = new(_specialAbilityLog, true))
            {
                string targetInfo = target.GetUnitStats();
                string casterInfo = caster.GetUnitStats();
                string buff = String.Empty;
                if (target is AbstractBuff buffunit)
                {
                    if (buffunit is HelmetBuff)
                        buff = "HELMET";
                    else if (buffunit is HorseBuff)
                        buff = "HORSE";
                    else buff = "SHIELD";
                }
                string logLine = $"Turn {Battle.TurnCount:D5} | {casterInfo} give {targetInfo} a {buff}";
                specialAbilityLog.WriteLine(logLine);
            }
        }
    }
}
