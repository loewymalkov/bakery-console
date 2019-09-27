using System;

namespace Bakery
{
    public class Program
    {
      public static void Main()
      {
        Bread loaf = new Bread("loaf", 4, 0, 0);
        Pastery croissant = new Pastery("croissant", 2, 0, 0);
        Order newOrder = new Order();

        Console.WriteLine("----------------------------------------------\nWelcome To Pierre's Bakery!\nWe currently have two deals:\nBuy 2 loafs, get 1 free. A single loaf costs $4.\n Buy 1 croissant for $2 or 3 for $5.\n----------------------------------------------\n");

        Order.NewOrder(loaf, croissant);
      }
    }
}
