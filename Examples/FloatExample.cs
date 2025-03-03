using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class FloatExample
    {
        public static void Run()
        {
            //Float 
            //Ram bellekte 4 byte yer kaplar 

            float floatNumber = 44.23f;
            float floatNumber1 = 788.333f;

            Console.WriteLine("Float value example: " + floatNumber);
            Console.WriteLine("Float value example: " + floatNumber1);
            Console.WriteLine("Float min value: " + float.MinValue);
            Console.WriteLine("Float max value: " + float.MaxValue);
        }
    }
}
