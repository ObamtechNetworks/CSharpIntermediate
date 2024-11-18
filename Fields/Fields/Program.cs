using System.Runtime.InteropServices;

namespace Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote(); // cos of error in Promote method, orders becomes reset.

            Console.WriteLine(customer.Orders.Count);

        }
    }
}
