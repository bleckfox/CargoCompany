using DatabaseService.Context;
using InfrastructureService.Entities.DeliveryEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.DeliveryRepository;

namespace RepositoryService.Repositories.DeliveryRepo;

public class StorageRepository : IStorageRepository
{
    private readonly ApplicationContext _context;

    public StorageRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetStorageById(int id)
    {
        var storage = await _context.Storages
                           .Where(x => x.Id == id)
                           .FirstOrDefaultAsync()
                       ?? throw new InvalidOperationException("Storage not found!");
                
        return CustomSerializer.Serialize(storage);
    }

    public Task<bool> CreateStorage(Storage storage)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteStorage(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateStorage(int id, Storage newStorage)
    {
        throw new NotImplementedException();
    }
}