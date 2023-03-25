using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Army
    {
        List<IUnit> Units;
        public int ArmySize
        {
            get
            {
                return Units.Count;
            }
        }
        private int _price = -1;
        private object syncRoot = new();

        public Army()
        {
            Units = new List<IUnit>();
        }

        public IUnit this[int index]
        {
            get => Units[index];
            set
            {
                Units[index] = value;
                _price = -1;
            }
        }
        public int Price // подсчёт цены армии
        {
            get
            {
                if (_price == -1)
                    lock (syncRoot)
                        if (_price == -1)
                            for (int i = 0; i < Units.Count; i ++)
                            {
                                _price += Units[i].Attack + Units[i].Defense + Units[i].HitPoints;
                                if (Units[i] is ISpecialAbility unit)
                                    _price += (unit.Range + unit.Strength) * 2;
                            }
                return _price;
            }

        }
        public bool IsArmyPriceValid(int requiredPrice)
        { 
            return Price == requiredPrice; 
        }
        public void AddUnit(IUnit unit)
        { 
            Units.Add(unit);
            _price = -1;
        }
        public void ClearArmy()
        {
            _price = -1;
            // сделать очистку от павших юнитов
            // нужно делать аккуратно, т.к. при удалении из списка одного элемента, другие элементы сдвигаются
        }
    }
}
