using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class GulyayGorodAdapterProxy : AbstractProxy, IUnit
    {
        private GulyayGorodAdapter _ggAdapter;
        public string ID
        {
            get => _ggAdapter.ID;
            set => _ggAdapter.ID = value;
        }
        public int Attack
        {
            get => _ggAdapter.Attack;
            set => _ggAdapter.Attack = 0;
        }
        public int HitPoints
        {
            get => _ggAdapter.HitPoints;
            set => _ggAdapter.HitPoints = value;
        }
        public int Defense
        {
            get => _ggAdapter.Defense;
            set => _ggAdapter.Defense = value;
        }
        public UnitType Type { get { return _ggAdapter.Type; } }
        public GulyayGorodAdapterProxy(GulyayGorodAdapter ggAdapter)
        {
            this._ggAdapter = ggAdapter;
        }

        public void TakeDamage(IUnit attacker, bool isSADamage = false)
        {
            if (HitPoints == 0) return;
            _ggAdapter.TakeDamage(attacker, isSADamage);
            if (!isSADamage)
                LogTakeDamage(this, attacker);
            if (this.HitPoints == 0)
                LogDeath(this, attacker);
        }

        public string GetUnitStats()
        {
            return _ggAdapter.GetUnitStats();
        }

        protected override void LogSpecialAbility(IUnit target)
        {
            throw new NotImplementedException();
        }
    }
}
