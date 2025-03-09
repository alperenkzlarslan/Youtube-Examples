using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class Example
    {
        public static void Run()
        {

            int[] numbers = new int[10];

            int oddTotal = 0;
            int evenTotal = 0;

            int oddPiece = 0;
            int evenPiece = 0;

            int userValue;


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(i + ". index değerini giriniz: ");

                userValue = Convert.ToInt32(Console.ReadLine());

                numbers[i] = userValue; //Dizimin içini kullanıcıdan aldığım değerlerle doldurdum 
            }

            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[j] % 2 == 0)
                {
                    evenPiece++;
                    evenTotal += numbers[j];
                }
                else
                {
                    oddPiece++;
                    oddTotal += numbers[j];
                }

            }
                Console.WriteLine("");

                if (evenTotal > oddTotal)
                {
                    Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür");
                }
                else
                {
                    Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür");
                }
                
                Console.WriteLine("");

                Console.WriteLine("Çift sayıların adedi: " + evenPiece);
                Console.WriteLine("Çift sayıların toplamı: " + evenTotal);

                Console.WriteLine("");

                Console.WriteLine("Tek sayıların adedi: " + oddPiece);
                Console.WriteLine("Tek sayıların toplamı: " + oddTotal);
            





        }
    }
}
