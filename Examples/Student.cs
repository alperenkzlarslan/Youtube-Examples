using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class Student
    {
        private int studentNo;
        private string name;
        private string surname;
        private int vise1;
        private int vise2;
        private int final;
        private string schoolName;

        public Student(int student_no, string name_, string surname_, int vise_1, int vise_2, int final_, string school_name)
        {
            studentNo = student_no;
            name = name_;
            surname = surname_;
            vise1 = vise_1;
            vise2 = vise_2;
            final = final_;
            schoolName = school_name;

        }

        public void StudentInfo()
        {
            Console.WriteLine("Öğrenci adı: " + name);
            Console.WriteLine("Öğrenci soyadı: " + surname);
            Console.WriteLine("Öğrenci numarası: " + studentNo);
        }

        public void SchoolInfo()
        {
            Console.WriteLine("Okulun ismi: " + schoolName);
        }

        public double FindAvarage()
        {
            Console.Write("1. vize notunuzu giriniz: ");
            vise1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. vize notunuzu giriniz: ");
            vise2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final notunuzu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());

            int vise1Avarege = (vise1 * 20) / 100;
            int vise2Avarage = (vise2 * 20) / 100;
            int finalAvarage = (final * 60) / 100;

            double totalAvarage = Convert.ToDouble(vise1Avarege + vise2Avarage + finalAvarage);
            
            Console.WriteLine("Öğrencinin not ortalaması: " + totalAvarage);
            return totalAvarage;
        }

        public void Run()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlkemi seçiniz...");
            Console.WriteLine("1- Öğrenci bilgilerini göster");
            Console.WriteLine("2- Öğrenci not ortalamasını göster");
            Console.WriteLine("3- Öğrenci okulunu göster");
            Console.WriteLine("4- Sistemden çıkış yap");

            bool control = true;

            while (control)
            {
                string choose = Console.ReadLine();

                if (choose == "1")
                {
                    StudentInfo();
                }
                else if (choose == "2")
                {
                    FindAvarage();
                }
                else if (choose == "3")
                {
                    SchoolInfo();
                }
                else if (choose == "4")
                {
                    control = false;
                    Console.WriteLine("Sistemden çıkış yapılıyor... İyi günler");
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir tuşlama yapğınız");
                }

            }

            
            
        }

    }
}
