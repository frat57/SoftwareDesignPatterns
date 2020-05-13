using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface AbstractIterator
    {
        Pizza First();
        Pizza Next();
        bool IsCompleted { get; }
    }
}
