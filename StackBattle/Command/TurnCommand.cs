using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

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
            // сохранение начального состояния
            TurnState fastate = new(FirstArmy.Units);
            TurnState sastate = new(SecondArmy.Units);
            UndoStack.Push((fastate, sastate));
            RedoStack.Clear();
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

            RestoreStates(FAState, SAState);
        }

        public void Redo()
        {
            TurnState FAState = RedoStack.Peek().FAState;
            TurnState SAState = RedoStack.Peek().SAState;
            UndoStack.Push(RedoStack.Pop());

            RestoreStates(FAState, SAState);
        }

        void DoTurn()
        {
            if (isFirstArmyTurn)
                Structure.DoTurn(FirstArmy, SecondArmy);
            else Structure.DoTurn(SecondArmy, FirstArmy);
            isFirstArmyTurn = !isFirstArmyTurn;
        }

        void RestoreBuffs(TurnState ArmyState)
        {
            for (int i = 0; i < ArmyState.UnitBuffs.Count; i++) // проходим по списку бафов юнитов
            {
                int position = ArmyState.UnitBuffs[i].Position; // получаем позицию IBuffable юнита

                if (ArmyState.UnitList[position] is IBuffable buffunit) // находим этого юнита в армии
                {
                    while (buffunit is AbstractBuff bunit) // снимаем с него все бафы
                    {
                        buffunit = bunit.GetBuffable();
                    }

                    Stack<IBuffable> buffunits = new();
                    buffunits.Push(buffunit);

                    RestoreConcreteBuffs(ArmyState, buffunits, i);

                    ArmyState.UnitList.RemoveAt(position);
                    ArmyState.UnitList.Insert(position, buffunits.Pop());
                }
            }
        }
        void RestoreConcreteBuffs(TurnState ArmyState, Stack<IBuffable> buffunits, int i)
        {
            while (ArmyState.UnitBuffs[i].Buffs.Count > 0) // пока в стэке ещё есть бафы, надеваем их
            {
                Buffs buff = ArmyState.UnitBuffs[i].Buffs.Pop();
                if (buff == Buffs.Helmet)
                {
                    HelmetBuff helmet = new(buffunits.Pop());
                    buffunits.Push(helmet);
                    continue;
                }
                if (buff == Buffs.Horse)
                {
                    HorseBuff horse = new(buffunits.Pop());
                    buffunits.Push(horse);
                    continue;
                }
                if (buff == Buffs.Shield)
                {
                    ShieldBuff shield = new(buffunits.Pop());
                    buffunits.Push(shield);
                    continue;
                }
            }

        }
        void RestoreStates(TurnState FAState, TurnState SAState)
        {
            RestoreBuffs(FAState);
            RestoreBuffs(SAState);

            FirstArmy.Units.Clear();
            for (int i = 0; i < FAState.UnitList.Count; i++) // рабочую армию перезаполняем юнитами из сохраненного состояния
            {
                FirstArmy.Units.Add(FAState.UnitList[i]);
                FirstArmy[i].HitPoints = FAState.UnitsHP[i];
            }
            SecondArmy.Units.Clear();
            for (int i = 0; i < SAState.UnitList.Count; i++) // рабочую армию перезаполняем юнитами из сохраненного состояния
            {
                SecondArmy.Units.Add(SAState.UnitList[i]);
                SecondArmy[i].HitPoints = SAState.UnitsHP[i];
            }
        }
    }
}
