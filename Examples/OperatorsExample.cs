using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class OperatorsExample
    {
        public static void Run()
        {
            //Toplama operatörü: + / Summation: Toplama 
            //Çıkarma operatörü: - / Extraction: Çıkarma 

            int number1 = 10;
            int number2 = 27;
            int sumResult = number1 + number2;

            string name = "Merve ";
            string surname = "Kızılarslan";
            string fullName = name + surname;

            int number3 = 7;
            int exResult = (number1 + number2) - number3;

            //Çarpma Operatörü: * / impact: Çarpma 
            //Bölme Operatörü: / - Divide: Bölme 

            int impResult = number3 * number1;

            int divResult = impResult / number3;

            //Mod alma operatörü: % / X sayısının y sayısına böümünden kalanı verir 

            int modResult = number2 % number3;

            //Arttırma operatörü: ++ /Değeri 1 arttırır
            //Azaltma operatörü: -- /Değeri 1 eksiltir 

            int number4 = 23;
            number4++;

            int number5 = 12;
            number5--;

            //Atama operatörü: = /Verilen değeri değişkene atar - Eşittirin sağındaki değeri soldaki değişkene atar 

            int age = 22;

            //Eşittir operatörü: == /Eşitliği kontrol eder 

            int number6 = 19;
            int number7 = 19;
            int number8 = 21;

            bool control = number6 == number7;
            bool control1 = number6 == number8;

            //Eşit değildir operatörü: != /İki değer birbirine eşit değilse true, eşitse false döner 

            int 

            Console.WriteLine("Toplama operatörü örneği: " + sumResult);
            Console.WriteLine("Toplama operatörü örneği: " + fullName);
            Console.WriteLine("Çıkarma operatörü örneği: " + exResult);
            Console.WriteLine("Çarpma operatörü örneği: " + impResult);
            Console.WriteLine("Bölme operatörü örneği: " + divResult);
            Console.WriteLine("Mod alma operatörü örneği: " + modResult);
            Console.WriteLine("Arttırma operatörü örneği: " + number4);
            Console.WriteLine("Azaltma operatörü örneği: " + number5);
            Console.WriteLine("Atama operatörü örneği: " + age);
            Console.WriteLine("Eşittir operatörü örneği: " + control);
            Console.WriteLine("Eşittir operatörü örneği: " + control1);
        }
    }
}
