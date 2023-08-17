class Program
{
    static void Main(string[] args)
    {
        /*new D();*/ // Bir D nesnesi oluşturmak istediğimizde önce A sonra B ondan sonra C en son D nesnesi oluşturacaktır.

        //new MyClass2();
    }
}

class X
{
    int a;
    public int b;
    public int MyProperty { get; set; }
}
class Y : X
{
    int c;
    public void Z()
    {
        //this.a int a private olduğu için base classtan erişilemez.
        this.b = 1;
        MyProperty = 2;
    }
}

class MyClass
{
    public MyClass(int a)
    {
        
    }
    public MyClass(string a)
    {
        
    }
    public MyClass(int a, string b)
    {
        
    }
    public MyClass()
    {
        
    }
}
//Eğer ki base class'ın constructor'ı sadece parametre alan constructor ise derived class'larda o constructor'a bir değer göndermek ZORUNDAYIZ!
//Bunu da base Keyword'ü ile sağlayabiliriz..
//Eğer base class'ta parametre almayan bir ctor var ise derived classlarda base keywordü ile bildirimde bulunmaya gerek yoktur zaten otomatik olarak base classtaki parameteresiz ctor tetiklenecektir !
//Bir classın ctorunun yanında : base(...) keywordunu kullanırsak eger o clas'ın base classının tum ctorlarını bize getirecektır.Haliyle ilgili sınıftan bir nesne üretilirken base classtan nesne üretini esnasında hangi ctorun tetiklenecegini bu sekılde belirleyebiliriz.
class MyClass2 : MyClass
{
    public MyClass2() : base(5, "asdasdasd")
    {                            
                                 
        
    }
    public MyClass2(int a) : base(a)
    {
        
    }
}

class A
{
    public A()
    {
        Console.WriteLine($"{nameof(A)} object created..");
    }
}
class B : A
{
    public B()
    {
        Console.WriteLine($"{nameof(B)} object created..");
    }
}
class C : B
{
    public C()
    {
        Console.WriteLine($"{nameof(C)} object created..");
    }
}
class D : C
{
    public D()
    {
        Console.WriteLine($"{nameof(D)} object created..");
    }
}