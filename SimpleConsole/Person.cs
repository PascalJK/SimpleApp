namespace SimpleConsole;

public class Person : Base
{
    private readonly List<string> Interests = new();

    public string Name;
    public string FirstName;
    public string LastName;
    public DateTime BirthDate { get; }
    public int Age 
    {
        get
        {
            var timeSpan = DateTime.Today - BirthDate;
            var years = timeSpan.Days / 365;
            return years;
        }
    }


    public Person(DateTime birthDate) : base("Pascal", 23)
    {
        BirthDate = birthDate;
        Console.WriteLine("Person ctor\n");
    }

    // Take note cannot reInit readonly field.

    //public void ReInit() => Interests = new();
}
