class Program
{
    static void Main(string[] args)
    {
        #region Class İçerisinde Tanımlanan Class Sınıf Elemanı Mıdır ?
        //MyClass m1 = new MyClass();

        //MyClass.MyClass2 m2 = new MyClass.MyClass2();
        #endregion
        #region Class Elemanlarına Açıklama Satırı Nasıl Eklenir ?
        Random random = new Random();
        
        MyClass myClass = new MyClass();
        myClass.X();
        #endregion
    }
}

/// <summary>
/// Example Class
/// </summary>
class MyClass
{
    int a;
    /// <summary>
    /// This is a property
    /// </summary>
    public int MyProperty { get; set; }
    /// <summary>
    /// This is an example method
    /// </summary>
    public void X() { }
    /// <summary>
    /// This is an example method with an overload
    /// </summary>
    /// <param name="a parameter"></param>
    public void X(int a) { }
    public int this[int a]
    {
        get { return 0; }
    }

    public class MyClass2
    {

    }
}