using ShapeDesigner.Commands.Interfaces;
using ShapeDesigner.Models.Figures;

namespace ShapeDesigner.Commands.Models
{
    internal class ResizeCommand : IUndoRedoCommand
    {
        private int _oldWidth;
        private int _oldHeight;
        private int _newWidth;
        private int _newHeight;
        private readonly Figure _figure;

        public ResizeCommand(Figure figure, int newWidth, int newHeight)
        {
            _figure = figure;
            _newWidth = newWidth;
            _newHeight = newHeight;
            _oldWidth = figure.Width;
            _oldHeight = figure.Height;
        }
        public void Redo()
        {
            _figure.Width = _newWidth;
            _figure.Height = _newHeight;
        }

        public void Undo()
        {
            _figure.Width = _oldWidth;
            _figure.Height = _oldHeight;
        }
    }
}
