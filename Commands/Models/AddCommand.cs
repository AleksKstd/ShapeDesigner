using ShapeDesigner.Commands.Interfaces;
using ShapeDesigner.Models.Figures;
using System.Collections.Generic;

namespace ShapeDesigner.Commands.Models
{
    internal class AddCommand : IUndoRedoCommand
    {
        private Figure _figure;
        private List<Figure> _figures;
        public AddCommand(Figure figure, List<Figure> figures)
        {
            _figure = figure;
            _figures = figures;
        }
        public void Undo()
        {
            _figures.Add(_figure);
        }
        public void Redo()
        {
            _figures.Remove(_figure);
        }
    }
}
