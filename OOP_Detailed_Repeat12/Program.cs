class Program
{
    static void Main(string[] args)
    {
        Person person = new Person
        {
            Name = "Arda",
            Age = 15
        };

        var (x, y) = person;
    }
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Deconstruct(out string name, out int age)
    {
        name = Name;
        age = Age;
    }
}