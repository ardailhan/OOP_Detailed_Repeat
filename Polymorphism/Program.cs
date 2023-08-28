class Program
{
    static void Main(string[] args)
    {
        C c = new C();
        var val = c.X;
        var val2 = c.Y;
        var val3 = c.Z;

        B b = new C();
        var value = b.X;
        var value2 = b.Y;

        A a = new C();
        var v = a.X;
    }
}
class A
{
    public void X() { }
}
class B : A
{
    public void Y() { }
}
class C : B
{
    public void Z() { }
}