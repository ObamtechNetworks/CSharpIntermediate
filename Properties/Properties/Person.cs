namespace Properties;

public class Person
{
    // auto-implemented properties
    public string Name { get; set; }
    public string Username { get; set; }
    public DateTime Birthdate { get; private set; } // adding the private accessor would warrant the need to set a constructor for the person class so that the birthdate can be set once


    // implement the set in the constructor
    public Person(DateTime birthdate)
    {
        Birthdate = birthdate;
    }
    

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