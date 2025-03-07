using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class SwitchCaseExample
    {
        public static void Run()
        {
            //mini atm uygulaması / 1. işlem bakiye görüntüleme - 2. işlem para çekme - 3. işlem para yatırma - 4. işlem çıkış 

            int balance = 1000;

            Console.WriteLine("Atm ye hoş geldiniz...");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1- Para çekme");
            Console.WriteLine("2- Para yatırma");
            Console.WriteLine("3- Bakiye görüntüleme");
            Console.WriteLine("4- Çıkış");

            string choose = Console.ReadLine();

            switch (choose)
            {
                case "1":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz:  ");
                    int pulledBalance = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Kalan bakiyeniz: " + (balance - pulledBalance));
                    break;
                
                case "2":
                    Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz");
                    int loadBalance = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Güncel bakiyeniz: " + (balance + loadBalance)
                        );
                    break;
                
                case "3":
                    Console.WriteLine("Bakiyeniz: " + balance);
                    break;

                case "4":
                    Console.WriteLine("Hesabınızdan çıkış yapıldı. İyi günler");
                    break;

                default:
                    Console.WriteLine("Lütfen geçerli bir değer giriniz");
                    break;
            }       
        }
    }
}
