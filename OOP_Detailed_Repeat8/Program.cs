class Program
{
    static void Main(string[] args)
    {
        MyClass m = new MyClass();
        m.ASet(15);
        Console.WriteLine(m.AGet());

        m.A = 123321;
        Console.WriteLine(m.A);
    }
}

class MyClass
{
    int a;
    #region Eski Tip Encapsulation
    public int AGet()
    {

        return a;
    }
    public void ASet(int value)
    {
        a = value;
    }
    #endregion
    #region Full Property ile Encapsulation
    public int A
    {
        get { return a; }
        set { a = value; }
    }

    #endregion
}