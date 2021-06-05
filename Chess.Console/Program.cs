using Chess.Core.Interfaces;
using Chess.Core.Services;
using Chess.Infraestructure;
using System;

namespace Chess
{
    public class Program
    {
        
        public  static void Main(string[] args)
        {
            var  fileSource = new FileMovementSource();
            var source = fileSource.GetMovementsFromSource("movements.txt");
            var piece = new MovementService();
            string line;
            IChessPiece[] pieces =
            {
                new PawnService(),
                new RookService(),
                new KnightService()
            };
            while ((line = source.ReadLine()) != null)
            {
                ConsoleLogger.Log(line + piece.Movements(pieces, line));
            }
            
            
        }

    }
}
