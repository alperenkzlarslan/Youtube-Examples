using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class Car
    {
        public int doorsNumber;
        public string carModel;
        public string carColor;

        //ctor - yapıcı method tanımlamanın kısaltması 
        public Car(int doors_number, string car_model, string car_color)
        {
            Console.WriteLine("Araba sınıfının yapıcı methodu çalıştı...");

            doorsNumber = doors_number;
            carModel = car_model;
            carColor = car_color;
        }


        public void LockTheDoor()
        {
            Console.WriteLine("Kapılar kilitlendi");
        }

        public void StartEngine()
        {
            Console.WriteLine("Motor çalıştırılıyor...");
        }

        

    }
}
