using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {   

        //naming convention
        public void Ekle(Urun urun)         //3. ders 1,25 civarı anlatıyor // urun tipindeki urunleri çağırıyoruz burda // burda bir metot belirliyoruz bu metodu program cs nin içinde çağırdık
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }


    }
}
