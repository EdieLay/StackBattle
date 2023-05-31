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
        public bool IsFirstArmyWinner { get; private set; }
        public bool IsFirstArmyBeingEdited { get; set; }

        private Battle()
        {
            FirstArmy = new Army();
            SecondArmy = new Army();
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

        void DoTurn(bool isFirstArmyTurn)
        {
            Army FirstTurnArmy = isFirstArmyTurn ? FirstArmy : SecondArmy;
            Army SecondTurnArmy = isFirstArmyTurn ? SecondArmy : FirstArmy;

            SecondTurnArmy[0].TakeDamage(FirstTurnArmy[0].Attack);
            FirstTurnArmy[0].TakeDamage(SecondTurnArmy[0].Attack); // нужно в геттере атаки сделать, что если хп <= 0, то возвращается 0


            ClearField();
        }

        void TakeOffBuff(List<IUnit> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                if (units[i] is AbstractBuff buff) 
                {
                    Random random = new((int)DateTime.Now.Ticks); // 0.1 - бафф снимается
                    if (random.Next(0, 100) <= 10)
                    {
                        units[i] = buff.GetBuffable();
                    }
                }
            }
        }

        void ClearField()
        {
            FirstArmy.ClearArmy(); 
            SecondArmy.ClearArmy();
        }
    }
}
