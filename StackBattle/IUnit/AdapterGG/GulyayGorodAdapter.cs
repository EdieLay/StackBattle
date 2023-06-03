using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class GulyayGorodAdapter : AbstractUnit
    {
        private readonly GulyayGorod _adapteeGG;
        public override int Attack { get => 0; }

        public GulyayGorodAdapter(GulyayGorod adapteeGG)
        {
            _adapteeGG = adapteeGG;
            Defense = adapteeGG.GetDefence();
            HitPoints = adapteeGG.GetHealth();
        }

        public override UnitType Type { get { return UnitType.GulyayGorod; } }

        public override string GetUnitStats()
        {
            return $"Gulyay Gorod [{HitPoints}/{Attack}/{Defense}]";
        }
    }
}
