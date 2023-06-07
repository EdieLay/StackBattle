using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class KnightProxy : AbstractProxy, IUnit
    {
        private Knight _knight;
        public string ID
        {
            get => _knight.ID;
            set => _knight.ID = value;
        }
        public int Attack
        {
            get => _knight.Attack;
            set => _knight.Attack = value;
        }
        public int HitPoints
        {
            get => _knight.HitPoints;
            set => _knight.HitPoints = value;
        }
        public int Defense
        {
            get => _knight.Defense;
            set => _knight.Defense = value;
        }
        public UnitType Type { get { return _knight.Type; } }
        public KnightProxy(Knight knight)
        {
            this._knight = knight;
        }

        public void TakeDamage(IUnit attacker, bool isSADamage = false)
        {
            if (HitPoints == 0) return;
            _knight.TakeDamage(attacker, isSADamage);
            if (!isSADamage)
                LogTakeDamage(this, attacker);
            if (this.HitPoints == 0)
                LogDeath(this, attacker);
        }

        public string GetUnitStats()
        {
            return _knight.GetUnitStats();
        }
        protected override void LogSpecialAbility(IUnit target)
        {
            throw new NotImplementedException();
        }
    }
}
