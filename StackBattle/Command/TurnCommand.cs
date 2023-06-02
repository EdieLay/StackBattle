using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace StackBattle
{
    internal class TurnCommand : ICommand
    {
        Army FirstArmy { get; set; }
        Army SecondArmy { get; set; }
        ArmyStructure Structure { get; set; }
        bool isFirstArmyTurn { get; set; } = true;
        Stack<(TurnState FAState, TurnState SAState)> UndoStack { get; set; } = new();
        Stack<(TurnState FAState, TurnState SAState)> RedoStack { get; set; } = new();
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
            TurnState fastate = new(FirstArmy.Units);
            TurnState sastate = new(SecondArmy.Units);
            UndoStack.Push((fastate, sastate));
            RedoStack.Clear();

            FirstArmy.ClearArmy();
            SecondArmy.ClearArmy();
        }

        public void Undo()
        {
            RedoStack.Push(UndoStack.Pop());
            TurnState FAState = UndoStack.Peek().FAState;
            TurnState SAState = UndoStack.Peek().SAState;

            FirstArmy.Units.Clear();
            for (int i = 0; i < FAState.UnitList.Count; i++)
            {
                FirstArmy.Units.Add(FAState.UnitList[i]);
                FirstArmy[i].HitPoints = FAState.UnitsHP[i];
            }
            for (int i = 0; i < FAState.UnitBuffs.Count; i++)
            {

            }
        }

        public void Redo()
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
