using System;
using API.DTOs;
using API.Repositories;
using Models.Entities;

namespace API.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _unitOfWork;
    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<Product?> CreateAsync(Product product)
    {
        var created = await _unitOfWork.Products.CreateAsync(product);
        await _unitOfWork.SaveChangesAsync();
        return created;
    }
    public async Task<Product?> GetByIdAsync(int id)
    {
        return await _unitOfWork.Products.GetByIdAsync(id);
    }
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
        return await _unitOfWork.Products.GetAllAsync();
    }
    public async Task UpdateAsync(Product product)
    {
        _unitOfWork.Products.Update(product);
        await _unitOfWork.SaveChangesAsync();
    }
    public async Task DeleteAsync(Product product)
    {
        _unitOfWork.Products.Delete(product);
        await _unitOfWork.SaveChangesAsync();
    }
    
}
