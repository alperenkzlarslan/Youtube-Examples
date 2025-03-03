using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class ShortExample
    {
        public static void Run()
        {

            // Short veri tipi -32768 ile 32767 sayıları arasında değer tutabilir 

            short shortNumber1 = -100;
            short shortNumber2 = 29999;

            short minValue = short.MinValue;
            short maxValue = short.MaxValue;

            Console.WriteLine(minValue);
            Console.WriteLine(maxValue);
            Console.WriteLine(shortNumber1);
            Console.WriteLine(shortNumber2);

        }
    }
}
