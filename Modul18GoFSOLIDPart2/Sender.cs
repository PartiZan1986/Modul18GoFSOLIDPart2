using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul18GoFSOLIDPart2
{
    internal class Sender
    {
        ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void GetTitle()
        {
            _command.Execute();
        }

        public void GetDownload()
        {
            _command.Undo();
        }
    }
}
