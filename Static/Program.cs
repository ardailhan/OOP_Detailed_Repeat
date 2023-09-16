//Statik Yapılar

//Non-static yapılara erişim
////MyClass m = new();

//Static yapılara erişim.
//MyClass.StaticMethod();


//Bir sınıf static keyword'ü ile işaretleniyorsa içerisindeki tüm memberlar static olmak zorundadır !
//Static sınıflarda Constructor kullanımı da yoktur.
//Static metotlar overload edilebilir fakat override edilemez! virtual ile işaretlenemez!
//static class MyClass
//{
//    //public int nonStaticField;
//    public static int staticField;

//    //public void NonStaticMethod() { }
//    static public void StaticMethod()
//    {
//        //Sadece static olan memberlara erişelebilir.
//    }

//    //public int NonStaticProp { get; set; }
//    public static int StaticProp { get; set; }

//    public const int constant = 0; //Zaten static memoryde oluşur o sebeple static keywordu alamaz.
//}



//C# programlama dilinde 'Protected' ile işaretlenmiş herhangi bir member'a, sade ve sadece o member'ın tanımlandığı class'tan türetilmiş olan alt sınıflardan erişim gösterilebilmektedir. Dolayısıyla 'PROTECTED' kalıtımsal ilişki gerektiren bir access modifier'dır!


using System.Runtime.CompilerServices;

class MyClass1 : MyClass2
{
    public MyClass1()
    {
        MyProperty = 123123;
    }
}

class MyClass2
{
    protected static int MyProperty { get; set; }
}