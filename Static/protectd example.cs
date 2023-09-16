namespace Static
{
    class protectd_example
    {
        MyClass1 m = new();
        Console.WriteLine(MyClass2.MyProperty);


        class MyClass1 : MyClass2
        {
            public MyClass1()
            {
                MyProperty = 123123;
            }
        }

        class MyClass2
        {
            public static int MyProperty { get; set; }
        }
    }
}
