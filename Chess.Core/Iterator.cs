using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.Core
{
    public abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract object IsDone();
        public abstract object CurrentItem();
    }
}
