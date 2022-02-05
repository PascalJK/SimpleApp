namespace SimpleConsole;

public class Person
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


    public Person(DateTime birthDate)
    {
        BirthDate = birthDate;
    }

    // Take note cannot reInit readonly field.

    //public void ReInit() => Interests = new();
}
