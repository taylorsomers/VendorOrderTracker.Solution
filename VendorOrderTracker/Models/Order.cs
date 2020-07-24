using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string date)
    {
      Date = date;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}