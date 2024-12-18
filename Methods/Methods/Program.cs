﻿namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number; // must be declared in order to use the out modifier
            // demonstrating the 'out' modifier using the TryParse method
           var result =  int.TryParse("abc", out number);
           if (result)
               Console.WriteLine(number);
           else
               Console.WriteLine("Conversion failed");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }
        static void UsePoint() 
        { 
            try 
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));

                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(null);
                Console.WriteLine("Point is at({0}, {1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred"); ;
            }
        }
    }
}
