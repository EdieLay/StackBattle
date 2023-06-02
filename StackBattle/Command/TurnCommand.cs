using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class TurnCommand : ICommand
    {
        Army FirstArmy { get; set; }
        Army SecondArmy { get; set; }
        ArmyStructure Structure { get; set; }
        bool isFirstArmyTurn { get; set; } = true;
        public TurnCommand(Army firstArmy, Army secondArmy, ArmyStructure structure)
        {
            FirstArmy = firstArmy;
            SecondArmy = secondArmy;
            Structure = structure;
            // сохранить начальное состояние
        }

        public void Execute()
        {
            DoTurn();
            // тут происходит сохранение состояния
            // тут происходит очистка армий от мертвых юнитов
        }

        public void Redo()
        {
            throw new NotImplementedException();
        }

        public void Undo()
        {
            throw new NotImplementedException();
        }

        void DoTurn()
        {
            if (isFirstArmyTurn)
                Structure.DoTurn(FirstArmy, SecondArmy);
            else Structure.DoTurn(SecondArmy, FirstArmy);
            isFirstArmyTurn = !isFirstArmyTurn;
        }
    }
}
