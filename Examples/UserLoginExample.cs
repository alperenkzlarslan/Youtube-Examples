using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class UserLoginExample
    {
        public static void Run()
        {
            //Kullanıcı giriş sayfası uygulkaması - Kullanıcı adı ve şifre değerleri istenicek doğruysa girebilicek 
            //Yanlış ise 3 kez deneme hakkı olucak 

            int dueNumber = 3;

            while (true)
            {
                Console.WriteLine("Lütfen kullanıcı adınızı giriniz: ");
                string userName = Console.ReadLine();

                Console.WriteLine("Lütfen şifrenizi giriniz: ");
                    string password = Console.ReadLine();

                if (userName == "alperen" && password == "2344")
                {
                    Console.WriteLine("Kullanıcı adı ve şifreniz doğru. Hoş geldiniz :)");
                    break;
                }

                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifreniz yanlış. Lütfen tekrar deneyiniz");
                    Console.WriteLine("Kalan giriş hakkı: " + (dueNumber - 1));

                    if (dueNumber > 0)
                    {
                        dueNumber -= 1;
                    }
                    
                    if (dueNumber == 0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur. Daha sonra tekrar deneyiniz");
                        break;
                    }
                }

            }
        }
    }
}
