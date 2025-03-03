using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class DoubleExample
    {
        public static void Run()
        {
            //Ram bellekte 8 byte yer kaplar 
            //15 basamaklı ondalıklı sayıları tutabilir 

            double dNumber = 156.321564;
            double negDNumber = -15454.6545;

            Console.WriteLine("Double value: " + dNumber);
            Console.WriteLine("Negatif double value : " + negDNumber);
            Console.WriteLine("Double Min Value: " + double.MinValue);
            Console.WriteLine("Double Max Value: " + double.MaxValue);
        }
    }
}
