using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    class Pizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Pizza(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}
