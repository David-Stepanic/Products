using System;

namespace API.DTOs;

public class ProductReadDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public int StockQuantity { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<string> CategoryNames { get; set; } = new();
}
