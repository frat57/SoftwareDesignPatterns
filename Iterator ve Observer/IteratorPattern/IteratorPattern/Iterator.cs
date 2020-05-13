using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        // Constructor
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Gets first item
        public Pizza First()
        {
            current = 0;
            return collection.GetPizza(current);
        }
        // Gets next item
        public Pizza Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetPizza(current);
            }
            else
            {
                return null;
            }
        }
        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }
    }
}
