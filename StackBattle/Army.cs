using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Army
    {
        private int _price = -1;
        private object syncRoot = new();

        public List<IUnit> Units { get; private set; }
        public int ArmySize
        {
            get
            {
                return Units.Count;
            }
        }
        public int NextIndex = 1;

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
                
                _price = 0;
                for (int i = 0; i < Units.Count; i++)
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
        public void InsertClonedUnit(int pos, IUnit clonedUnit)
        {
            Units.Insert(pos, clonedUnit);
        }
        public void ClearArmy()
        {
            int i = 0;
            while (i != ArmySize)
            {
                if (Units[i].HitPoints == 0)
                {
                    Units.RemoveAt(i);
                    continue;
                }
                i++;
            }
        }
    }
}
