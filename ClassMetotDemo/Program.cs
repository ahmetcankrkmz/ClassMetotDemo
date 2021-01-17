using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager mm = new MusteriManager();
            mm.MusteriEkle(1, "Ahmet", "Korkmaz");
            mm.MusteriEkle(2, "Serkan", "Uludag");
            mm.MusteriEkle(2, "Alper", "Uslu");

            mm.MusteriGoster();


        }
    }
}
