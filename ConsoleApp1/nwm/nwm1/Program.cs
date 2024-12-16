namespace nwm1;

class Program
{
    static void Main(string[] args)
    {
        Klasa person1 = new Klasa("Michael","Smith", 17);
        Console.Write(person1.Name+" "+person1.Surname+" age "+person1.Age);
    }
}
