using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Program
    {

      public static void Order()
      {
        Bread loaf = new Bread("loaf", 5, 0);
        Pastery croissant = new Pastery("croissant", 4, 0);

        Console.WriteLine("Would you like to purchase bread or a pastery, or view your basket? (bread/pastery/basket)");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "view" || userInput.ToLower() == "basket")
        {
          Console.WriteLine();
          Order();
        }
        else if (userInput.ToLower() == "bread")
        {
          Console.WriteLine("You have ordered a " + loaf.GetName() + " of bread.");
          Console.WriteLine("It will cost $" + loaf.GetPrice());
          loaf.SetAddOne();
          Order();
        }
        else if  (userInput.ToLower() == "pastery")
        {
          Console.WriteLine("You have ordered a " + croissant.GetName() + " of bread.");
          Console.WriteLine("It will cost $" + croissant.GetPrice());
          croissant.SetAddOne();
          Order();
        }
        else
        {
          Console.WriteLine("We could not understand your order, please re-enter either 'bread' or 'pastery'.");
          Order();
        }
      }

      public static void Main()
      {
         

        Console.WriteLine("----------------------------------------------\nWelcome To Pierre's Bakery!\n----------------------------------------------\n");
        
        Program.Order();


      }
    }
}
