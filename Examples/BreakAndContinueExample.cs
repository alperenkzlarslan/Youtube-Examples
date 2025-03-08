using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class BreakAndContinueExample
    {
        public static void Run()
        {
            //Break and Continue anahtar kelimeleri kullanımı 

            for (int i = 1; i <= 10; i++)
            {
                if (i == 7)
                {
                    break; //Döngüyü tamamen kırar 
                }
                Console.WriteLine("İ' nin değeri: " + i);
            }


            for (int a = 1; a <= 10; a++)
            {
                if (a == 7)
                {
                    continue; //Bir defalığına döngüyü kırar 
                }
                Console.WriteLine("İ' nin değeri: " + a);
            }
        } 
    }
}
