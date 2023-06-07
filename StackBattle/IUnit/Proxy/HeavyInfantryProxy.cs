using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class HeavyInfantryProxy : AbstractProxy, IUnit, IBuffable
    {
        private HeavyInfantry _heavyInfantry;
        public string ID
        {
            get => _heavyInfantry.ID;
            set => _heavyInfantry.ID = value;
        }
        public int Attack
        {
            get => _heavyInfantry.Attack;
            set => _heavyInfantry.Attack = value;
        }
        public int HitPoints
        {
            get => _heavyInfantry.HitPoints;
            set => _heavyInfantry.HitPoints = value;
        }
        public int Defense
        {
            get => _heavyInfantry.Defense;
            set => _heavyInfantry.Defense = value;
        }
        public UnitType Type { get { return _heavyInfantry.Type; } }
        public HeavyInfantryProxy(HeavyInfantry heavyInfantry)
        {
            this._heavyInfantry = heavyInfantry;
        }

        public void TakeDamage(IUnit attacker, bool isSADamage = false)
        {
            if (HitPoints == 0) return;
            _heavyInfantry.TakeDamage(attacker, isSADamage);
            if (!isSADamage)
                LogTakeDamage(this, attacker);
            if (this.HitPoints == 0)
                LogDeath(this, attacker);
        }

        public string GetUnitStats()
        {
            return _heavyInfantry.GetUnitStats();
        }

        protected override void LogSpecialAbility(IUnit target)
        {
            throw new NotImplementedException();
        }
    }
}
