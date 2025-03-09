using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class MethodExample2
    {

        //Kullanıcıdan aldığı sayının karesini alıp 25 ten büyük olup olmadığını kontrol eden program 
        public static void Run()
        {
            Console.Write("Lütfen bir sayı giriniz: ");

            int entryValue = Convert.ToInt32(Console.ReadLine());

            int squaredValue = GetSquare(entryValue);

            if (squaredValue > 25)
            {
                Console.WriteLine("Girdiğiniz sayının karesi 25' ten büyüktür");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayının karesi 25' ten küçüktür");
            }

        }

        public static int GetSquare(int a)
        {
             int squaredNum = a * a;
             return squaredNum;
        }
    }
}
