using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul18GoFSOLIDPart2
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
