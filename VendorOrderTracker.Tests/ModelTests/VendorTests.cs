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
      
      Vendor newVendor = new Vendor(vendorName);

      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void VendorConstructor_AddsNameToInstanceOfVendor_VendorName()
    {
      string vendorName = "test vendor";
      Vendor newVendor = new Vendor(vendorName);

      string result = newVendor.Name;

      Assert.AreEqual("test vendor", result);
    }

    [TestMethod]
    public void VendorConstructor_AddsIdToInstanceOfVendor_VendorId()
    {
      string vendor1 = "vendor1";
      string vendor2 = "vendor2";
      Vendor newVendor = new Vendor(vendor1);
      Vendor newVendor2 = new Vendor(vendor2);

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
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      List<Vendor> result = Vendor.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "vendor1";
      string name2 = "vendor2";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);

      Vendor result = Vendor.Find(2);

      Assert.AreEqual(newVendor2, result);
    }
  }
}