using System;
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
Car car2 = new Car(4, "Opel", "Kırmızı");

Console.WriteLine("Arabanın kapı sayısı: " + car2.doorsNumber);
Console.WriteLine("Arabanın rengi: " + car2.carColor);
Console.WriteLine("Arabanın modeli: " + car2.carModel);
#endregion



Console.ReadLine();
