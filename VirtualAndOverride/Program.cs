class Program
{
    static void Main(string[] args)
    {
        Terlik t = new();
        t.Bilgi();

        Kalem k = new();
        k.Bilgi();
    }
}

class Obje
{
    virtual public void Bilgi()
    {
        Console.WriteLine("ben bir objeyim");
    }
}

class Terlik : Obje
{
    public override void Bilgi()
    {
        Console.WriteLine("ben bir terliğim...");
    }
}

class Kalem : Obje
{
    public override void Bilgi()
    {
        Console.WriteLine("ben bir kalemim...");
    }
}