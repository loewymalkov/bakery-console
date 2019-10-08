using System;

namespace Bakery
{
  class Order
  {
    public static void NewOrder(Bread loaf, Pastery croissant)
      {

        Console.WriteLine("Would you like to purchase bread or a pastery, or view your basket? (bread/pastery/basket)");
        string userInput = Console.ReadLine();

        if (userInput.ToLower() == "view" || userInput.ToLower() == "basket")
        {
          Console.WriteLine("--------------------------------\nYour order:\n" + loaf.Quantity + " bread item(s) and " + croissant.Quantity + " pastery item(s)." );
          loaf.Total += loaf.Quantity * loaf.Price;
          croissant.Total += croissant.Quantity * croissant.Price;
          double newBreadPrice = loaf.Deal();
          double newCroissantPrice = croissant.Deal();
          double basketTotal = (newBreadPrice) + (newCroissantPrice);
          Console.WriteLine("Your total is $ " + basketTotal + ".\n--------------------------------");
          Console.WriteLine("Would you like to exit program? (exit/continue)");
          string userContinue = Console.ReadLine();
          if (userContinue.ToLower() == "continue")
          {
          NewOrder(loaf, croissant);
          }
        }
        else if (userInput.ToLower() == "bread")
        {
          Console.WriteLine("You have ordered a " + loaf.Name + " of bread.");
          Console.WriteLine("It will cost $" + loaf.Price);
          loaf.AddOne();
          Console.WriteLine("You currently have " + loaf.Quantity + " bread item(s)");
          NewOrder(loaf, croissant);
        }
        else if  (userInput.ToLower() == "pastery")
        {
          Console.WriteLine("You have ordered a " + croissant.Name + " of bread.");
          Console.WriteLine("It will cost $" + croissant.Price);
          croissant.AddOne();
          Console.WriteLine("You currently have " + croissant.Quantity + " pastery item(s)");
          NewOrder(loaf, croissant);
        }
        else
        {
          Console.WriteLine("We could not understand your order, please re-enter either 'bread' or 'pastery'.");
          NewOrder(loaf, croissant);
        }
      }
  }
}