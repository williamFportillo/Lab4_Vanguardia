using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chess.Core.Interfaces
{
    public interface IChessPiece
    {
          bool Movement(string line);
    }
}
