using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(int ID, string Isim, string Soyisim) 
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.TC = ID;
            yeniMusteri.Isim = Isim;
            yeniMusteri.Soyisim = Soyisim;

            musteriler.Add(yeniMusteri);

        }

        public void MusteriGoster() 
        {
            foreach (Musteri musteri in musteriler) 

            {
                Console.WriteLine(musteri.Isim +" "+ musteri.Soyisim );
            }
        
        }

        

    }
}
