using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class StringExample
    {
        public static void Run()
        {
            //Stringler metinleri tutar ve çift tırnak içinde verilmelidir. 

            string name = "Alperen";
            string surname = "Kızılarslan";
            string welcome = "Hoşgeldin";

            Console.WriteLine(welcome);
            Console.WriteLine(name);
            Console.WriteLine(surname);

            //Formated string example 
            Console.WriteLine($"String Example: {welcome} {name} {surname}");
        }
    }
}
