using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorOrderTracker.TestTools
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstancesOfVendor_Vendor()
    {
      string vendorName = "test vendor";
      string vendorDescription = "test description";
      
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void SetName_AddsNameToInstanceOfVendor_VendorName()
    {
      string vendorName = "test vendor";
      string vendorDescription = "test description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      string result = newVendor.Name;

      Assert.AreEqual("test vendor", result);
    }

    [TestMethod]
    public void SetDescription_AddsDescriptionToInstanceOfVendor_VendorDescription()
    {
      string vendorName = "test vendor";
      string vendorDescription = "test description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);

      string result = newVendor.Description;

      Assert.AreEqual("test description", result);
    }

    [TestMethod]
    public void SetId_AddsIdToInstanceOfVendor_VendorId()
    {
      string vendor1 = "vendor1";
      string vendor2 = "vendor2";
      string description1 = "description1";
      string description2 = "description2";
      Vendor newVendor = new Vendor(vendor1, description1);
      Vendor newVendor2 = new Vendor(vendor2, description2);

      int result = newVendor.Id;
      int result2 = newVendor2.Id;

      Assert.AreEqual(1, result);
      Assert.AreEqual(2, result2);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "vendor1";
      string name2 = "vendor2";
      string description1 = "description1";
      string description2 = "description2";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "vendor1";
      string name2 = "vendor2";
      string description1 = "description1";
      string description2 = "description2";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string date = "Jun 25";
      Order newOrder = new Order(date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "vendor1";
      string description = "description1";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}