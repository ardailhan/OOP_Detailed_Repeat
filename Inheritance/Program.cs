class Program
{
    static void Main(string[] args)
    {
        Accountant accountant = new Accountant();
        accountant.Name = "Test";
        accountant.Advisor = true;
        Developer developer = new Developer();
        //developer.UsedLanguage
    }
}

class Staff
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public bool MaritalStatus { get; set; }
}

class Accountant : Staff
{
    public bool Advisor { get; set; }
}

class Developer : Staff
{
    public string[] UsedLanguage { get; set; }
}

class Technician : Staff
{
    
}