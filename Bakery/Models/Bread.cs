using System.Collections.Generic;
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
  
    public int CreateBreadPrice()
    {
      int breadOrder = 3;
      int breadTotal = 0;
      for(int index = 0; index < breadOrder; index ++)
      {
        if((index + 1) % 3 != 0) 
        {
          breadTotal += Price;
         }
      }
      
      return breadTotal;
    }
    }
  }

         
         
    
  
  
