using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class Battle
    {
        Army FirstArmy { get; set; }
        Army SecondArmy { get; set; }
        public bool isFirstArmyWinner { get; private set; }

        public Battle()
        {
            FirstArmy = new Army();
            SecondArmy = new Army();
        }

        void DoTurn(bool isFirstArmyTurn)
        {
            Army FirstTurnArmy = isFirstArmyTurn ? FirstArmy : SecondArmy;
            Army SecondTurnArmy = isFirstArmyTurn ? SecondArmy : FirstArmy;

            SecondTurnArmy[0].TakeDamage(FirstTurnArmy[0].Attack);
            FirstTurnArmy[0].TakeDamage(SecondTurnArmy[0].Attack); // нужно в геттере атаки сделать, что если хп <= 0, то возвращается 0

            // логика спешал абилити
            
            FirstArmy = isFirstArmyTurn ? FirstTurnArmy : SecondTurnArmy;
            SecondArmy = isFirstArmyTurn ? SecondTurnArmy : FirstArmy;
            ClearField();
        }
        void ClearField()
        {
            FirstArmy.ClearArmy(); 
            SecondArmy.ClearArmy();
        }
    }
}
