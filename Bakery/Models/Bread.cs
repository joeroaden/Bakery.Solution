using System;

namespace Bakery.Models 
{
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }
    private static List<Bread> _breadOrder = new List<Bread> {};

    public Bread(int quantity, int price)
    {
      Price = price;
      Quantity = quantity;
    }
    
    public int CreateBreadPrice()
    {

    }
  }
}