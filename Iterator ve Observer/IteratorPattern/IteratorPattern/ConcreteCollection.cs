using System.Collections.Generic;

namespace IteratorPattern
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Pizza> listPizza = new List<Pizza>();
        //Create Iterator
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        // Gets item count
        public int Count
        {
            get { return listPizza.Count; }
        }
        //Add items to the collection
        public void AddPizza(Pizza pizza)
        {
            listPizza.Add(pizza);
        }
        //Get item from collection
        public Pizza GetPizza(int IndexPosition)
        {
            return listPizza[IndexPosition];
        }
    }
}