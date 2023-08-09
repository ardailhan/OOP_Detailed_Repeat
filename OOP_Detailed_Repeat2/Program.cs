class Program
{
    static void Main(string[] args)
    {
        #region Field
        //Nesne içerisinde değer tutmamızı sağlayan alanlardır.

        MyClass m1 = new MyClass(); //Nesne oluşturma :)
        //m1.a = 5;
        //Console.Write(m1.a); //Default olarak '0' değeri alır.
        MyClass m2 = new MyClass();
        //m2.a = 25;
        #endregion
        #region Property
        //MyClass myClass = new MyClass();
        //Console.WriteLine(myClass.Yasi);
        //myClass.Yasi = 50;
        //Console.WriteLine(myClass.Yasi);

        //myClass.Yasi = 12;
        //Console.WriteLine(myClass.Yasi);
        #endregion
        #region Method
        //MyClass myClass = new MyClass();
        //myClass.X();
        #endregion
        #region Indexer
        MyClass myClass = new MyClass();
        myClass[5] = 10;
        #endregion
    }
}

class MyClass
{
    //int yasi;  //a Fieldını oluşturduk.Class içerisinde tanımlandığı için bir field olur.
    //string b;

    #region Full Property
    //Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır.
    //Propertyler temsil ettikleri fiel'ların isimlerinin baş harfi büyük olacak şekilde isimlendirilir.
    //public int Yasi 
    //{
    //    get 
    //    {
    //        //Property üzerinden değer talep edildiğinde bu blok tetiklenir.
    //        //Yani değer buradan gönderilir.

    //        return yasi;
    //    }
    //    set 
    //    {
    //        yasi = value; //Set bloğunu kapatırsak sadece readonly olacaktır.
    //    } 

    //}
    #endregion
    #region Prop Property
    public int Yasi { get; set; } = 32;
    #endregion
    #region Ref Readonly Returns
    string adi = "Arda İlhan";
    public ref readonly string Adi => ref adi;
    #endregion
    #region Computed Properties
    int s1 = 5;
    int s2 = 10;
    public int Sum
    {
        get
        {
            return s1 + s2;
        }
    }
    #endregion
    #region Method
    public int X()
    {
        return 0;
    }
    #endregion
    #region Indexer
    public int this[int a]
    {
        get
        {
            return a;
        }
        set
        {

        }
    }
    #endregion
}

class Bank
{
    int balance;
    public int Bakiye
    {
        get
        {
            if (balance > 0)
                return balance * 10 / 100;
            return 5;
        }
        set 
        { 
            if (value < 10)
                balance = value;
            else
                balance = value * 95 / 100;
        }
    }
}