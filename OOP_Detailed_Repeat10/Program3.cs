namespace OOP_Detailed_Repeat10
{
    public class Program3
    {
        static void Main(string[] args)
        {
            new MyClass3(5, 10);
        }
    }

    class MyClass3
    {
        public MyClass3()
        {
            Console.WriteLine("1. Constructor");
        }
        public MyClass3(int a) : this() //this keywordu ile mevcut constructor dısındakı constructorlara erişimi sağlar mevcut constructordan önce bir üstteki constructoru tetikleyip sonrasında bulundugu consu tetikler
        {
            Console.WriteLine($"2. Constructor : a = {a}");
        }
        public MyClass3(int a, int b) : this(a)
        {
            Console.WriteLine($"3. Constructor : a = {a} | b = {b}");
        }
    }

    record MyRecord3 //Classlarda geçerli olan tüm kurallar recordlar içinde geçerlidir
    {
        public MyRecord3()
        {
            
        }
        public MyRecord3(int a) : this()
        {
            
        }
    }
}
