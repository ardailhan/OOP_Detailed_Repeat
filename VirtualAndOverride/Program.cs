class Program
{
    static void Main(string[] args)
    {
        #region Ornek-Ek
        //Terlik t = new();
        //t.Bilgi();

        //Kalem k = new();
        //k.Bilgi(); 
        #endregion
        #region Ornek 1
        //Maymun m = new();
        //m.Konus();
        //Inek ı = new();
        //ı.Konus();
        #endregion
        #region Ornek 2
        Ucgen u = new(3,4);
        Console.WriteLine(u.AlanHesapla());
        Dortgen d = new(3,4);
        Console.WriteLine(d.AlanHesapla());
        Dikdortgen dik = new(3,4);
        Console.WriteLine(dik.AlanHesapla());
        #endregion
    }
}
#region Ornek-Ek
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
#endregion
#region Ornek 1
class Memeli
{
    public virtual void Konus()
    {
        Console.WriteLine("Ben konusmuyorum..");
    }
}
class Maymun : Memeli
{
    public override void Konus()
    {
        Console.WriteLine("Ben maymunum..");
    }
}
class Inek : Memeli
{
    public override void Konus()
    {
        Console.WriteLine("Ben ineğim..");
    }
}
#endregion
#region Ornek 2
class Sekil
{
    protected int _boy;
    protected int _en;
    public Sekil(int boy, int en)
    {
        _boy = boy;
        _en = en;
    }
    public virtual int AlanHesapla()
    {
        return 0;
    }
}
class Ucgen : Sekil
{
    public Ucgen(int boy, int en) : base(boy, en)
    {
        
    }
    public override int AlanHesapla()
    {
        return _boy * _en / 2;
    }
}
class Dortgen : Sekil
{
    public Dortgen(int boy, int en) : base(boy, en)
    {

    }
    public override int AlanHesapla()
    {
        return _boy * _en;
    }
}
class Dikdortgen : Sekil
{
    public Dikdortgen(int boy, int en) : base(boy, en)
    {

    }
    public override int AlanHesapla()
    {
        return _boy * _en;
    }
}
#endregion
