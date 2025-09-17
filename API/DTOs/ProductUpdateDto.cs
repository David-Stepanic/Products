using System;

namespace API.DTOs;

public class ProductUpdateDto : ProductCreateDto
{
    public int ProductId { get; set; }
}
