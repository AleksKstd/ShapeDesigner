using ShapeDesigner.Commands.Interfaces;
using System.Collections.Generic;

namespace ShapeDesigner.Commands.Controllers
{
    public class CommandController
    {
        private readonly List<IUndoRedoCommand> _commands = new List<IUndoRedoCommand>();
        private int _currentCommandIndex = -1;

        public void AddCommand(IUndoRedoCommand command)
        {
            if (_currentCommandIndex < _commands.Count - 1)
            {
                _commands.RemoveRange(_currentCommandIndex + 1, _commands.Count - _currentCommandIndex - 1);
            }
            _commands.Add(command);
            command.Undo();
            _currentCommandIndex = _commands.Count - 1;
        }

        public void Undo()
        {
            if (_currentCommandIndex <= _commands.Count - 1)
            {
                _currentCommandIndex++;
                _commands[_currentCommandIndex].Undo();
            }
        }

        public void Redo()
        {
            if (_currentCommandIndex >= 0)
            {
                _commands[_currentCommandIndex].Redo();
                _currentCommandIndex--;
            }
        }
    }
}
