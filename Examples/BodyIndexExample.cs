using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class BodyIndexExample
    {
        public static void Run()
        {
            //Vücut kitle endeksi hesaplama = Kilo / boy * boy 
            //Beden kitle endeksi <= 18 ise zayıf 
            //19 - 25 normal -- 25 ten büyükse obez 

            Console.WriteLine("Vücut kitle endeksi hesaplamaya hoş geldiniz");
            Console.WriteLine("Lütfen kilonuzu giriniz: ");

            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen boyunuzu giriniz: ");

            int height = Convert.ToInt32(Console.ReadLine());

            int bodyIndex = weight / (height * height);

            if (bodyIndex > 25)
            {
                Console.WriteLine("Obez, acielen kilo vermeniz gerekiyor !!!");
            }
            else if (bodyIndex > 18 && bodyIndex <= 25)
            {
                Console.WriteLine("Vücut kitle endexiniz normal");
            }
            else if (bodyIndex <= 18)
            {
                Console.WriteLine("Vücut kitle endexiniz düşük. Zayıfsınız kilo almalısınız !");
            }
        }
    }
}
