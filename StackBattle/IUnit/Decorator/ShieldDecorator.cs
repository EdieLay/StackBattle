using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class ShieldDecorator : AbstractDecorator
    {
        public ShieldDecorator(IBuffable component) : base(component)
        { }
        public new int Defense
        {
            get
            {
                return _component.Defense + 4;
            }
        }
    }
}
