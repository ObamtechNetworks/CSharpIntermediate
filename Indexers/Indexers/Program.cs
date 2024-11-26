namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Michael";

            Console.WriteLine(cookie["name"]);
        }
    }
}
