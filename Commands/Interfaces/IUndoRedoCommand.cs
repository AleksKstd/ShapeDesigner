using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDesigner.Commands.Interfaces
{
    public interface IUndoRedoCommand
    {
        void Undo();
        void Redo();
    }
}
