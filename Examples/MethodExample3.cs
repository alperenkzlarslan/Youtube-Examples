using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class MethodExample3
    {
        public static void Run()
        {
            Console.Write("Lütfen bir sayı giriniz: ");

            int entryValue = Convert.ToInt32(Console.ReadLine());

            int controledValue = Control(entryValue);

        }

        public static int Control(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çift sayıdır");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tek sayıdır");
            }
            return x;
        }
    }
}
