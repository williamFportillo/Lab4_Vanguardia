using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Core
{
    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
