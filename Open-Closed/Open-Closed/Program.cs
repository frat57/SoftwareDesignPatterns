using System;

namespace Open_Closed
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop(100,100,100,100);
            Desktop desktop = new Desktop(100, 100, 100, 100);
            laptop.Olusturmak();
            laptop.Fiyat();
            desktop.Olusturmak();
            desktop.Fiyat();
        }
    }

    public abstract class Bilgisayar
    {
        public abstract void Fiyat();
        public abstract void Olusturmak();

    }
    public class Laptop : Bilgisayar
    {
        public int Islemci { get; set; }
        public int Ram { get; set; }
        public int EkranKarti { get; set; }
        public int AnaKart { get; set; }
        public Laptop(int Islemci,int ram,int EkranKarti,int AnaKart)
        {
            this.Islemci = Islemci;
            this.Ram = ram;
            this.EkranKarti = EkranKarti;
            this.AnaKart = AnaKart;
        }
        public override void Fiyat()
        {
            Console.WriteLine(this.Islemci + this.Ram + this.EkranKarti + this.AnaKart);
        }
        public override void Olusturmak()
        {
            Console.WriteLine("Laptop oluşturuldu.");
        }

    }
    public class Desktop : Bilgisayar
    {
        public int Islemci { get; set; }
        public int Ram { get; set; }
        public int EkranKarti { get; set; }
        public int AnaKart { get; set; }
        public Desktop(int Islemci, int ram, int EkranKarti, int AnaKart)
        {
            this.Islemci = Islemci;
            this.Ram = ram;
            this.EkranKarti = EkranKarti;
            this.AnaKart = AnaKart;
        }
        public override void Fiyat() {
            Console.WriteLine(this.Islemci + this.Ram + this.EkranKarti + this.AnaKart);
        }
        public override void Olusturmak()
        {
            Console.WriteLine("Desktop oluşturuldu.");
        }
    }
}
