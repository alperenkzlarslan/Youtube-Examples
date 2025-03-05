using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class InputExample
    {
        public static void Run()
        {
            Console.WriteLine("Lütfen adınızı giriniz: ");
            string name = Console.ReadLine();

            Console.WriteLine("Lütfen soyadınızı giriniz: ");
            string surname = Console.ReadLine();

            Console.WriteLine($"Kullanıcının adı: {name}");
            Console.WriteLine($"Kullanıcının soyadı: {surname}");
        }
    }
}
