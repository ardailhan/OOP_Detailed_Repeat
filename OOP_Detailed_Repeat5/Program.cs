class Program
{
    static void Main(string[] args)
    {
        new MyClass();

        new Random();

        new MyClass();
        new MyClass();
        new MyClass();
        new MyClass();


        MyClass myClass = new(); //Target-typed New Expression
    }
}

class MyClass
{
    public int A { get; set; }
    public void X()
    {

    }
}