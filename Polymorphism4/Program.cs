class Program
{
    static void Main(string[] args)
    {
        //A a = new C();
        //C c = (C)a; //Cast işlemi

        //D d = (D)a;

        //object o = 123;
        //int i = (int)o;

        A a = new C();
        if (a is D) { D d = (D)a; }
        else if (a is C) {}
        //D d = (D)a; // Hata fırlatır.
        //D d = a as D; // Null doner.
    }
}
class A{}
class B : A{}
class C : B{}
class D : C{}