using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class HorseDecorator : AbstractDecorator
    {
        public HorseDecorator(IBuffable component) : base(component)
        { }
        public new int Attack
        {
            get
            {
                return _component.Attack + 5;
            }
        }
    }
}
