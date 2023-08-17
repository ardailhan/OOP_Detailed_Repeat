class Program
{
    static void Main(string[] args)
    {
        D d = new();
        //var x = d.X;  //D classından gelen X fonksiyonu
    }
}
class A
{
    public void X()
    {

    }
}
class B : A
{

}
class C : B
{

}
class D : C
{
    public new void X() //Eskiden name hiding için new keywordü ile kullanmak zorundaydık aksi halde hata alırdık.
    {

    }
}