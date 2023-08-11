class Program
{
    static void Main(string[] args)
    {
        //MyClass m1 = new MyClass()
        //{
        //    XXX = 5
        //};
        //MyClass m2 = new MyClass()
        //{
        //    XXX = 5
        //};

        //Console.WriteLine(m1.Equals(m2));

        //MyRecord m3 = new MyRecord()
        //{
        //    XXX = 5
        //};
        //MyRecord m4 = new MyRecord() 
        //{
        //    XXX = 5 
        //};
        //Console.WriteLine(m3.Equals(m4));

        //MyClass m = new MyClass()
        //{
        //    XXX = 5,
        //    XXX2 = 10
        //};
        //m.XXX2 = 15;
        //MyClass m2 = m.With(15);

        MyRecord m = new MyRecord()
        {
            XXX = 5,
            XXX2 = 10
        };
        MyRecord m2 = m with { XXX2 = 15 };   //With Expression
    }
}

record MyRecord
{
    public int XXX { get; init; }
    public int XXX2 { get; init; }
}
class MyClass
{
    public int XXX { get; init; }
    public int XXX2 { get; init; }
    public MyClass With(int xxx2)
    {
        return new MyClass
        {
            XXX = this.XXX,
            XXX2 = xxx2
        };
    }
}