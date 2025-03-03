using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class LongExample
    {
        public static void Run()
        {
            //Long veri tipi -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasındaki değerleri tutabilir
            //Ram bellekte 8 byte yer kaplar

            long longNumber = 1854651284;
            long negatifLongNumber = -2154823189051;
            long minValue = long.MinValue;
            long maxValue = long.MaxValue;

            Console.WriteLine("Long Example: " + longNumber);
            Console.WriteLine("Negatif Long Example: " + negatifLongNumber);
            Console.WriteLine("Long Min Value: " + minValue);
            Console.WriteLine("Long Max Value: " + maxValue);
        }
    }
}
