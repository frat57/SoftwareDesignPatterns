using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Berber deneme = new Berber();
            Cirak b1 = new Cirak(deneme);
            
            b1.SacMaliyet(40);
            b1.SakalMaliyet(20);
            b1.Name("Firat");
            IBerber berber = new Berber();
            berber.SacKes();
            berber.SakalKes();
            Console.WriteLine("Shallow Copy öncesi");
            Cirak b2 = b1;
            b2.SacMaliyet(50);
            b2.SakalMaliyet(50);
            b2.Name("Batuhan");
            b2.Yazdir();
            b1.Yazdir();
            Console.WriteLine("Shallow Copy bitişi");
            Cirak b3 = b1.Deepcopy();
            b3.SacMaliyet(30);
            b3.SakalMaliyet(40);
            b3.Name("Zeki");
            b3.Yazdir();
            b1.Yazdir();
        }
    }
    public interface IBerber
    {
        void SacKes();
        void SakalKes();
    }
    class Berber : IBerber
    {
        public void SacKes()
        {
            Console.WriteLine("Saçlar  kesildi.");
        }
        public void SakalKes()
        {
            Console.WriteLine("Sakallar  kesildi.");
        }

    }
    public abstract class Usta : IBerber
    {
        private IBerber berber;
        public int sac { get; set; }
        public int sakal { get; set; }
        public string name { get; set; }

        public void SacMaliyet(int sac)
        {
            this.sac = sac;
            Console.WriteLine("Saç kesme ücreti:" + sac);
        }
        public void SakalMaliyet(int sakal)
        {
            this.sakal = sakal;
            Console.WriteLine("Sakal kesme ücreti:" + sakal);
        }
        public void Name(string name)
        {
            this.name = name;
            Console.WriteLine("Kime saç sakal hizmeti verildi:" + name);
        }
        public Usta(IBerber b)
        {
            berber = b;
        }
        public virtual void SacKes()
        {
            berber.SacKes();
        }

        public virtual void SakalKes()
        {
            berber.SakalKes();
        }
       
        public void Yazdir()
        {
            Console.WriteLine("id:" + this.GetHashCode() + "  sac=" + this.sac + "  sakal=" + this.sakal + "  isim=" + this.name);
        }

    }
    public  class Cirak : Usta
    {
        private IBerber berber;
        public Cirak(IBerber b) : base(b)
        {
            berber = b;
        }
        public override void SacKes()
        {
            base.SacKes();
        }

        public override void SakalKes()
        {
            base.SakalKes();
        }
        public Cirak Deepcopy()
        {
            return (Cirak)this.MemberwiseClone();
        }
    }
}
