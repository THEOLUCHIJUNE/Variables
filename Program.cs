using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "";
            string LastName = "";
            int Age = 0;

            Console.Write("Please enter your first name: ");
            FirstName = Console.ReadLine();

            Console.WriteLine("Hello" + FirstName);
            
            Console.Write("Please enter your last name: ");
            LastName = Console.ReadLine();

            Console.WriteLine("Hello" + LastName);
        }
    }
}
