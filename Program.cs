using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Program
    {
      static void Main()
      {
        Bread loaf = new Bread("loaf", 5);
        Pastery croissant = new Pastery("croissant", 4);
        Dictionary<string, int> basket = new Dictionary<string, int>(); 

        Console.WriteLine("----------------------------------------------\nWelcome To Pierre's Bakery!\n----------------------------------------------\n");
        
        Console.WriteLine("Would you like to purchase bread or pastery, or view your basket? (bread/pastery/basket)");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() != "bread" || userInput.ToLower() != "pastery")
        {
          Console.WriteLine("We could not understand your order, please re-enter either 'bread' or 'pastery'.");
          userInput = Console.ReadLine();
        }

        if (userInput.ToLower() == "view" || userInput.ToLower() == "basket")
        {
          Console.WriteLine();
        }
        else if (userInput.ToLower() == "bread")
        {
          Console.WriteLine("You have ordered a" + loaf.GetName() + "of bread.");
          Console.WriteLine("It will cost $" + loaf.GetPrice());
          basket.Add(loaf.GetName(), loaf.GetPrice());
        }
        else if  (userInput.ToLower() == "pastery")
        {
          Console.WriteLine("You have ordered a" + loaf.GetName() + "of bread.");
          Console.WriteLine("It will cost $" + loaf.GetPrice());
          basket.Add(croissant.GetName(), croissant.GetPrice());
        }
        

        
        
      }
    }
}
