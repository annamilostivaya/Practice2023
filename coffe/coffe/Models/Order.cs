

namespace coffe.Models;

public class Order
{
    public int id { get; set; }
    public int amount { get; set; }
    public double? totalPrice { get; set; }
    public int UserId { get; set; }
    public int GoodId { get; set; }
    public User User { get; set; }
    public Good Good { get; set; }


}