C c = new();
c.X();
class A
{
    public virtual void X() { Console.WriteLine("Merhaba A"); }
}
class B : A
{
    sealed public override void X()
    {
        Console.WriteLine("Merhaba B");
    }
}
class C : B
{
    
}