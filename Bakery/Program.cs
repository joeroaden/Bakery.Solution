using System;
using System.Collections.Generic;
using Bakery.Models;

namespace  Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("___________________________");
      Console.WriteLine("Welcome to Pierre's Bakery!"); 
      Console.WriteLine("___________________________");
      Console.WriteLine("Today we have fresh bread $5 each or buy 2 get 1 free.  We also have pastries for $2 each or 3 for $5");

      Console.WriteLine("How many loaves of bread would you like today?");
      string stringBreadOrder = Console.ReadLine();
      int breadOrder = int.Parse(stringBreadOrder);
      int breadPrice = 5;
      Bread newBread = new Bread(breadOrder, breadPrice);

      Console.WriteLine("How many pastries would you like today?");
      string stringPastryOrder = Console.ReadLine();
      int pastryOrder = int.Parse(stringPastryOrder);
      int pastryPrice = 2;
      Pastry newPastry = new Pastry(pastryPrice, pastryOrder);

      int breadCost = newBread.CreateBreadPrice();
      int pastryCost = newPastry.CreatePastryPrice();
      int total = breadCost + pastryCost;
      Console.WriteLine("Your total is: $" + total);

    }
  }
}