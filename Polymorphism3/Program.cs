using Polymorphism3;

class Program
{
    static void Main(string[] args)
    {
        Arac a = new Arac();
        a.Calistir();

        Arac t = new Taksi();
        t.Calistir();

        Taksi t2 = new Taksi();
        t2.Calistir();
    }
}