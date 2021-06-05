using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Chess.Core.Services
{
    public class PawnService : IChessPiece
    {
        public bool Movement(string line)
        {
            Regex pawn = new Regex(@"^[a-h][1-8]-[a-h][1-8]");
            return (pawn.IsMatch(line)) ? true : false;
        }
    }
}
