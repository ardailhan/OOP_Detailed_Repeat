#region Null Conditional Operator - ?.
//Referanslara güvenli bir şekilde erişim yapmamızı sağlayan bir özelliktir.
//Bu operatör, bir referansla null olup olmadığını kontrol etmeksizin işlem yapabilmemizi sağlamaktadır.
//Meşhur null reference hatalarını önlemek için kullanılır.

//Person person = null;
//if (DateTime.Now.Day == 30) 
//    person = new();

//if (person != null)
//person.Name = "Test";

//Console.WriteLine(person?.Name);  //If kontrolü dısında kullanılacak daha modern tek satırlık kod ornegı



//Console.WriteLine(person?.Branch?.Department?.DepartmentName);

//class Person
//{
//    public string Name { get; set; }
//    public Branch Branch { get; set; }
//}
//class Branch
//{
//    public string BranchName { get; set; }
//    public Department Department { get; set; }
//}
//class Department
//{
//    public string DepartmentName { get; set; }
//}
#endregion
#region Null Coalescing Assignment Operator - ??=
//Bir değişkenin değerini yalnızca null ise başka bir değerle değiştirmek istendiğinde kullanılan bir atama operatörüdür.
//Bu operatör bir değişkenin değerini kontrol eder, eğer değer null ise sağ taraftaki ifadeyi ilgili değişkene atar, yok eğer null değilse mevcut değeri değiştirmeksizin yoluna devam eder.
//Yani bu operatör, bir değişkenin var olan değerini korumak istediğimiz durumlar için faydalı bir işleve sahiptir.

//Person person = null;
////if (person == null)
////{
////    person = new();
////}

//person ??= new();

//class Person
//{

//}
#endregion
#region Null(?) Operator & Nullable<T>
//Null(?) operatörü veya Nullable<T> türü, C#'ta değer türlü değişkenlerin null alabilmesini sağlayan yapılanmalardır.
#endregion
#region is Operator

Person p = new()
{
    Name = "Arda",
    Age = 30,
    Married = false
};

if (p is { Name: "Arda", Age: >=30, Married: false })
{
    //.....
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public bool Married { get; set; }
}
#endregion