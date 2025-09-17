using System;

namespace Models.Entities;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public ICollection<ProductCategories> ProductCategories { get; set; } = [];
}
