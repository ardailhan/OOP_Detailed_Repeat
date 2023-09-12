var person = new
{
    Name = "Arda",
    Surname = "İlhan"
};
WritePerson(person);

void WritePerson(dynamic person)
{
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Surname);
}

Console.WriteLine(person.GetType().FullName);