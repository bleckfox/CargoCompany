using DatabaseService.Context;
using InfrastructureService.Entities.CompanyEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.CompanyRepository;

namespace RepositoryService.Repositories.CompanyRepo;

public class SupplierRepository : ISupplierRepository
{
    private readonly ApplicationContext _context;

    public SupplierRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetSupplierById(int id)
    {
        var supplier = await _context.Suppliers
                           .Where(x => x.Id == id)
                           .FirstOrDefaultAsync()
                       ?? throw new InvalidOperationException("Supplier not found!");
        
        return CustomSerializer.Serialize(supplier);
    }

    public Task<bool> CreateSupplier(Supplier supplier)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteSupplier(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateSupplier(int id, Supplier newSupplier)
    {
        throw new NotImplementedException();
    }
}