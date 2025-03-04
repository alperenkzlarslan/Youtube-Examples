using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class BooleanExample
    {
        public static void Run()
        {
            //True False değerlerini tutar

            bool yes = true;
            bool no = false;
            bool result = 10 > 5;

            Console.WriteLine(yes);
            Console.WriteLine(no);
            Console.WriteLine("Sonuç: " + result);
        }
    }
}
