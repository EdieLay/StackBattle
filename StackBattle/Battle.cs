using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Battle
    {
        private static Battle? battleInstance = null;
        private static object syncRoot = new();

        public static int Price { get; set; } = 200; // установленная цена армий
        public static int DefenseMod { get { return Price / 20; } } // модификатор защиты для подстановки в формулу TakeDamage
        

        Army FirstArmy { get; set; }
        Army SecondArmy { get; set; }
        ArmyStructure Structure { get; set; }
        ICommand Command { get; set; }



        public bool IsFirstArmyBeingEdited { get; set; }

        private Battle()
        {
            FirstArmy = new Army();
            SecondArmy = new Army();
            Structure = new StackStructure();
            Command = new TurnCommand(FirstArmy, SecondArmy, Structure);
        }
        public static Battle GetBattleInstance()
        {
            if (battleInstance == null)
                lock (syncRoot)
                    battleInstance ??= new Battle();
            return battleInstance;
        }

        public Army GetArmy()
        {
            if (IsFirstArmyBeingEdited) return FirstArmy;
            return SecondArmy;
        }

        public void SetStructure(ArmyStructure newStructure)
        {
            Structure = newStructure;
        }

        

        

        void ClearField()
        {
            FirstArmy.ClearArmy(); 
            SecondArmy.ClearArmy();
        }
    }
}
