//MyRecord m = new MyRecord(1, 2);
//m.a = 234;   //Positional record


MyRecordStruct mR = new MyRecordStruct(1, 2);
//mR.a = 3*15;
//mR.b = 8*7;
var mR2 = mR with { a =5, b =6};

MyREC rEC = new MyREC(1, "a");

Console.WriteLine(mR.ToString());
Console.WriteLine(rEC.ToString());

record MyRecord(int a, int b)
{

}


record struct MyRecordStruct(int a, int b)
{

}

record class MyREC(int x, string y)
{

}

record struct MyRecordStruct2
{
    public MyRecordStruct2()
    {
        
    }
}