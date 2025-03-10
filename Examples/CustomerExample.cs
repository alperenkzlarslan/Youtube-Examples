using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class CustomerExample
    {

        public CustomerExample()
        {
            Console.WriteLine("Müşteri sınıfının yapıcı methodu çalıştı...");
        }

        public string name;
        public string surname;
        public string gender;
        public int salary;

        private int age;

        public void CustomerInfo()
        {
            Console.WriteLine("İsmi:" + name);
            Console.WriteLine("Soyismi: " + surname);
            Console.WriteLine("Maaşı: " + salary);
            Console.WriteLine("Cinsiyeti: " + gender);
            Console.WriteLine("Yaş: " + age);
        }

        private void WriteFullname(string name, string surname)
        {
            Console.WriteLine("Müşterinin adı ve soyadı: " + name + " " + surname);

        }
    }
}
