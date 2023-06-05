using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StackBattle
{
    internal class ProxyCommand : ICommand
    {
        private ICommand _command;
        public string LogFile { get; private set; } = "LogFile.txt";

        public ProxyCommand(ICommand command)
        {
            _command = command;
            using StreamWriter writer = new(LogFile, false);
        }

        public bool IsUndoAvailable { get { return _command.IsUndoAvailable; } }
        public bool IsRedoAvailable { get { return _command.IsRedoAvailable; } }

        public void Execute()
        {
            _command.Execute();
        }
        
        public void Undo()
        {
            _command.Undo();
        }

        public void Redo()
        {
            _command.Redo();
        }

        public void SetStructure(ArmyStructure structure)
        {
            _command.SetStructure(structure);
        }

        public void Log()
        {
            using StreamWriter writer = new(LogFile, true);
            writer.Write(DateTime.Now);
        }
    }
}
