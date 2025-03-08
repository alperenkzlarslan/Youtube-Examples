using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class WhileLoopExample
    {
        public static void Run()
        {
            //1 den 10 a kadar olan sayıları yazdırma

            int count = 1;

            while (count <= 10)
            {
                Console.WriteLine(count);
                count++;
            }

            //100 den 0 a kadar olan sayıların çift olanlarını yazdırma 

            int sCount = 100;

            while (sCount >= 0)
            {
                Console.WriteLine(sCount);
                sCount -= 2;
            }

        }
    }
}
