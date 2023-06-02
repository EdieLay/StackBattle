using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackBattle
{
    internal interface ICommand
    {
        bool IsUndoAvailable { get; }
        bool IsRedoAvailable { get; }
        void Execute();
        void Undo();
        void Redo();
        void SetStructure(ArmyStructure structure);
    }
}
