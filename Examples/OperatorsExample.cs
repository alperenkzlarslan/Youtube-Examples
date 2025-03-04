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

            bool control3 = number6 != number8;
            bool control4 = number6 != number7;

            //Büyüktür operatörü: > 
            //Büyük eşit operatörü: >=

            bool control2 = number6 > number7;
            bool control5 = number6 >= number7;

            //Küçüktür operatörü: <
            //Küçük eşit operatörü: <=

            int number9 = 36;

            bool control6 = number9 < 35;
            bool control7 = number9 <= 36;

            //Mantıksal operatörler 
            //&&: ve operatörü /Ve operatöründe true değerinin dönmesi için bütün koşullar true olmalı 

            int num = 6;
            int num1 = 10;
            int num2 = 10;

            bool doControl = num1 == num2 && num < num1;
            bool doControl1 = num < num1 && num1 != num2;

            //Veya operatörü: || /En az 1 tane koşul true ise true döner 

            bool doControl2 = num > num1 || num1 >= num2;

            //Değil operatörü: ! /Değeri tersine çevirir 

            bool doControl3 = num1 == num2; //True döner 

            //Ek operatörler
            //+= : ekleyip atar, -= : çıkarıp atar, *= : çarpıp atar, /= bölüp atar 

            int num3 = 20;
            num3 += 5;

            int num4 = 15;
            num4 -= 5;

            int num5 = 10;
            num5 *= 5;

            int num6 = 6;
            num6 /= 2;

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
            Console.WriteLine("Eşit değildir operatörü örneği: " + control3);
            Console.WriteLine("Eşit değildir operatörü örneği: " + control4);
            Console.WriteLine("Büyüktür operatörü örneği: " + control2);
            Console.WriteLine("Büyük eşit operatörü örneği: " + control5);
            Console.WriteLine("Küçüktür operatörü örneği: " + control6);
            Console.WriteLine("Küçük eşit operatörü örneği: " + control7);
            Console.WriteLine("Ve operatörü örneği: " + doControl);
            Console.WriteLine("Ve operatörü örneği: " + doControl1);
            Console.WriteLine("Veya operatörü örneği: " + doControl2);
            Console.WriteLine("Değil operatörü örneği: " + !doControl3);
            Console.WriteLine($"+= opertatörü: {num3} ,-= operatörü: {num4}, *= operatörü: {num5}, /= operatörü: {num6}" );

            

        }
    }
}
