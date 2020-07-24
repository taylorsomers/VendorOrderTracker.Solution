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
  }
}