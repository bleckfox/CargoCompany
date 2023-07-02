using DatabaseService.Context;
using InfrastructureService.Entities.DeliveryEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.DeliveryRepository;

namespace RepositoryService.Repositories.DeliveryRepo;

public class LocationRepository : ILocationRepository
{
    private readonly ApplicationContext _context;

    public LocationRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetLocationById(int id)
    {
        var location = await _context.Locations
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync()
                            ?? throw new InvalidOperationException("Location not found!");
                
        return CustomSerializer.Serialize(location);
    }

    public Task<bool> CreateLocation(Location location)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteLocation(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateLocation(int id, Location newLocation)
    {
        throw new NotImplementedException();
    }
}