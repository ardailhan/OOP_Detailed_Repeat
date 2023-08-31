Z z = new();
//z.
abstract class X
{
    public void A() { }
    public void B() { }
    public void C() { }
    public abstract void D();
    abstract public void V();
}

abstract class Y : X
{
    public void E() { }
    abstract public void F();
}

class Z : Y
{
    public override void D()
    {
        throw new NotImplementedException();
    }

    public override void F()
    {
        throw new NotImplementedException();
    }

    public override void V()
    {
        throw new NotImplementedException();
    }
}



//A a = new _A();

abstract class A
{
    public A()
    {
        Console.WriteLine("A Abstract Class");
    }
}
class _A : A
{
    public _A()
    {
        Console.WriteLine("_A Class");
    }
}

abstract class MyAbstractClass
{
    int a;
    public void X()
    {

    }
    public int MyProperty { get; set; }

    abstract public void Z();
    abstract public void W(string a, int b);
    abstract public int Y { get; set; }
    abstract public bool H();
}

//Abstract Class içerisindeki abstract yapıların concrete class içerisindeki tanımları public olmak zorundadır !!!
class MyClass : MyAbstractClass   //Must be implemented !!!
{
    public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override bool H()
    {
        throw new NotImplementedException();
    }

    public override void W(string a, int b)
    {
        throw new NotImplementedException();
    }

    public override void Z()
    {
        throw new NotImplementedException();
    }
}