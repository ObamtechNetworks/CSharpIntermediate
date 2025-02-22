namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982, 1, 1)); // must be initialized since now uses a constructor
            // person.Birthdate = new DateTime(1982, 1, 1);

            Console.WriteLine(person.Age);

            var person2 = new Person(new DateTime(1997, 11, 28));
            Console.WriteLine(person2.Age);
            person2.Name = "Michael";
            Console.WriteLine(person2.Name);
            Console.WriteLine(person2.Birthdate);
        }
    }
}

