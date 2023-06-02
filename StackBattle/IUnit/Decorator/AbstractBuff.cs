using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    enum Buffs
    {
        Helmet,
        Horse,
        Shield
    }
    abstract class AbstractBuff : AbstractUnit, IBuffable
    {
        protected IBuffable _component;

        public override UnitType Type { get { return UnitType.HeavyInfantry; } }

        public AbstractBuff(IBuffable component)
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

        public virtual IBuffable GetBuffable()
        {
            return _component;
        }

        public bool TakeOffBuff(IUnit unit)
        {
            Random random = new((int)DateTime.Now.Ticks);
            if (random.Next(0, 100) <= 10) // 0.1 - бафф снимается
            {
                unit = _component as IUnit;
                return true;
            }
            return false;
        }
    }
}
