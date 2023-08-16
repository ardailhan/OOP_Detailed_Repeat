class Program
{
    static void Main(string[] args)
    {
        new MyClass();  //Önce static ctor sonra ctor tetiklenir!!
        new MyClass(); //Sadece ctor tetiklenir!!!

        var database1 = Dataabase.GetInstance;
        var database2 = Dataabase.GetInstance;
        var database3 = Dataabase.GetInstance;

        database1.ConnectionString = "asdasdasdasdasd";
    }
}

class MyClass
{
    public MyClass()
    {
        //Bu sınıftan nesne üretilirken tetiklenecek olan metottur.
        Console.WriteLine("MyClass ctor'u tetiklenmiştir.");
    }

    static MyClass()
    {
        //Sadece 'ilk' nesne üretildiğinde tetiklenir daha sonra constructor tetiklenecektir.Üretilen ilk nesnenin dışında birdaha tetiklenmez!!
        //Static ctor'da geri dönüş değeri ve erişim belirleyicisi bildirilmez.
        //Overloading yapılmaz! bir sınıfın içerisinde sade ve sadece bir tane tanımlanabilir.
        //Parametre almaz
        //İsmi sınıf ismiyle aynı isimde olmalıdır.
        Console.WriteLine("MyClass static ctor'u tetiklenmiştir.");
        //Static ctor tetiklenebilmesi için illa ilk nesne üretimi yapılmasına gerek yoktur.İlgili sınıf içerisinde herhangi bir static yapılanmanında tetiklenmesi static ctor tetiklenmesini sağlayacaktır.
    }
}

#region Singleton Design Pattern
//Bir sınıftan uygulama bazında sade ve sadece tek bir nesne oluşturulmasını istiyorsan kullanabileceğin bir design pattern.
class Dataabase
{
    Dataabase()
    {

    }
    public string ConnectionString { get; set; }

    static Dataabase dataabase;
    static public Dataabase GetInstance
    {
        get
        {
            return dataabase;
        }
    }

    static Dataabase()
    {
        dataabase = new Dataabase();
    }
}
#endregion