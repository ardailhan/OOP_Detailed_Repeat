using m1 = MyNamespace1;
using m2 = MyNamespace2;

using static MyNamespace1.MyClass;

X();   //using static MyNamespace1. namespaceinde statik bir metoda namespacei bildirmek zorunda kalmaksızın ulasıyoruz.

//using MyNamespace; //alttaki referansların basındaki namespace kullanımını zorunlu olmayan hale getiriyoruz.

//namespace X; // File scoped namespace

//class MyClass
//{

//}
//interface IInterface
//{

//}

////namespace MyNamespace
////{
//    //nested namespace kullanılamaz !!
////}
///

m1.MyClass m1 = new();     //Yukarıda using MyNamespace; komutuyla bu ornekteki referans adında namespace belirtmek zorunda kalmayız.
m2.MyClass m2 = new();


namespace MyNamespace1
{
	class MyClass
	{
		public static void X() { }
	}
}
namespace MyNamespace2
{
	class MyClass
	{

	}
}