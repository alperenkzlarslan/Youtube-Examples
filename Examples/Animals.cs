using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class Animals
    {
        public string animalName;
        public string animalGender;
        public string animalColor;
        private int animalAge;


        public void AnimalInfo()
        {
            Console.WriteLine("Hayvanın ismi: " + animalName);
            Console.WriteLine("Hayvanın cinsiyeti: " + animalGender);
            Console.WriteLine("Hayvanın rengi: " + animalColor);
        }
    }
}
