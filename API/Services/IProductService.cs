using System;
using API.DTOs;
using API.Repositories;
using Models.Entities;

namespace API.Services;

public interface IProductService
{
    Task<Product?> CreateAsync(Product product);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Product product);
}
