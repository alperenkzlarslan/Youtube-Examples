using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class MethodExample
    {
        //Parametresiz - Geriye değer döndürmeyen method tanımlama 
        // Void = geriye değer döndürmeyen anahtar kelime, çıktı veren gibi 

       public static void SayHi()
        {
            Console.WriteLine("Merhabalar...");

        }

        public static void WriteYourName()
        {
            Console.WriteLine("Alperen Kızılarslan");

        }

        //Parametre alan method tanımlama 
        public static void Sum(int num1, int num2)
        {
            Console.WriteLine("Girilen sayıların toplamı: " + (num1 + num2));
        }

        public static void Cross(int num1, int num2, int num3)
        {
            Console.WriteLine("Girilen 3 sayının çarpımı: " + (num1 * num2 * num3));
        }

        public static void WriteFullName(string name, string surname)
        {
            Console.WriteLine("Ad ve soyad: " + name + " " + surname);
        }

        //Parametre alan ve geriye değer döndüren method tanımlama 

        public static int DoSum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

       

        public static void Run()
         {
            int returnedValue = DoSum(10, 44);

            Console.WriteLine(returnedValue);
        }


        


    }
}
