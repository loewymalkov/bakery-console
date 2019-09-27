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
          Console.WriteLine("--------------------------------\nYour order:\n" + loaf.GetQuantity() + " bread item(s) and " + croissant.GetQuantity() + " pastery item(s)." );
          loaf.SetTotal();
          croissant.SetTotal();
          double newBreadPrice = loaf.SetDeal();
          double newCroissantPrice = croissant.SetDeal();
          double basketTotal = (newBreadPrice) + (newCroissantPrice);
          Console.WriteLine("Your total is $ " + basketTotal + ".\n--------------------------------");
          Console.WriteLine("Would you like to exit program? (exit/continue)");
          string userContinue = Console.ReadLine();
          if (userContinue.ToLower() == "continue")
          {
          NewOrder(loaf, croissant);
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
          Console.WriteLine("You currently have " + loaf.GetQuantity() + " bread item(s)");
          NewOrder(loaf, croissant);
        }
        else if  (userInput.ToLower() == "pastery")
        {
          Console.WriteLine("You have ordered a " + croissant.GetName() + " of bread.");
          Console.WriteLine("It will cost $" + croissant.GetPrice());
          croissant.SetAddOne();
          Console.WriteLine("You currently have " + croissant.GetQuantity() + " pastery item(s)");
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