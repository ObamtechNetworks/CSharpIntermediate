namespace Properties;

public class Person
{
    // implement the set in the constructor
    public Person(DateTime birthdate)
    {
        Birthdate = birthdate;
    }
    // auto-implemented property
    public DateTime Birthdate { get; private set; } // adding the private accessor would warrant the need to set a constructor for the person class so that the birthdate can be set once

    public int Age
    {
        get
        {
            var timeSpan = DateTime.Today - Birthdate;
            var years = timeSpan.Days / 365;

            return years;
        }
    }
}