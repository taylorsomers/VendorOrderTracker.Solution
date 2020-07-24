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
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "Jun 25";

      Order newOrder = new Order(date);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_UpdatesDate_String()
    {
      string date = "Jun 25";
      Order newOrder = new Order(date);

      string newDate = "Jun 27";
      newOrder.Date = newDate;
      string result = newOrder.Date;

      Assert.AreEqual(newDate, result);
    }
  }
}