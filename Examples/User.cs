using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeExample.Examples
{
    public class User
    {
        private int userID { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private static int salary { get; set; }


        //Static yapıcı methodlar parametre almazlar 
        //Static yapıcı methodlarda erişimbelirleyici  kullanılmaz 
        //Static yapıcı method 1 defa çalışır 
        //Bir sınıfta 1 tane static yapıcı method olur 
        static User()
        {
            salary = 5600;
        }

        public User(int _userID, string _name, string _surname, int _salary)
        {
            userID = _userID;
            name = _name;
            surname = _surname;
        }

        public void UserInfo()
        {
            Console.WriteLine("Kullanıcı bilgileri");
            Console.WriteLine("ID: " + userID);
            Console.WriteLine("İsim: " + name);
            Console.WriteLine("Soyisim: " + surname);
            Console.WriteLine("Maaş: " + salary);

        }

        public void AddMoney(int moneyAmount)
        {
            Console.WriteLine("Kullanıcıya zam yapılıyor");
            Console.WriteLine("Şu anki maaş: " + (salary + moneyAmount));
        }
    }
}
