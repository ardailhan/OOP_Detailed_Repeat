class Program
{
    static void Main(string[] args)
    {
        #region this Keyword

        #region 1. Sınıfın Nesnesini Temsil Eder
        //MyClass m1 = new MyClass();
        //MyClass m2 = new MyClass();


        #endregion
        #region 2. Aynı İsimde Field ve Metot Parametrelerini Ayırmak İçin Kullanılır
        //this keywordü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
        //this kullanmak zorunda değiliz.
        #endregion
        #region 3. Bir Constructor'dan Başka Bir Constructor'ı Çağırmak İçin Kullanılır

        #endregion

        #endregion

    }
}

class MyClass
{
    int a;
    public void X()
    {

    }
}