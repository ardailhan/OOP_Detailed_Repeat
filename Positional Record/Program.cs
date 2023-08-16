class Program
{
    static void Main(string[] args)
    {
        MyRecord m = new MyRecord();
        var(n,s) = m;
    }
}

record MyRecord(string Name, string Surname) //Positional Record
{
    public MyRecord() : this("asdasd", "dsadsa")
    {
        
    }
    public MyRecord(string Name) : this()
    {
        
    }
    //public string Name => name;
    //public string Surname => surname;
}



//Eğer record parametre almışsa bu semantik positional record özelliğidir.
//Bir record üzerinden ctor ve dector yapılanmasını hızlı bir şekilde olusturmamizi saglayan bir semantik saglamaktadır.
//Positional Record kullanırken parametrelerin karsılıkları olan propertyleri manuel olusturmak zorunda değiliz.
//Parametrelerin karsılıgı olarak compiler seviyesinde propertyler otomatik olusturulacaktır.
//Bu propertyler olusuturulurken init olacak sekılde olusturulur.
//Positional record tanımlanmıssa eger nesne uretımınde tetkıklenmesı/kullanılması zorunludur!