namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // transform to static method for better accessiblity
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Michael";
            person.Introduce("Mosh");

            // create a person method from a string
            // process below is weired because of the too many redundant steps
            /*var person2 = new Person();
            var p = person2.Parse("John");
            person.Introduce("Mosh");
            */

            // to solve this, declaring the Parse method as a static modifier makes things better
            // why this works? because already in the Parse method, a person class is already create
            // therefore no need for redundantly creating a person instance again before creating a person object
            var person2 = Person.Parse("John");
            person2.Introduce("Caleb");
        }
    }
}
