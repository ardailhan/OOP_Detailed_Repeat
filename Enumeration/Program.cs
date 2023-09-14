//DatabaseType databaseType = DatabaseType.MsSql;
//Console.WriteLine(DatabaseType.MsSql);

//string database = "Oracle";

//DatabaseType databaseType = (DatabaseType)Enum.Parse(typeof(DatabaseType), database);
//Console.WriteLine();

//int d = 4;
//DatabaseType _d = (DatabaseType)d;

//Console.WriteLine((int)DatabaseType.PostgreSQL);

//Console.WriteLine();

//var types = Enum.GetValues(typeof(DatabaseType));
//foreach (var type in types)
//{
//    Console.WriteLine(type);
//}



//using System.ComponentModel;
//using System.Reflection;
//using System.Threading.Channels;

//DatabaseType database = DatabaseType.MySql;
//var description = database.GetType()
//    .GetField(database.ToString())
//    .GetCustomAttribute<DescriptionAttribute>()
//    .Description;

//Console.WriteLine(description);

//database.GetType()
//    .GetFields()
//    .Select(f =>
//    {
//        var descriptionAttribute = f.GetCustomAttribute<DescriptionAttribute>();
//        return descriptionAttribute?.Description;
//    })
//    .Where(d => d != null)
//    .ToList()
//    .ForEach(d => Console.WriteLine(d));


//enum DatabaseType
//{
//    [Description($"1. MySql")]
//    MySql,
//    [Description($"2. MsSql")]
//    MsSql,
//    [Description($"3. Oracle")]
//    Oracle,
//    [Description($"4. PostgreSQL")]
//    PostgreSQL = 123,
//    [Description($"5. MongoDB")]
//    MongoDB
//}


//Flags attribute
Console.WriteLine(Permissions.X | Permissions.Y | Permissions.Z);

[Flags]
enum Permissions
{
    X = 1,
    Y = 2,
    Z = 4,
    D = 8,
}