using System;

namespace Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
          Bread loaf = new Bread("loaf", 5);
          Pastery croissant = new Pastery("croissant", 4);

            Console.WriteLine("----------------------------------------------\nWelcome To Pierre's Bakery!\n----------------------------------------------\nWould you like to purchase bread or pastery? (bread/pastery)");
            string userInput = Console.ReadLine();


            if (userInput.ToLower() == "bread")
            {
              Console.WriteLine("You have ordered a" + loaf.GetName() + "of bread.");
              Console.WriteLine("It will cost $" + loaf.GetPrice());
            }
        }
    }
}
