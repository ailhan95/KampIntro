using System;

namespace _2.Ders6.Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Urun1 = new Product();
            Urun1.UrunId = 01;
            Urun1.UrunAdi = "Beyoğlu Rapsodisi";
            Urun1.KategoriId = 103;
            Urun1.KategoriAdi = "Polisiye";
            Urun1.YazarId = 34;
            Urun1.YazarAdi = "Ahmet Ümit";
            Urun1.Fiyatı = 45;

            Product Urun2 = new Product();
            Urun2.UrunId = 02;
            Urun2.UrunAdi = "Körlük";
            Urun2.KategoriId = 53;
            Urun2.KategoriAdi = "Dünya Roman";
            Urun2.YazarId = 48;
            Urun2.YazarAdi = "Jose Saramago";
            Urun2.Fiyatı = 40;

            Product Urun3 = new Product();
            Urun3.UrunId = 03;
            Urun3.UrunAdi = "Semerkand";
            Urun3.KategoriId = 92;
            Urun3.KategoriAdi = "İran Edebiyatı";
            Urun3.YazarId = 36;
            Urun3.YazarAdi = "Amin Maalouf";
            Urun3.Fiyatı = 38;

            Product Urun4 = new Product();
            Urun4.UrunId = 04;
            Urun4.UrunAdi = "Bu Ülke";
            Urun4.KategoriId = 28;
            Urun4.KategoriAdi = "Sosyoloji";
            Urun4.YazarId = 14;
            Urun4.YazarAdi = "Cemil Meriç";
            Urun4.Fiyatı = 60;

            Product[] Urunler = new Product[] {Urun1,Urun2,Urun3,Urun4};



            for (int i = 0; i < Urunler.Length; i++)
            {
                Console.WriteLine(Urunler[i].UrunId + " : " + Urunler[i].UrunAdi + " , " + Urunler[i].YazarAdi + " , " + Urunler[i].KategoriAdi + " , " + Urunler[i].Fiyatı + "TL");
            }




            foreach (var pro in Urunler)
            {
                Console.WriteLine(pro.UrunId + " : " + pro.UrunAdi + " , " + pro.YazarAdi + " , " + pro.KategoriAdi + " , " + pro.Fiyatı + "TL");
            }





            int a = 0;
            while (a<Urunler.Length)
            {
                Console.WriteLine(Urunler[a].UrunId + " : " + Urunler[a].UrunAdi + " , " + Urunler[a].YazarAdi + " , " + Urunler[a].KategoriAdi + " , " + Urunler[a].Fiyatı + "TL");
                a++;
            }

        }
    }




    class Product
    {
        public int UrunId { get; set; }

        public string UrunAdi  { get; set; }

        public int KategoriId { get; set; }

        public string KategoriAdi { get; set; }

        public int YazarId { get; set; }

        public string YazarAdi { get; set; }

        public int Fiyatı { get; set; }


    }





}
