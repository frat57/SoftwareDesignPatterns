using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    interface AbstractCollection
    {
        Iterator CreateIterator();
    }
}
