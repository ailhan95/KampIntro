using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ali";
            int yas = 26;

            Kurs kurs1 = new Kurs();  //verinin tipi kurs oluyor artık aşağıda class da ne tanımlandıysa hepsi oluyor //2. ders 2. saatte anlattı

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ali İlhan";
            kurs1.IzlenmeOrani = 95;

            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "C++";                              // kurs1 veya 2 farketmez dedikten sonra . koyup class kısmında tanımladığımız değişken adlarını girince
            kurs2.Egitmen = "Fatma İlhan";                      // o değişkenin tipinide girmiş oluyoruz haliyle
            kurs2.IzlenmeOrani = 78;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Mehmet İlhan";
            kurs3.IzlenmeOrani = 69;

            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);            // burda kurs1-2-3 içinden veriyi toplu bir şekilde çekebiliyoruz // 2. ders 2,30 civarında
            }

        }
    }

    class Kurs //sanki kendi veri tipimizi yazıyormuşuz gibi
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }


    }
}
