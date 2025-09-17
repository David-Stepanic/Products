using System;

namespace Models.Entities;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public int StockQuantity { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public ICollection<ProductCategories> ProductCategories { get; set; } = [];
}
