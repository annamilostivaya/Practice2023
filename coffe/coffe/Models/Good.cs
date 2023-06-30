
using System.Collections.Generic;

namespace coffe.Models;

public class Good
{
    public int id { get; set; }
    public string name { get; set; }
    public int amount { get; set; }
    public double price { get; set; }
    public List<Order> Orders { get; set; }
}