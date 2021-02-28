using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager    // burda ekleme fonksiyonu yazıcaz
    {
        //encapsulation
        public  void Add(Product product)  // product tipinde bir product ver yani ürün ver demek istedik
        {
            Console.WriteLine(product.ProductName + "eklendi.");

        }

        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");

        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;                   // çıkan sonucu tekrar kullanabilmek adına return kullanıyoruz publicden sonra int dememizin sebebi sonucu bellekte tutmak 
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi2);       // burda çıkan sonuç sadece ekrana yazdırılıyor daha sonra o veriyi işleme alamıyoruz tek seferlik bir işlem oluyor

        }
    }
}
