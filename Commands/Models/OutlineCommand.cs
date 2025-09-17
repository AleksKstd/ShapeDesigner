using ShapeDesigner.Commands.Interfaces;
using ShapeDesigner.Models.Figures;
using System.Drawing;

namespace ShapeDesigner.Commands.Models
{
    internal class OutlineCommand : IUndoRedoCommand
    {
        private Color _oldColor;
        private Color _newColor;
        private Figure _figure;

        public OutlineCommand(Color newColor, Figure figure)
        {
            _figure = figure;
            _oldColor = figure.OutlineColor;
            _newColor = newColor;
        }

        public void Undo()
        {
            _figure.OutlineColor = _newColor;
        }

        public void Redo()
        {
            _figure.OutlineColor = _oldColor;
        }
    }
}
