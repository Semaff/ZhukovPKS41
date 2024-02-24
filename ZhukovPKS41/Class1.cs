Person tom = new();
tom.PrintName();
tom.PrintSurname();

class Person
{
    string type = "Person";
    public void PrintName()
    {
        string name = "Tom";

        {
            string shortName = "Tomas";
            Console.WriteLine(type);
            Console.WriteLine(name);
            Console.WriteLine(shortName);
        }

        Console.WriteLine(type);
        Console.WriteLine(name);
    }

    public void PrintSurname()
    {
        string surname = "Smith";

        Console.WriteLine(type);
        Console.WriteLine(surname);
    }
}
