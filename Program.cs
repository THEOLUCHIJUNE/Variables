using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName;
            FirstName = "Oluchi";
            Console.WriteLine(FirstName);

            string LastName;
            LastName = "Ifeanyi";
            Console.WriteLine(LastName);

            int Age;
            Age = 58;
            Console.WriteLine(Age);

            string Name = ""; 
            Console.Write("Please enter your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Hello, " +  Name +  ". My name is Oluchi June Ifeanyi.");
            
            string BestFood = "";
            Console.Write("Please enter your best food: ");
            BestFood = Console.ReadLine();
            Console.WriteLine("Hello, "  + Name +  ". It is interesting that your best food is "  + BestFood +  ". Mine is Agege Bread and Agoyin Beans. :-)" );

        }
    }
}
