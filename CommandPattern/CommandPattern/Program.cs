using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            KlimaAcKomutu klimaAcKomutu = new KlimaAcKomutu(new Kumanda());
            KlimaKapatKomutu klimaKapatKomutu = new KlimaKapatKomutu(new Kumanda());
            SicaklikArtirKomutu sicaklikArtirKomutu = new SicaklikArtirKomutu(new Kumanda());
            SicaklikAzaltKomutu sicaklikAzaltKomutu = new SicaklikAzaltKomutu(new Kumanda());
            KomutIletici kumanda = new KomutIletici();
            kumanda.Calistir(klimaAcKomutu);
            kumanda.Calistir(klimaKapatKomutu);
            kumanda.Calistir(sicaklikArtirKomutu);
            kumanda.Calistir(sicaklikAzaltKomutu);

        }
    }

    public class Kumanda
    {
        public void KlimaAc() => Console.WriteLine("Klima Açılmıştır");
        public void KlimaKapat() => Console.WriteLine("Klima Kapatılmıştır.");
        public void SıcaklıkArtır() => Console.WriteLine("Sıcaklık Arttı.");
        public void SıcaklıkAzalt() => Console.WriteLine("Sıcaklık Azaldı.");

    }

    public interface IKomut
    {
        void Calistir();
    }

    public class KlimaAcKomutu : IKomut
    {
        private Kumanda kumanda;
        public KlimaAcKomutu(Kumanda kumanda)
        {
            this.kumanda = kumanda;
        }

        public void Calistir()
        {
            kumanda.KlimaAc();
        }
    }
    public class KlimaKapatKomutu : IKomut
    {
        private Kumanda kumanda;
        public KlimaKapatKomutu(Kumanda kumanda)
        {
            this.kumanda = kumanda;
        }

        public void Calistir()
        {
            kumanda.KlimaKapat();
        }
    }
    public class SicaklikArtirKomutu : IKomut
    {
        private Kumanda kumanda;
        public SicaklikArtirKomutu(Kumanda kumanda)
        {
            this.kumanda = kumanda;
        }

        public void Calistir()
        {
            kumanda.SıcaklıkArtır();
        }
    }
    public class SicaklikAzaltKomutu : IKomut
    {
        private Kumanda kumanda;
        public SicaklikAzaltKomutu(Kumanda kumanda)
        {
            this.kumanda = kumanda;
        }

        public void Calistir()
        {
            kumanda.SıcaklıkAzalt();
        }
    }
    public class KomutIletici
    {
        public void Calistir(IKomut komut)
        {
            komut.Calistir();
        }
    }
}
