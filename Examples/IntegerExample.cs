using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class IntegerExample
    {
        public static void Run()
        {
            //Int veri tipi -2.147.483.648 ile 2.147.483.647 arasında değerleri tutabilir 
            //Bellekte 4 byte yer kaplar 

            //8 bit = 1 Byte 
            //1024 byte = 1KB (kilobyte)
            //1024 KB = 1MB (megabyte)
            //1024 MB = 1GB (gigabyte)
            //1024 GB = 1TB (terabyte)
            //1024 TB = 1 PB (petabyte)

            int intNumber = 178999;
            int negatifIntNumber = -5000056;
            int minValue = int.MinValue;
            int maxValue = int.MaxValue;

            Console.WriteLine("Integer example: " + intNumber);
            Console.WriteLine("Negatif Integer: " + negatifIntNumber);
            Console.WriteLine("Integer Min Value: " + minValue);
            Console.WriteLine("Integer Max Value: " + maxValue);
        }
    }
}
