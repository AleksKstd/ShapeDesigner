using ShapeDesigner.Commands.Interfaces;
using ShapeDesigner.Models.Figures;
using System.Drawing;

namespace ShapeDesigner.Commands.Models
{
    internal class FillColorCommand : IUndoRedoCommand
    {
        private Color _oldColor;
        private Color _newColor;
        private Figure _figure;

        public FillColorCommand(Figure figure, Color newColor)
        {
            _figure = figure;
            _oldColor = figure.FillColor;
            _newColor = newColor;
        }

        public void Undo()
        {
            _figure.FillColor = _newColor;
        }
        public void Redo()
        {
            _figure.FillColor = _oldColor;
        }
    }
}
