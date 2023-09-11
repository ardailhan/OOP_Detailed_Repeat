//Explicity Implement & Name Hiding

MyClass m = new();
IA a = m;
a.X();

IB b = m;
b.X();

class MyClass : IA, IB
{
    int IA.X()
    {
        Console.WriteLine("A - X");
        return 0;
    }

    int IB.X()
    {
        Console.WriteLine("B - X");
        return 1;
    }
}
interface IA
{
    int X();
}
interface IB
{
    int X();
}

//Default Implementation

class XClass : IZX
{
    public void X()
    {
        Console.WriteLine("X");
    }
    public void Y()
    {
        Console.WriteLine("Y"); //Default implementation ezmiş oluyoruz.
    }

}

interface IZX
{
    void X();
    void Y()
    {
        Console.WriteLine("Default Imp. Y"); //Default Implementation
    }
}