using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "ilker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);      // burda programı çalıştırınca isimlerin dizisinin 0 ıncı elemanı olan engini yazdırmadı çünkü 
                                                // 15. satırda isimler dizisine yeni bir değer atadık 5 tane verili içi boş bir hale geldi altındada 4. elemanı ilker olarak tanımladık
                                                //içi boş olduğu için 0 ıncı elemanı yaz diyince bu sefer yazdırmadı çünkü yeni dizimizin 0 ıncı elemanı boş

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");                  //yukardaki gibi en son 0 ıncı değeri kaybetmiyoruz çünkü list dediğimizde add komutuyla içine eklemeler yapabiliriz
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);




        }
    }
}
