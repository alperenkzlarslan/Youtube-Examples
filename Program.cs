using System;
using System.Xml.Linq;
using YoutubeExample.Examples;

//OutputExample.Run();

//DataTypeExample.Run();

//ByteExample.Run();

//ShortExample.Run();

//IntegerExample.Run();

//LongExample.Run();

//FloatExample.Run();

//DoubleExample.Run();

//CharExample.Run();

//StringExample.Run();

//BooleanExample.Run();

//ObjectExample.Run();

//OperatorsExample.Run();

//InputExample.Run();

//TypeConvertExample.Run();

//IfElseExample.Run();

//ElseIfExample.Run();

//MiniAtmExample.Run();

//BodyIndexExample.Run();

//SwitchCaseExample.Run();

//ForLoopExample.Run();

//WhileLoopExample.Run();

//DoWhileLoopExample.Run();

//BreakAndContinueExample.Run();   

//MultiplicationTable.Run();

//UserLoginExample.Run();

//ForLoopExampleNew.Run();

//ArrayExample.Run();

//ForEachLoppExample.Run();

//Example.Run();

//MethodExample.SayHi();
//MethodExample.WriteYourName();

//MethodExample.Sum(70, 45);
//MethodExample.Cross(10, 7, 23);
//MethodExample.WriteFullName("Alperen", "Kızılarslan");

//MethodExample.Run();

//MethodExample2.Run();

//MethodExample3.Run();

//MethodExample4.Run();

#region Car sınıfı örneği 1 
//Car car1 = new Car();

//car1.carColor = "Mavi";
//car1.carModel = "BMW";
//car1.doorsNumber = 4;

//car1.LockTheDoor();
//car1.StartEngine();

//Console.WriteLine("Arabanın kapı sayısı: " + car1.doorsNumber);
//Console.WriteLine("Arabanın modeli: " + car1.carModel);
//Console.WriteLine("Arabanın rengi: " + car1.carColor);
#endregion

#region Car sınıfı örneği 2 
//Car car2 = new Car(4, "Opel", "Kırmızı");

//Console.WriteLine("Arabanın kapı sayısı: " + car2.doorsNumber);
//Console.WriteLine("Arabanın rengi: " + car2.carColor);
//Console.WriteLine("Arabanın modeli: " + car2.carModel);
#endregion

#region Erişim belirleyiciler 
//CustomerExample maleCustomer = new CustomerExample();

//maleCustomer.name = "Alperen";
//maleCustomer.surname = "Kızılarslan";
//maleCustomer.salary = 36000;
//maleCustomer.gender = "Erkek";

//maleCustomer.CustomerInfo();
#endregion

#region Öğrenci örneği 
//Student Student1 = new Student(23, "Alperen", "Kızılarlan", 50, 65, 90, "İstanbul Üniversitsi");

//Student1.Run();
#endregion 

#region Encapsulation örneği 
//EncapsulationExample personal = new EncapsulationExample();

//personal.SetName("Alperen");

//string getName = personal.GetName();


//if (getName == "Alperen")
//{
//    Console.WriteLine("İsim doğru");
//}
//else
//{
//    Console.WriteLine("İsim yanlış");
//}
#endregion

#region Property 
//Manager manager1 = new Manager();

//manager1.WEIGHT = 66; //Değer ataması yapıldığı için set blokları çalışır 

//Console.WriteLine(manager1.WEIGHT);
#endregion

#region örnek

//Personel p1 = new Personel();

//p1.IDNO = "12345678910";

//Console.WriteLine("Tc kimlik numaranız: " + p1.IDNO + "******");

#endregion

#region Static Examples

//StaticExample.WriteFullName();

//StaticExample.Sum(10, 23);

//StaticExample worker = new StaticExample();

//worker.name = "Alperen";
//worker.surname = "Kızılarslan";
//worker.personalId = 23;
//StaticExample.salary = 72000;

//Console.WriteLine("Çalışan id: " + worker.personalId);
//Console.WriteLine("Çalışan isim: " + worker.name);
//Console.WriteLine("çalışan soyisim: " + worker.surname);
//Console.WriteLine("Çalışan maaş: " + StaticExample.salary);

#endregion  

#region statiic method 

//User user1 = new User(1, "Alperen", "Kızılarlsan", 2500);

//user1.UserInfo();
//user1.AddMoney(500);

#endregion

#region static class

//static classlardan obje oluşturulamaz 
//static classlardan kalıtım yapılamaz 
//static classların içindekiler de statci olmalı 

#endregion



Console.ReadLine();
