public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; } = null!;
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public decimal GetFinalPrice()
    {
        decimal total = OrderItems?.Sum(item => item.UnitPrice * item.Quantity) ?? 0;
        if (total > 500)
            return total * 0.9m;
        return total;
    }
}