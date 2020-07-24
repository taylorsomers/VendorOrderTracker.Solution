using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrderTracker.Models;
using System;

namespace VendorOrderTracker.Tests
{  [TestClass]
  public class ItemTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstancesOfOrder_Order()
    {
      string date = "test date";
      Order newOrder = new Order(date);
      Assert.AreEqual(typeof(int), newOrder.GetType());
    }
  }
}