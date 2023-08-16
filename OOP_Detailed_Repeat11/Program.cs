class Program
{
    static void Main(string[] args)
    {
        #region 1. Ornek
        //X();
        //GC.Collect(); //Garbage collector activated manually(not recommended)
        #endregion
        #region 2. Ornek
        int sayi = 100;
        while (sayi >= 1)
        {
            new MyClass2(sayi--);
        }
        Console.WriteLine("*****************************************");
        GC.Collect();

        Console.ReadLine();
        #endregion
    }

    static void X()
    {
        MyClass m = new MyClass();
    }
}

class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Object Created");
    }

    ~MyClass() //Destructor
    {
        Console.WriteLine("Object Destructed");
    }
}
class MyClass2
{
    int no;
    public MyClass2(int no)
    {
        this.no = no;
        Console.WriteLine($"{no}. object created..");
    }
    ~MyClass2()
    {
        Console.WriteLine($"{no}. oobject destructed");
    }
}