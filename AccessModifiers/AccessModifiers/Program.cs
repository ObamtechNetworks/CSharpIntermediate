 namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var person  = new Person();
            person.SetBirthDate(new DateTime(1992, 1, 1));
            Console.WriteLine(person.GetBirthDate());

            // OOP principle 
            // Objects are about behaviours, about what they do
            // Their fields are primarily internals, their implementation details which should be hidden from the outside world
            // - Encapsulation specifies:
            //      Objects should hide their implementation  and reveal what they can do  and not how they do what they are supposed to do
        }
    }
}
