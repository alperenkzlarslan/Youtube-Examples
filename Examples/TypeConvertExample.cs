using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class TypeConvertExample
    {
        public static void Run()
        {
            //İnteger dan byte veri tipine dönüşüm 
            int intNum = 5;

            byte bytNum = (byte)intNum;

            Console.WriteLine("Değişkenin türü: " + bytNum.GetType());
            Console.WriteLine("Değişkenin değeri: " + bytNum);

            //String veri tipinden integera dönüşüm 
            string number1 = "1";
            string number2 = "2";

            //int x = int.Parse(number1);
            //int y = int.Parse(number2);
            
            //Console.WriteLine("toplam: " + (x + y));

            int x = Convert.ToInt32(number1);
            int y = Convert.ToInt32(number2);

            Console.WriteLine(x + y);

            //İntegerdan string veri tipine dönüşüm 
            int num1 = 10;
            int num2 = 5;

            //string a = num1.ToString();
            //string b = num2.ToString();

            string a = Convert.ToString(num1);
            string b = Convert.ToString(num2);

            Console.WriteLine(a + b);

            //Double veri tipinden integera dönüştürme 
            double dNum = 7.10;

            int c = Convert.ToInt32(dNum);

            Console.WriteLine(c);

            //Kullanıcıdan alınan değerler string veri tipinde olur!!!

            Console.WriteLine("Toplama işlemine hoşgeldiniz !");
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");

            string userNum1 = Console.ReadLine();

            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            string userNum2 = Console.ReadLine();

            int userNumInt1 = Convert.ToInt32(userNum1);
            int userNumInt2 = Convert.ToInt32(userNum2);

            Console.WriteLine("Sayıların toplamı: " + (userNumInt1 + userNumInt2));

        }
    }
}
