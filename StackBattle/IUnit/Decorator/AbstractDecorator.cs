using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    abstract class AbstractDecorator : AbstractUnit
    {
        protected IBuffable _component;

        public override UnitType Type { get { return UnitType.HeavyInfantry; } }

        public AbstractDecorator(IBuffable component)
        {
            this._component = component;
        }

        public void SetDecorator(IBuffable component)
        {
            this._component = component;
        }

        public new int Attack
        {
            get
            {
                return _component.Attack;
            }
            set
            {
                _component.Attack = value;
            }
        }
        public new int Defense
        {
            get
            {
                return _component.Defense;
            }
            set
            {
                _component.Defense = value;
            }
        }
        public new int HitPoints
        {
            get
            {
                return _component.HitPoints;
            }
            set
            {
                _component.HitPoints = value;
            }
        }
    }
}
