using System;

namespace _3.dersOdevleriMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);  // burdaki ref keyword ünü kaldırırsan sonuç 20 olur fakat ref yazınca referans değerini baz al demek oluyor // ref yerine out da yazılabilir // hocanın youtubedaki 25. dersinde anlatıyor farkını
            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
            Console.WriteLine(Add4(4, 5, 6, 8));
        }

        static void Add()
        {
            Console.WriteLine("Added!!!");


        }

        static int Add2(int number1=20 , int number2=30)            // burda parantezin içindeki değerler default değer yani veri girilmez ise o zaman number2 =30 olarak sayılacak
        {
            var result = number1 + number2;
            return result;

        }


        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Add4 (int number,params int[] numbers)
        {
            return numbers.Sum();



        }
        



    }
}
