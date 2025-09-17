using System;
using API.DTOs;
using API.Services;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _service;
    private readonly IMapper _mapper;

    public ProductsController(IProductService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await _service.GetAllAsync();

        var result = _mapper.Map<IEnumerable<ProductReadDto>>(products);

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await _service.GetByIdAsync(id);
        if (product == null) return NotFound();

        var dto = _mapper.Map<ProductReadDto>(product);
        return Ok(dto);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] ProductCreateDto dto)
    {
        var product = _mapper.Map<Product>(dto);
        var created = await _service.CreateAsync(product);

        if (created == null) return BadRequest("Product could not be created");

        var result = _mapper.Map<ProductReadDto>(created);
        return CreatedAtAction(nameof(GetById), new { id = created.ProductId }, result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] ProductUpdateDto dto)
    {
        if (id != dto.ProductId) return BadRequest();

        var product = await _service.GetByIdAsync(id);
        if (product == null) return NotFound();

        _mapper.Map(dto, product);

        product.ProductCategories.Clear();

        foreach (var catId in dto.CategoryIds)
        {
            product.ProductCategories.Add(new ProductCategories { CategoryId = catId });
        }

        await _service.UpdateAsync(product);

        var result = _mapper.Map<ProductReadDto>(product);

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var product = await _service.GetByIdAsync(id);
        if (product == null) return NotFound();

        await _service.DeleteAsync(product);
        return NoContent();
    }
}
