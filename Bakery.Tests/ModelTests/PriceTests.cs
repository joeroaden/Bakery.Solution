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
      public void BreadPrice_MakesAnInstanceOfBread_Int()
      {
        int breadQuantity = 1;
        //double breadCost = 6;
        Bread newBread = new Bread(breadQuantity);
        Assert.AreEqual(1, breadQuantity);
      }

// next test
//  Bread newBread = new Bread(breadQuantity);
//         Assert.AreEqual(breadCost, newBread.breadCost());

    }
  }