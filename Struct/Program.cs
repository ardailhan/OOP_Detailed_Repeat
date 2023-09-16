#region Struct Nedir ? Neden Böyle Bir Veri Türü Vardır?
//C#'ta struct, değer türünde bir veri tipi oluşturmak için kullanılan bir veri yapısıdır.
//Classlar ile referans, struct'lar ile de değer türlü veriler oluşturabilmekteyiz.
//Structlar genellikle, class'lara nazaran küçük boyutlu ve hafif veriler oluşturmak için tercih edilseler de, kodlama sürecinde performans ve maliyet optimizasyonları açısından da tercih edilebilmektedir.
//Değer türlü veriler, nesnelere nazaran bellekte daha az yer kapladıkları gibi daha hızlı erişilebilir yapılardır. Bu da performans optimizasyonu açısından fark yaratacaktır.
//Nesnelerin oluşturulması ve kullanıldıktan sonra imha edilmeleri ekstra iş yükü gerektirebilmektedir.Struct'lar da ise bu iş yükü ciddi manada törpülenmiştir diyebiliriz.Bu durumda maliyet optimizasyonu açısından fark yaratmaktadır. 
#endregion

#region Struct Ne Amaca Hizmet Eder ?
//Struct'lar temelde, yazılım sürecinde int gibi, char gibi, bool gibi kendimize ait değer türlü değişkenler oluşturmak için kullandığımız veri türleridir.
//Özellikle bellek performansının kritik arz ettiği uygulamalarda, uygun noktalarda class'lar yerine struct'ları tercih edebilirsiniz.
//Misal olarak; matematiksel veriler gibi basit değerleri temsil etmek için class'lar yerine struct'ları tercih etmeniz daha doğru olacaktır.
//Ya da koordinat sistemindeki noktaları veya key/value çiftleri tarzındaki kimi değerleri struct olarak tanımlamak performans açısından daha elverişli olacaktır.
//Kısaca kodlama sürecindeki birden fazla değerlerin/verilerin atomik bir temsili için struct'ları kullanırız!
#endregion

#region Struct Veri Türü Bellekte Nerede Saklanır ?
//Struct'lar, value type yani değer türlü veri yapıları olduğu için belleğin Stack kısmında tutulurlar.
//Aşağıdaki örnekte new operatörü ile kullanılan veri yapısı struct olduğu için belleğin Stack kısmında tutulacaktır.Dolayısıyla buradaki myStruct değişkenine class'lar da olduğı gibi referans değil DEĞİŞKEN diyeceğiz!Ve bu değişken belleğin Stack kısmındaki tutulan X ve Y alanlarına erişmemizi sağlayan değer türlü bir değişkendir.

//MyStruct myStruct = new()
//{
//    X = 123,
//    Y = 321,
//};

//struct MyStruct
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//}
#endregion


//int a = 5;
//int b = a;


//MyStruct m1 = new()
//{
//    X = 1,
//    Y = 2,
//};
//MyStruct m2 = new()
//{
//    X = 1,
//    Y = 2,
//};

//if (m1.Equals(m2))
//{
//    Console.WriteLine("Eşit");
//}

//struct MyStruct
//{
//    public int X { get; set; }
//    public int Y { get; set; }
//}


ExampleStruct e = new();
e.y = 123;
e.x = 321;

Console.WriteLine(e.y);
Console.WriteLine(e.x);

e.NewStruct();

Console.WriteLine(e.y);
Console.WriteLine(e.x);

struct ExampleStruct
{
    public int x;
    public int y;
    public bool z;

    public void X()
    {
        if(z)
            Console.WriteLine(x + y);
    }

    public int MyProperty { get; set; }
    public void NewStruct()
    {
        this = new ExampleStruct();
    }
}