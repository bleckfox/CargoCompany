using DatabaseService.Context;
using InfrastructureService.Entities.ShipmentEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.ShipmentRepository;

namespace RepositoryService.Repositories.ShipmentRepo;

public class ContainerRepository : IContainerRepository
{
    private readonly ApplicationContext _context;

    public ContainerRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetContainerById(int id)
    {
        var container = await _context.Containers
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync()
                            ?? throw new InvalidOperationException("Container not found!");
                
        return CustomSerializer.Serialize(container);
    }

    public Task<bool> CreateContainer(Container container)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteContainer(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateContainer(int id, Container newContainer)
    {
        throw new NotImplementedException();
    }
}