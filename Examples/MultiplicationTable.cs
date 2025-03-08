using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class MultiplicationTable
    {
        public static void Run()
        {
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <=10; j++)
                {
                    if (j % 11 == 1)
                    {
                        Console.WriteLine("");
                    }
                    Console.WriteLine(i + "x" + j + "=" + i*j);
                }
            }
        }
    }
}
