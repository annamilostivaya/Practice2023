using System.Collections.Generic;

namespace coffe.Models;

public class User
{
    public int id { get; set; }
    public string? name { get; set; }
    public string? password { get; set; }
    public string? email { get; set; }
    public int? isAdmin { get; set; }
    public List<Order> Orders { get; set; }


}