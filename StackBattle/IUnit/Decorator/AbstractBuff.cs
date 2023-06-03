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

        public override int Attack
        {
            get
            {
                if (_component is IBuffable)
                    return _component.Attack;
                return 0;
            }
            set
            {
                if (_component is IBuffable)
                    _component.Attack = value;
            }
        }
        public override int Defense
        {
            get
            {
                if (_component is IBuffable)
                    return _component.Defense;
                return 0;
            }
            set
            {
                if (_component is IBuffable)
                    _component.Defense = value;
            }
        }
        public override int HitPoints
        {
            get
            {
                if (_component is IBuffable)
                    return _component.HitPoints;
                return 0;
            }
            set
            {
                if (_component is IBuffable)    
                    _component.HitPoints = value;
            }
        }

        public virtual IBuffable GetBuffable()
        {
            return _component;
        }
    }
}
