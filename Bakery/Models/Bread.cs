using System;

namespace Bakery.Models 
{
  public class Bread
  {
    public static int Price = 5;
    // private double _Discount; shoudl we use this in Price.cs?
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      //Price = price;
      Quantity = quantity;
    }
  }
}