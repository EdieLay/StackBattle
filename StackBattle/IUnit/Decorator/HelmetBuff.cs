using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class HelmetBuff : AbstractBuff
    {
        public HelmetBuff(IBuffable component) : base(component)
        { }
        public override int Defense
        {
            get
            {
                return _component.Defense + int.Max(1, (int)Math.Round(_component.Defense * 0.2));
            }
        }

        public override string GetUnitStats()
        {
            string name = _component.GetUnitStats().Split('[')[0];
            return $"{name}(He) [{HitPoints}/{Attack}/{Defense}]";
            //return _component.GetUnitStats() + $"(He{Defense})";
        }
    }
}
