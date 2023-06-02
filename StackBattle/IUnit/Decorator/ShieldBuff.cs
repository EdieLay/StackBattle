using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class ShieldBuff : AbstractBuff
    {
        public ShieldBuff(IBuffable component) : base(component)
        { }
        public override int Defense
        {
            get
            {
                return _component.Defense + int.Max(1, (int)Math.Round(_component.Defense * 0.4));
            }
        }

        public override string GetUnitStats()
        {
            return _component.GetUnitStats() + $"(Sh{Defense})";
        }
    }
}
