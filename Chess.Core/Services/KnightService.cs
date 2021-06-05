using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Chess.Core.Services
{
    public class KnightService : IChessPiece
    {
        public bool Movement(string line)
        {
            Regex knight = new Regex(@"^K[a-h][1-8]-[a-h][1-8]");
            return (knight.IsMatch(line)) ? true : false;
        }
    }
}
