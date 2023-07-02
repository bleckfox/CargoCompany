using DatabaseService.Context;
using InfrastructureService.Entities.ShipmentEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.ShipmentRepository;

namespace RepositoryService.Repositories.ShipmentRepo;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationContext _context;

    public ProductRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetProductById(int id)
    {
        var product = await _context.Products
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync()
                            ?? throw new InvalidOperationException("Product not found!");
                
        return CustomSerializer.Serialize(product);
    }

    public Task<bool> CreateProduct(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateProduct(int id, Product newProduct)
    {
        throw new NotImplementedException();
    }
}