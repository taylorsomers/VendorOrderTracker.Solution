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

    [TestMethod]
    public void GetAll_ReturnsEmpyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string date1 = "Jun 25";
      string date2 = "Jun 27";
      Order newOrder1 = new Order(date1);
      Order newOrder2 = new Order(date2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string date = "Jun 25";
      Order newOrder = new Order(date);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string date1 = "Jun 25";
      string date2 = "Jun 27";
      Order newOrder1 = new Order(date1);
      Order newOrder2 = new Order(date2);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}