using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Test
  {
    [TestClass]
    public class BakeryTests
    {
      [TestMethod]
      public void BreadQuantity_MakesAnInstanceOfBread_Int()
      {
        int breadQuantity = 1;
        int breadCost = 5;
        Bread newBread = new Bread(breadQuantity, breadCost);
        Assert.AreEqual(breadQuantity, newBread.Quantity);
      }
      [TestMethod]
      public void BreadPrice_GetPriceOfOneLoafOfBread_Int()
      {
        int breadQuantity = 1;
        int breadCost = 5;
        Bread newBread = new Bread(breadQuantity, breadCost);
        Assert.AreEqual(breadCost, newBread.Price);
      }
      [TestMethod]
      public void PastryPrice_CreatInstanceOfPastryWithPrice_Int()
      {
        int pastryCost = 2;
        int pastryQuantity = 1;
        Pastry newPastry = new Pastry(pastryCost, pastryQuantity);
        Assert.AreEqual(pastryCost, newPastry.Price);
      }
      [TestMethod]
      public void PastryQuantity_CreatInstanceOfPastryWithQuantity_Int()
       {
        int pastryCost = 2;
        int pastryQuantity = 1;
        Pastry newPastry = new Pastry(pastryCost, pastryQuantity);
        Assert.AreEqual(pastryQuantity, newPastry.Quantity);
      }
    }
  }