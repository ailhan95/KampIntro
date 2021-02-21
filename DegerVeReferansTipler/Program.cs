using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??

            Console.WriteLine(sayi1);       //3. ders 2,15 civarı // burdaki olay sayi1 le sayi 2 yi eşitleyincew sayi1 e yeni değer olarak sayi 2 yi atamış oluyoruz

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;                      // burdada üsttekinin aynısı oluyor fakat en son sayılar2 nin sıfırıncı elemanına yeni değer atadığımız için sonuç 999 oluyor
                                                    // veri tiplerini 3. ders 2,24 civarında anlaytıyor


        }
    }
}
