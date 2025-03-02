using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class ByteExample
    {
        public static void Run()
        {

            byte byteNumber1 = 5;
            byte byteNumber2 = 10;
            byte byteNumber3 = 255; // Byte = 0-255
            byte maxValue = byte.MaxValue;
            byte minValue = byte.MinValue;

            Console.WriteLine(byteNumber1);
            Console.WriteLine(byteNumber2);
            Console.WriteLine(byteNumber3);
            Console.WriteLine(minValue);
            Console.WriteLine(maxValue);

        }
    }
}
