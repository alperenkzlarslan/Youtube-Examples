using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class MethodExample4
    {
        public static void Run()
        {
            //Kullanıcıcdan 2 tane sayı alan ve hangisinin büyük olduğunu gösteren kodu yazalım. 

            Console.Write("Lütfen 1. sayınızı giriniz: ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2. sayınızı giriniz: ");
            int numberTwo = int.Parse(Console.ReadLine());

            Control(numberOne, numberTwo);

        }

        public static void Control(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine(x + ">" + y);
            }
            else if (x == y)
            {
                Console.WriteLine(x + "=" + y);
            }
            else
            {
                Console.WriteLine(y + ">" + x);
            }


        }
    }
}
