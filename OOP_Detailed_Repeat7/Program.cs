class Program
{
    static void Main(string[] args)
    {
        #region Shallow 
        #region Example1
        //MyClass m1 = new MyClass();
        //MyClass m2 = m1;
        //MyClass m3 = m2;
        //MyClass m4 = new MyClass();
        #endregion
        #region Example2
        //MyClass m1 = null;
        //MyClass m2 = new MyClass();
        //MyClass m3 = m2;
        //m1 = m3;
        #endregion
        #region Example3
        //MyClass m1 = new MyClass();
        //MyClass m2 = new MyClass();
        //MyClass m3 = m1;
        //m1 = m2;
        //m2 = m1;
        //m1 = m1;
        #endregion
        #endregion
        #region Deep Copy
        MyClass m1 = new MyClass();
        MyClass m2 = m1; //Shallow Copy
        MyClass m3 = m1.Clone(); //Deep Copy
        #endregion
    }
}

class MyClass
{
    public MyClass Clone()
    {
        return (MyClass)this.MemberwiseClone();
    }
}