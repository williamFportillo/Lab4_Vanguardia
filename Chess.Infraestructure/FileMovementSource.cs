using Chess.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chess.Infraestructure
{
    public class FileMovementSource : IMovementSource
    {
        public StreamReader GetMovementsFromSource(string file)
        {
            StreamReader File = new StreamReader(file);
            return File;
        }
    }
}
