﻿using System;
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
        Stack<(TurnState FAState, TurnState SAState)> UndoStack { get; set; } = new(); // верхнее состояние - текущее
        Stack<(TurnState FAState, TurnState SAState)> RedoStack { get; set; } = new();
        public bool IsUndoAvailable { get { return UndoStack.Count > 1; } }
        public bool IsRedoAvailable { get { return RedoStack.Count > 0; } }

        public TurnCommand(Army firstArmy, Army secondArmy, ArmyStructure structure)
        {
            FirstArmy = firstArmy;
            SecondArmy = secondArmy;
            Structure = structure;
            // сохранение начального состояния
            TurnState fastate = new(FirstArmy.Units, GetStructure());
            TurnState sastate = new(SecondArmy.Units, GetStructure());
            UndoStack.Push((fastate, sastate));
            RedoStack.Clear();
        }

        public void Execute()
        {
            DoTurn();
            FirstArmy.ClearArmy();
            SecondArmy.ClearArmy();
            TurnState fastate = new(FirstArmy.Units, GetStructure());
            TurnState sastate = new(SecondArmy.Units, GetStructure());
            UndoStack.Push((fastate, sastate));
            RedoStack.Clear();
        }

        public ArmyStructure Undo()
        {
            RedoStack.Push(UndoStack.Pop());
            TurnState FAState = UndoStack.Peek().FAState;
            TurnState SAState = UndoStack.Peek().SAState;
            AbstractProxy.LogUndoRedo(true);
            RestoreStates(FAState, SAState);
            return GetStructure(FAState);
        }

        public ArmyStructure Redo()
        {
            TurnState FAState = RedoStack.Peek().FAState;
            TurnState SAState = RedoStack.Peek().SAState;
            UndoStack.Push(RedoStack.Pop());
            AbstractProxy.LogUndoRedo(false);
            RestoreStates(FAState, SAState);
            return GetStructure(FAState);
        }

        public void SetStructure(ArmyStructure structure)
        {
            Structure = structure;
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
                    buffunits.Push(buffunit); // в стэк кладем голого юнита

                    RestoreConcreteBuffs(ArmyState, buffunits, i); // здесь в стэке сверху будет одетый, как было раньше, юнит

                    ArmyState.UnitList.RemoveAt(position); // удаляем голого юнита
                    ArmyState.UnitList.Insert(position, buffunits.Pop()); // добавляем одетого
                }
            }
        }
        void RestoreConcreteBuffs(TurnState ArmyState, Stack<IBuffable> buffunits, int i)
        {
            Stack<Buffs> tempstack = new Stack<Buffs>(ArmyState.UnitBuffs[i].Buffs);
            while (tempstack.Count > 0) // пока в стэке ещё есть бафы, надеваем их
            {
                Buffs buff = tempstack.Pop();
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

        ArmyStructures GetStructure()
        {
            if (Structure is StackStructure)
                return ArmyStructures.Stack;
            else if (Structure is LineStructure) 
                return ArmyStructures.Line;
            return ArmyStructures.Triplet;
        }

        ArmyStructure GetStructure(TurnState state)
        {
            if (state.Structure == ArmyStructures.Stack)
                return new StackStructure();
            else if (state.Structure == ArmyStructures.Line)
                return new LineStructure();
            return new TripletStructure();
        }
    }
}
