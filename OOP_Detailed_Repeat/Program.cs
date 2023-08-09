class Program
{
    static void Main(string[] args)
    {
        #region Sınıf Nedir? Neden Sınıf Yapısı Kullanılır ?

        #endregion
        #region Sınıf ile Nesne Arasındaki İlişki Nedir?

        #endregion
        #region Sınıf Nasıl ve Nerede Oluşturulur?

        #endregion
        #region Namespace İçerisinde

        #endregion
        #region Namespace Dışında

        #endregion
        #region Class İçerisinde(Nested Type)
        //Bir class tanımlamasında tanımlanan yerde(namespace/dışı, class) aynı isimde birden fazla class tanımlanamaz!
        #endregion
        #region Sınıf ile Nesne Modeli Tasarlama

        #endregion
        #region Sınıf Modelinden Referans Noktası Oluşturma
        //Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek için direkt olarak class adını kullanmamız yeterlidir.

        ExampleModel model; //model değişkeni ile ExampleModel classından bir referans alıyoruz.
        #endregion
    }
}

class ExampleModel
{
    int a;
    int b;
    public void x() 
    { 
        Console.WriteLine(a + " " + b);
    }
    public int y() 
    { 
        return a * b;
    }
}

class MyClass
{
    class MyClass2
    {
        //Nested type class
    }
}