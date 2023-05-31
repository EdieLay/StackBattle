using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class HelmetDecorator : AbstractDecorator
    {
        public HelmetDecorator(IBuffable component) : base(component)
        { }
        public new int Defense
        {
            get
            {
                return _component.Defense + 2;
            }
        }

        public override string GetUnitStats()
        {
            throw new NotImplementedException();
        }
    }
}
