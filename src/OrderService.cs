public static class OrderService
{
    public static string? GetCustomerWithMostSpent(IEnumerable<Order> orders)
    {
        if (orders == null) return null;

        var spentByCustomer = orders
            .Where(o => o?.Customer != null)
            .GroupBy(o => o.Customer!.Id)
            .Select(g => new
            {
                Customer = g.First().Customer,
                Total = g.Sum(o => o.GetFinalPrice())
            })
            .ToList();

        var max = spentByCustomer.OrderByDescending(x => x.Total).FirstOrDefault();
        return max?.Customer?.Name;
    }

    public static List<(int ItemId, int TotalQuantity)> GetPopularProducts(IEnumerable<Order> orders, int topN)
    {
        if (orders == null || topN <= 0) return new List<(int, int)>();

        var productQuantities = orders
            .SelectMany(o => o.OrderItems ?? Enumerable.Empty<OrderItem>())
            .Where(i => i != null && i.ItemId != 0)
            .GroupBy(i => i.ItemId)
            .Select(g => (ItemId: g.Key, TotalQuantity: g.Sum(i => i.Quantity)))
            .OrderByDescending(x => x.TotalQuantity)
            .Take(topN)
            .ToList();

        return productQuantities;
    }
}
