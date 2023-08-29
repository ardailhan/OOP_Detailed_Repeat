#region this Keyword'ü
//Bir sınıfın, uygulamanın herhangi bir noktasında üretilmiş olan instance'larını/objectlerini/nesnelerini sınıf içerisinde temsil etmemizi sağlayan bir keyword'dür.

//this keyword'ü bir sınıf içerisinde bulunan birden fazla constructor overload'u arasında zıplamamızı yahut atlamamızı sağlayan bir keyword'dür.
#endregion

#region base Keyword'ü
//Base keyword'ü, bir instance'ın base classını temsil eden sınıf modeli içerisinde temsil eden bir keyword'dur.
//Base keywprd'ü, base class'daki ctorlardan seçim yapmamızı sağlar.
//Eğer kalıtım almamış olan bir class üzerinde kullanırsak tüm sınıfların atası olan object sınıfına yönlendirecektir.
#endregion

#region readonly Keyword'ü
//Bir class içerisinde tanımlanmış olan değişkenin ya da referansın sadece okunabilir olmasını sağlayan bir keyword.
//readonly keywordü ile işaretlenmiş olan referansların değerleri ya tanımlama noktasında ya da ctorda verilebilir.

//const yapılanmalar readonly ile karıstırılabilir aralarında ki fark;
//const tanımlandıgı yerde ilk degeri verilmelidir ve ctor içerisinde bile deger ataması gerceklestırılemez.
//fakat readonly de ister tanımlama noktasında istersenız de ctor içerisinde deger ataması gerceklestırılebilir.İkisi arasındakı temel farklardan biriside budur.
#endregion

//new MyClass(3, "");
new MyClass2();

#region this keyword example
class MyClass
{
    public int MyProperty { get; set; }
    public MyClass()
    {
        Console.WriteLine("Boş constructor");
    }
    public MyClass(int a) : this()
    {
        Console.WriteLine("a parametreli ctor");
    }
    public MyClass(int a, string b) : this(a)
    {
        Console.WriteLine("a ve b parametreli ctor");
    }
}
#endregion

#region base keyword example
class MyClass2 : MyClass
{
    public MyClass2() : base(3, "")
    {
        Console.WriteLine("son ctor");
    }
}
#endregion

#region readonly keyword example
class MyClass3
{
    readonly object x = 5;
    //const string y;
    public MyClass3()
    {
        x = 15;
        //y = "";
    }
    public void X()
    {
        //x = 155;     //Hatalı kullanım
    }
}
#endregion