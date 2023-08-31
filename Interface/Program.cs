IA m = new Example(); //Interface referansı ile instance alınabilir
IB n = new Example();
IC v = new Example();

//m.A();
//n.B();
//v.C();


//Abstract class ve interface imza farkı.Interfacelerde access modifiers kullanılmaz.
interface IMyInterface
{
    void X();
    void Y(int a);
    int Z { get; set; }
}
abstract class MyAbstractClass
{
    public abstract void X();
    public abstract void Y(int a);
    public abstract int Z { get; set; }

    public bool D()
    {
        return true;
    }
}

//Implement etmek durumundayız !!! Aksi takdirde uygulama derlenmeyecektir.
class MyClass : IMyInterface
{
    public int Z { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void X()
    {
        throw new NotImplementedException();
    }

    public void Y(int a)
    {
        throw new NotImplementedException();
    }
}

//Interfacelerde çoklu kalıtım durumu örneği
class Example : IA, IB, IC
{
    public void A()
    {
        throw new NotImplementedException();
    }

    public void B()
    {
        throw new NotImplementedException();
    }

    public void C()
    {
        throw new NotImplementedException();
    }
}
interface IA
{
    void A();
}
interface IB
{
    void B();
}
interface IC
{
    void C();
}

//Interface'in interface'den türemesi

interface IQ
{
    void Q();
}
interface IW : IQ
{
    void W();
}
interface IE : IW, IR, IT
{
    void E();
}
interface IR
{
    void R();
}
interface IT
{
    void T();
}
class Example2 : IE
{
    public void E()
    {
        throw new NotImplementedException();
    }

    public void Q()
    {
        throw new NotImplementedException();
    }

    public void R()
    {
        throw new NotImplementedException();
    }

    public void T()
    {
        throw new NotImplementedException();
    }

    public void W()
    {
        throw new NotImplementedException();
    }
}

//Interfaceleri kendi aralarında birbirlerinden türetebilmekteyiz.
//Eğer ki bu şekilde interface'in interface'e kalıtım vermesi söz konusuysa burada : operatörü implementation değil inheritance görevi görecektir ve bu interface'leri birbirlerinden türetecektir.
//Haliyle kalıtımın tüm kuralları bu noktada geçerli olacaktır ve hiyerarşik olarak interface'lerin member'ları torunlarına aktarılacaktır.
//Ayrıca polimorfizm kuralları geçerli olacak ve misal olarak IE interface'inin implemente edileceği class, tüm üst referanslar tarafından da işaretlenebilir olacaktır.


//Bir class hem bir class'tan kalıtım alıp hemde aynı anda bir ya da daha fazla interface'i implemente etmesi durumu.

class OrnekSınıfı
{
    public void Ornek()
    {

    }
}
class ExampleClass : OrnekSınıfı, IU, IY, IP
{
    public void P()
    {
        throw new NotImplementedException();
    }

    public void U()
    {
        throw new NotImplementedException();
    }

    public void Y()
    {
        throw new NotImplementedException();
    }
}

interface IU
{
    void U();
}
interface IY
{
    void Y();
}
interface IP
{
    void P();
}