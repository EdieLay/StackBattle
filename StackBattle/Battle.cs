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

        public bool IsUndoAvailable { get { return Command.IsUndoAvailable; } }
        public bool IsRedoAvailable { get { return Command.IsRedoAvailable; } }
        public bool IsFirstArmyBeingEdited { get; set; }
        public bool IsGameFinished { get; private set; } = false;

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

        public void DoTurn()
        {
            Command.Execute();
            if (FirstArmy.ArmySize == 0 || SecondArmy.ArmySize == 0)
                IsGameFinished = true;
        }

        public void DoBattle()
        {
            while (!IsGameFinished)
                DoTurn();
        }

        public void UndoTurn()
        {
            if (IsUndoAvailable)
                Command.Undo();
        }

        public void RedoTurn()
        {
            if (IsRedoAvailable)
                Command.Redo();
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

        public bool IsArmyPricesMatch()
        {
            if (FirstArmy.Price <= Price && SecondArmy.Price <= Price && FirstArmy.ArmySize > 0 && SecondArmy.ArmySize > 0)
                return true;
            return false;
        }
    }
}
