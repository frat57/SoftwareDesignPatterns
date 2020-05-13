using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddPizza(new Pizza("Karışık", 100));
            collection.AddPizza(new Pizza("Margarita", 101));
            collection.AddPizza(new Pizza("Kampüs", 102));
            collection.AddPizza(new Pizza("Keyfim", 103));
            collection.AddPizza(new Pizza("Sucuk Zengini", 104));
            collection.AddPizza(new Pizza("Şımartan", 105));
            collection.AddPizza(new Pizza("Yaprak Dönerli", 106));

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Pizza pz = iterator.First(); !iterator.IsCompleted; pz = iterator.Next())
            {
                Console.WriteLine($"ID : {pz.ID} & Name : {pz.Name}");
            }
            Console.Read();
        }
    }
}
