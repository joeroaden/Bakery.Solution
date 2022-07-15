using System;

namespace Bakery.Models 
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Pastry(int price,int quantity)
    {
      Price = price;
      Quantity = quantity;
    }
    public int CreatePastryPrice()
    {
      int pastryOrder = 3;
      int pastryTotal = ((pastryOrder/3)*5)+((pastryOrder % 3)*2);
      return pastryTotal;
    }

      public int CreatePastryPriceForSix()
    {
      int pastryOrder = 6;
      int pastryTotal = ((pastryOrder/3)*5)+((pastryOrder % 3)*2);
      return pastryTotal;
  }
}
}