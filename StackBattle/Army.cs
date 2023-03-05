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
        public int Price { get; set; }

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
        int GetArmyPrice()
        { return Price; }
        bool IsArmyPriceValid(int requiredPrice)
        { return Price == requiredPrice; }
        public void AddUnit(IUnit unit)
        { Units.Add(unit); }
    }
}
