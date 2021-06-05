using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chess.Core.Interfaces
{
    public interface IMovementSource
    {
        StreamReader GetMovementsFromSource(string file);
    }
}
