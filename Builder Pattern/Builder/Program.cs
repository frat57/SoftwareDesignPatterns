using System;
using System.Collections.Generic;


namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            TostBuilder builder;

            Shop shop = new Shop();

            builder = new KarisikBuilder();
            shop.Construct(builder);
            builder.Tost.Show();

            builder = new KasarliBuilder();
            shop.Construct(builder);
            builder.Tost.Show();

            builder = new AyvalikBuilder();
            shop.Construct(builder);
            builder.Tost.Show();

            Console.ReadKey();
        }
    }
    class Shop

    {
        // Builder uses a complex series of steps

        public void Construct(TostBuilder tostBuilder)
        {
            tostBuilder.BuildKetchup();
            tostBuilder.BuildButter();
            tostBuilder.BuildSausage();
            tostBuilder.BuildCheddarcheese();
        }
    }

    /// <summary>

    /// The 'Builder' abstract class

    /// </summary>

    abstract class TostBuilder

    {
        protected Tost tost;

        // Gets tost instance

        public Tost Tost
        {
            get { return tost; }
        }

        public abstract void BuildKetchup();
        public abstract void BuildButter();
        public abstract void BuildSausage();
        public abstract void BuildCheddarcheese();
    }

    class KarisikBuilder : TostBuilder

    {
        public KarisikBuilder()
        {
            tost = new Tost("Karışık Tost");
        }

        public override void BuildKetchup()
        {
            tost["ketchup"] = "Ketçaplı";
        }

        public override void BuildButter()
        {
            tost["butter"] = "Tereyağlı";
        }

        public override void BuildSausage()
        {
            tost["sausage"] = "Sucuklu";
        }

        public override void BuildCheddarcheese()
        {
            tost["cheddarcheese"] = "Kaşarlı";
        }
    }


    /// <summary>

    /// The 'ConcreteBuilder2' class

    /// </summary>

    class KasarliBuilder : TostBuilder

    {
        public KasarliBuilder()
        {
            tost = new Tost("Kaşarlı Tost");
        }

        public override void BuildKetchup()
        {
            tost["ketchup"] = "ketçaplı";
        }

        public override void BuildButter()
        {
            tost["butter"] = "Tereyağlı";
        }

        public override void BuildSausage()
        {
            tost["sausage"] = "yok";
        }

        public override void BuildCheddarcheese()
        {
            tost["cheddarcheese"] = "Kaşarlı";
        }
    }

    /// <summary>

    /// The 'ConcreteBuilder3' class

    /// </summary>

    class AyvalikBuilder : TostBuilder

    {
        public AyvalikBuilder()
        {
            tost = new Tost("Ayvalık Tost");
        }

        public override void BuildKetchup()
        {
            tost["ketchup"] = "yok";
        }

        public override void BuildButter()
        {
            tost["butter"] = "Tereyağlı";
        }

        public override void BuildSausage()
        {
            tost["sausage"] = "Sucuklu";
        }

        public override void BuildCheddarcheese()
        {
            tost["cheddarcheese"] = "Kaşarlı";
        }
    }

    /// <summary>

    /// The 'Product' class

    /// </summary>

    class Tost

    {
        private string _tostType;
        private Dictionary<string, string> _parts =
          new Dictionary<string, string>();

        // Constructor

        public Tost(string tostType)
        {
            this._tostType = tostType;
        }

        // Indexer

        public string this[string key]
        {
            get { return _parts[key]; }
            set { _parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine(" Tost Type: {0}", _tostType);
            Console.WriteLine(" Ketchup : {0}", _parts["ketchup"]);
            Console.WriteLine(" Butter : {0}", _parts["butter"]);
            Console.WriteLine(" #Sausage: {0}", _parts["sausage"]);
            Console.WriteLine(" #Cheddar Cheese : {0}", _parts["cheddarcheese"]);
        }
    }
}
