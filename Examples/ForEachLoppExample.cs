using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class ForEachLoppExample
    {
        public static void Run()
        {
            string[] names = { "Alperen", "Merve", "Özkan", "Kadir", "Suzan" };

            foreach (string i in names)
            {
                Console.WriteLine(i);
            }

            int[] numbers = { 1, 23, 44, 18, 12 };

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }


            int[] numbersArray = { 10, 20, 30, 40, 40, 50, 10, 35, 65, 55, 75, 5, 5, 7, 12, 23, 44, 80, 90, 80, 90, 100, 125 };

            int num;
            int total = 0;

            Console.Write("Lütfen bir sayı giriniz: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numbersArray.Length; i++)
            {
                if (num == numbersArray[i])
                {
                    total++;
                }
            }
            if (total == 0)
            {
                Console.WriteLine("Girdiğiniz sayı dizide bulunamadı");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayının dizideki adeti: " + total);
            }
        }
    }
}
