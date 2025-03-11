using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class StaticExample
    {
        //Static anahtar kelimesi kullanılırsa obje oluşturmadan sınıf methodlarına erişim sağlanabilir
        public static void WriteFullName()
        {
            Console.WriteLine("Alperen Kızılarslan");
        }

        public static void Sum(int num1, int num2)
        {
            Console.WriteLine("İki sayının toplamı: " + (num1 + num2));
        }

        public int personalId;
        public string name;
        public string surname;

        public static int salary;

    }

}


