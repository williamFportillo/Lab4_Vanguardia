using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Chess.Core.Services
{
    public class RookService : IChessPiece
    {
        public bool Movement(string line)
        {
            Regex rook = new Regex(@"^R[a-h][1-8]-[a-h][1-8]");
            return (rook.IsMatch(line)) ? true : false;
        }
    }
}
