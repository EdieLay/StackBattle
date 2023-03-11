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
        public int Price { get; private set; }

        public Army()
        {
            Units = new List<IUnit>();
            Price = 0;
        }

        public IUnit this[int index]
        {
            get => Units[index];
            set => Units[index] = value;
        }
        public int CalculateArmyPrice() // функция подсчёта цены армии
        { 
            // подсчёт
            return Price; 
        }
        public bool IsArmyPriceValid(int requiredPrice)
        { 
            return Price == requiredPrice; 
        }
        public void AddUnit(IUnit unit)
        { 
            Units.Add(unit);
        }
        public void ClearArmy()
        {
            // сделать очистку от павших юнитов
            // нужно делать аккуратно, т.к. при удалении из списка одного элемента, другие элементы сдвигаются
        }
    }
}
