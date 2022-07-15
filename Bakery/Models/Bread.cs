using System;

namespace Bakery.Models 
{
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Bread(int quantity, int price)
    {
      Price = price;
      Quantity = quantity;
    }
  }
}