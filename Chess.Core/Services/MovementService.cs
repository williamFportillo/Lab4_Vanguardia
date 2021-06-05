using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Chess.Core.Services
{
    public class MovementService : IMovementsValidation
    {
        public string isValid(ConcreteAggregate results)
        {
            Iterator i = results.CreateIterator();
            object piece = i.First();
            while (piece != null)
            {
                if ((bool)piece)
                {
                    return " Es un movimiento valido";
                }
                piece = i.Next();
            }

            return  " no es un movimiento valido";
        }

        public string Movements(IChessPiece[] pieces, string line)
        {
            ConcreteAggregate results = new ConcreteAggregate();
            int pos = 0;
            foreach (var piece in pieces)
            {
                results[pos] = piece.Movement(line);
                pos++;
            }

            return isValid(results);
        }
    }
}
