using ShapeDesigner.Commands.Interfaces;
using ShapeDesigner.Models.Figures;

namespace ShapeDesigner.Commands.Models
{
    internal class ChangeCommand : IUndoRedoCommand
    {
        private int _oldX;
        private int _oldY;
        private int _newX;
        private int _newY;
        private Figure? _figure;

        public ChangeCommand(int oldX, int oldY, Figure figure)
        {
            _figure = figure;
            _newX = figure.X;
            _newY = figure.Y;
            _oldX = oldX;
            _oldY = oldY;
        }

        public void Undo()
        {
            _figure.X = _newX;
            _figure.Y = _newY;
        }

        public void Redo()
        {
            _figure.X = _oldX;
            _figure.Y = _oldY;
        }
    }
}
