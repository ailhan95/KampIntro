using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs"; 
            string kurs3 = "java";

            


            //array - dizi  2. ders 1,27 ler gibi anlatıyor

            string[] kurslar = new string[] {"Yazılım Geliştirici Kampı", "Programlamaya başlangıç için temel kurs" , "java", "python", "C#", "C++"};

            for (int i = 0; i < kurslar.Length; i++) // Program dilleri saymaya 0 dan başlar  //.length dediğimizde kursların kaç tane elemanı varsa kendisiğ sayıyor ona göre işlem yapıyor // 2. ders 1,35 ler
            {
                Console.WriteLine(kurslar[i]);
            }


            Console.WriteLine("for bitti");

            
            
            foreach (string kurs in kurslar) // foreach dizilere uygulanır // kursları tek tek dolaş demek
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("Sayfa Sonu - footer");


           
            
            
            for (int i = 1; i <= 10; i=i+4)  //   int i=1  başlangıç değeri , i<10 şart yani i eğer 10 dan küçükse , yapılacak işlem ++ olursa birer birer artırır demek i=i+1,i+2,i+3 gibide yazılabilir
            {
                Console.WriteLine(i);       //2. ders 1.18 civarlarında anlatıyor
            }
        }
    }
}
