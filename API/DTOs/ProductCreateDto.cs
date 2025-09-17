using System;

namespace API.DTOs;

public class ProductCreateDto
{
    public string ProductName { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public int StockQuantity { get; set; }
    public List<int> CategoryIds { get; set; } = new();
}
