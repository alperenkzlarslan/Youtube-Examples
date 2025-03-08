using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class DoWhileLoopExample
    {
        public static void Run()
        {
            //1' den 10'a kadar olan sayıları do while ile ekrana yazdırınız

            int starterNum = 1;

            do
            {
                Console.WriteLine(starterNum);
                starterNum++;

            } while (starterNum <= 10);

            //1'den 100'e kadar olan sayıların toplamı 

            int beginerNUm = 1;
            int result = 0;

            do
            {
                result += beginerNUm;
                beginerNUm++;

            } while (beginerNUm <= 100);

            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı: " + result);
        }
    }
}
