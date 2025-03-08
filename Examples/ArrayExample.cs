using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class ArrayExample
    {
        public static void Run()
        {
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 15;
            numbers[2] = 23;
            numbers[3] = 33;
            numbers[4] = 44;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Sayılar: " + numbers[i]);
            }

            string[] names = {"Alperen", "Ramazan", "Baki", "Özkan", "Merve"};

            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine("İsimler: " + names[j]);
            }

            double[] doubNumbers = {10.10, 15.20, 2.2, 23.44};

            for (int i = 0; i < doubNumbers.Length; i++)
            {
                Console.WriteLine("Ondalıklı sayılar: " + doubNumbers[i]);
            }

            int[] nums = new int[4]; 

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Sayılar dizisinin " + i + ". index değerini giriniz: ");

                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("*************************");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
