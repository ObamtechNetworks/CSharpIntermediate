namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var cookie = new HttpCookie();
            //cookie["name"] = "Michael";

            //Console.WriteLine(cookie["name"]);


            // Create an HttpCookie instance and set expiration date
            var cookie = new HttpCookie(DateTime.Now.AddDays(7));

            // Accessing Expiry
            Console.WriteLine("Cookie Expiry: " + cookie.Expiry);

            // Setting key-value pairs
            cookie["username"] = "john_doe";
            cookie["sessionid"] = "abc123";

            // Accessing values from the cookie
            Console.WriteLine("Username: " + cookie["username"]);
            Console.WriteLine("Session ID: " + cookie["sessionid"]);

            // Update expiry if needed
            cookie.SetExpiry(DateTime.Now.AddDays(30));
            Console.WriteLine("Updated Expiry: " + cookie.Expiry);
        }
    }
}
