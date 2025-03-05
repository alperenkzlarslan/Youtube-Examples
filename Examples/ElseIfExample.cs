using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class ElseIfExample
    {
        public static void Run()
        {
            //kullanıcıdan 3 tane not alan ve notların ortalamsına göre başarı oranını söyleyen program 
            //80-100 AA / 60-80 BB / 40-60 CC / 40 dan küçükse FF 

            Console.WriteLine("Birinci ders notunuzu giriniz: ");
            int lesson1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci ders notunuzu giriniz: ");
            int lesson2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üçüncü ders notunuzu giriniz: ");
            int lesson3 = Convert.ToInt32(Console.ReadLine());

            int lessonAverage = (lesson1 + lesson2 + lesson3) / 3;

            Console.WriteLine("Not ortalamanız: " + lessonAverage);
            Console.WriteLine("Harf notunuz hesaplanıyor...");

            if (lessonAverage >= 80 && lessonAverage <= 100)
            {
                Console.WriteLine("Harf notunuz: AA");
            }
            else if (lessonAverage >= 60 && lessonAverage <= 79)
            {
                Console.WriteLine("Harf notunuz: BB");
            }
            else if (lessonAverage >= 40 && lessonAverage <= 59)
            {
                Console.WriteLine("Harf notunuz: CC");
            }
            else
            {
                Console.WriteLine("Harf Notunuz: FF");
            }
        }
    }
}
