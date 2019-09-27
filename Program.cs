using System;

namespace Bakery
{
    public class Program
    {
      public static void Order(Bread loaf, Pastery croissant)
      {

        Console.WriteLine("Would you like to purchase bread or a pastery, or view your basket? (bread/pastery/basket)");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "view" || userInput.ToLower() == "basket")
        {
          Console.WriteLine("--------------------------------\nYour order:\n" + loaf.GetQuantity() + " bread item(s) and " + croissant.GetQuantity() + " pastery item(s)." );
          double newBreadPrice = loaf.SetDeal();
          double newCroissantPrice = croissant.SetDeal();
          double basketTotal = (newBreadPrice * loaf.GetQuantity()) + (newCroissantPrice * croissant.GetQuantity());
          Console.WriteLine("Your total is $ " + basketTotal + ".");
          Console.WriteLine("Would you like to exit program? (exit/continue)");
          string userContinue = Console.ReadLine();
          if (userContinue.ToLower() == "continue")
          {
          Order(loaf, croissant);
          }
          else
          {
            // exits program
          }
        }
        else if (userInput.ToLower() == "bread")
        {
          Console.WriteLine("You have ordered a " + loaf.GetName() + " of bread.");
          Console.WriteLine("It will cost $" + loaf.GetPrice());
          loaf.SetAddOne();
          loaf.SetTotal();
          Console.WriteLine(loaf.GetTotal());
          Order(loaf, croissant);
        }
        else if  (userInput.ToLower() == "pastery")
        {
          Console.WriteLine("You have ordered a " + croissant.GetName() + " of bread.");
          Console.WriteLine("It will cost $" + croissant.GetPrice());
          croissant.SetAddOne();
          croissant.SetTotal();
          Console.WriteLine(croissant.GetTotal());
          Order(loaf, croissant);
        }
        else
        {
          Console.WriteLine("We could not understand your order, please re-enter either 'bread' or 'pastery'.");
          Order(loaf, croissant);
        }
      }

      public static void Main()
      {
        Bread loaf = new Bread("loaf", 4, 0, 0);
        Pastery croissant = new Pastery("croissant", 2, 0, 0);

        Console.WriteLine("----------------------------------------------\nWelcome To Pierre's Bakery!\n----------------------------------------------\n");
        
        Program.Order(loaf, croissant);
      }
    }
}
