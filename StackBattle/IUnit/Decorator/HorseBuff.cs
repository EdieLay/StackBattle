using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class HorseBuff : AbstractBuff
    {
        public HorseBuff(IBuffable component) : base(component)
        { }
        public override int Attack
        {
            get
            {
                return _component.Attack + int.Max(1, (int)Math.Round(_component.Attack * 0.6));
            }
        }

        public override string GetUnitStats()
        {
            string name = _component.GetUnitStats().Split('[')[0];
            return $"{name}(Ho) [{HitPoints}/{Attack}/{Defense}]";
            //return _component.GetUnitStats() + $"(Ho{Attack})";
        }
    }
}
