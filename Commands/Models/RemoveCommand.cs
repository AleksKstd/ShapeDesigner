using ShapeDesigner.Commands.Interfaces;
using ShapeDesigner.Models.Figures;
using System.Collections.Generic;

namespace ShapeDesigner.Commands.Models
{
    internal class RemoveCommand : IUndoRedoCommand
    {
        private Figure _figure;
        private List<Figure> _figures;
        public RemoveCommand(List<Figure> figures, Figure figure)
        {
            _figure = figure;
            _figures = figures;
        }
        public void Undo()
        {
            _figures.Remove(_figure);
        }
        public void Redo()
        {
            _figures.Add(_figure);
        }
    }
}
