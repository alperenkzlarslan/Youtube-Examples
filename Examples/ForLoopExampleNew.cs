using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class ForLoopExampleNew
    {
        public static void Run()
        {
            Console.WriteLine("Lütfen bir sayı giriniz: ");

            int number = Convert.ToInt32(Console.ReadLine());

            int total = 0;

            for (int i = 1; i <= number; i++)
            {
                total += i;
            }

            double average = total / number;

            if (average >= 50)
            {
                Console.WriteLine("Ortalamanız 50' den büyüktür");
            }
            else
            {
                Console.WriteLine("Ortalamanız 50' den küçüktür");
            }
        }
    }
}
