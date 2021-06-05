using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Core.Interfaces
{
    public interface IMovementsValidation
    {
        string Movements(IChessPiece[] pieces, string line);
        string isValid(ConcreteAggregate results);
    }
}
