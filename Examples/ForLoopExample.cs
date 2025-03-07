using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class ForLoopExample
    {
        public static void Run()
        {
            //1 den 10 a kadar olan sayıları yazdırma 

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            //0 den 10 a kadar olan sayılarda çift olanları yazdıralım 

            for (int a = 0; a <= 10; a += 2)
            {
                Console.WriteLine(a);
            }

            //İç içe for döngüsü - 

            for (int x = 1; x <= 10; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine("");
            }
        }
    }
}
