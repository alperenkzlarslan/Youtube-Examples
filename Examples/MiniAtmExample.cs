using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class MiniAtmExample
    {
        public static void Run()
        {
            //mini atm uygulaması / 1. işlem bakiye görüntüleme - 2. işlem para çekme - 3. işlem para yatırma - 4. işlem çıkış 
            Console.WriteLine("Alperenbank' a hoş geldiniz ");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("1- Bakiye Görüntüleme");
            Console.WriteLine("2- Para Çekme");
            Console.WriteLine("3- Para Yatırma");
            Console.WriteLine("q- çıkış ");

            int userBalance = 2000;
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                Console.WriteLine("Bakiyeniz: " + userBalance);
            }
            else if (choose == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz: ");
                int pulledMoney = Convert.ToInt32(Console.ReadLine());

                if (pulledMoney <= userBalance)
                {
                    Console.WriteLine("Kalan bakiyeniz: " + (userBalance - pulledMoney));
                }
                else
                {
                    Console.WriteLine("Bakiyenizden fazla para çekemezsiniz !");
                }

            }
            else if (choose == "3")
            {
                Console.WriteLine("Yatırmak istediğiniz tutarı giriniz: ");

                int depositMoney = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Güncel bakiyeniz: " + (depositMoney + userBalance));
            }
            else if (choose == "q")
            {
                Console.WriteLine("Atm den çıkış yapılıyor");
                Console.WriteLine("AlperenBank iyi günler diler...");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir tuşlama yapınız2");
            }
        }
    }
}
