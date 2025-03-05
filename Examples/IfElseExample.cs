using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class IfElseExample
    {
        public static void Run()
        {
            //Kullanıcıdan notunu alıp dersten kalıp kalmadığını öğrenme  

            Console.WriteLine("Ders notunuzu giriniz: ");
            string lessonNote = Console.ReadLine();

            int lessonNoteInt = Convert.ToInt32(lessonNote);

            if (lessonNoteInt > 50)
            {
                Console.WriteLine("Dersten başarılı bir şekilde geçtiniz");
            }
            else
            {
                Console.WriteLine("Daha fazla çalışmanız gerekli, dersten kaldınız!!!");
            }
        }
    }
}
