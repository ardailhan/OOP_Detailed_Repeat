class Program
{
    static void Main(string[] args)
    {
        //MyClass m = new MyClass();
        //m.MyProperty = 10;

        //MyClass m2 = null;  //Null olan yani nesnesi olmayan referanslar üzerinden herhangi bir memberı çağırıp işlemeye çalıştığımızde null reference hatası verecektir.
        //m2.MyProperty = 20;

        new MyClass().MyProperty = 10; // Eğer ki bir nesne referanssızsa bunu yinede oluşturabiliriz fakat bu nesne sistemde/memory'de luzumsuz yer kaplayacağından dolayı bir süre sonra Garbage Collector dediğimiz çöp toplayıcı tarafından temizlenecektir.
        //Garbage Collector; heap'de referanssız olan nesneleri imha etmekten/temizlemekten sorumlu bir yapılanmadır.


        MyClass m = new MyClass()
        {
            MyProperty = 10,            //Object Initializer ile içindeki propertylerin ilk değerleri verildiğinden dolayı vermiş olduğumuz değerlerle oluşturulacaktır.Yani default değerleri haline gelecektir.
            MyProperty2 = 30,
            MyProperty3 = 40
        };

        MyClass m2 = new MyClass();     //Burda ise default değerlerin üstüne atamış oluyoruz.
        m2.MyProperty = 10;
    }
}

class MyClass
{
    public int MyProperty { get; set; }
    public int MyProperty2 { get; set; }
    public int MyProperty3 { get; set; }
}