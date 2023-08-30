#region partial class
//namespace X;
//partial class MyClass
//{
//    partial class MyClass2
//    {

//    }
//    public void A()
//    {

//    }
//}
//partial class MyClass
//{
//    partial class MyClass2
//    {

//    }
//    public void B()
//    {

//    }
//}
//partial class MyClass
//{
//    partial class MyClass2
//    {

//    }
//    public void C() 
//    { 

//    }
//}
#endregion
#region partial record
//partial record X
//{

//}
//partial record X
//{

//}
#endregion
#region partial abstract class
//abstract partial class MyClass
//{

//}
//abstract partial class MyClass
//{

//}
#endregion
#region partial struct
//partial struct c
//{

//}
//partial struct c
//{

//}
//partial struct c
//{

//}
#endregion
#region partial interface
//partial interface IInterface
//{

//}
//partial interface IInterface
//{

//}
#endregion
#region partial metotlar
var m = new MyClass();
m.Y();
partial class MyClass
{
    public MyClass()
    {
        X();
        Y();
        Z();
    }
    partial void X(); //Gövdeleri tanımlanmadan public ile işaretleyemeyiz
    public partial void Y();
    partial void Z();  //Gövdeleri tanımlanmadan public ile işaretleyemeyiz

    public partial void Y()
    {
        Console.WriteLine("Y tetiklendi");
    }
}


#endregion