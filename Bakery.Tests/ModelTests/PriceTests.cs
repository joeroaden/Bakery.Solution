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
        Assert.AreEqual(1, newBread.Quantity);
      }
      [TestMethod]
      public void BreadPrice_GetPriceOfOneLoafOfBread_Int()
      {
        int breadQuantity = 1;
        int breadCost = 5;
        Bread newBread = new Bread(breadQuantity, breadCost);
        Assert.AreEqual(5, newBread.Price);
      }
      [TestMethod]
      public void PastryPrice_CreatInstanceOfPastryWithPrice_Int()
      {
        int pastryCost = 2;
        int pastryQuantity = 1;
        Pastry newPastry = new Pastry(pastryCost, pastryQuantity);
        Assert.AreEqual(2, newPastry.Price);
      }
      [TestMethod]
      public void PastryQuantity_CreatInstanceOfPastryWithQuantity_Int()
       {
        int pastryCost = 2;
        int pastryQuantity = 1;
        Pastry newPastry = new Pastry(pastryCost, pastryQuantity);
        Assert.AreEqual(1, newPastry.Quantity);
      }
      [TestMethod]
      public void BreadPrice_GetPriceOfThreeLoavesOfBread_Int()
      {
        int breadPriceForThree = 10;
        int breadQuantity = 1;
        int breadCost = 5;
        Bread newBread = new Bread(breadQuantity, breadCost);
        Assert.AreEqual(breadPriceForThree, newBread.CreateBreadPrice());
      }
      // [TestMethod]
      // public void PastryPrice_GetPriceOfThreePastries_Int()
      // {
      //   int pastryPriceForThree = 5;
      //   int pastryCost = 2;
      //   int pastryQuantity = 3;
      //   Pastry newPastry = new Pastry(pastryCost, pastryQuantity);
      //   Assert.AreEqual(pastryPriceForThree, newPastry.CreatePastryPrice());
      // }
      [TestMethod]
      public void PastryPrice_GetPriceOfFourPastries_Int()
      {
        int pastryPriceForFour = 10;
        int pastryCost = 2;
        int pastryQuantity = 6;
        Pastry newPastry = new Pastry(pastryCost, pastryQuantity);
        Assert.AreEqual(pastryPriceForFour, newPastry.CreatePastryPrice());
      }
    }
  }