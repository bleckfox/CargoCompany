using DatabaseService.Context;
using InfrastructureService.Entities.DeliveryEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.DeliveryRepository;

namespace RepositoryService.Repositories.DeliveryRepo;

public class ArrivalPointRepository : IArrivalPointRepository
{
    private readonly ApplicationContext _context;

    public ArrivalPointRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetArrivalPointById(int id)
    {
        var point = await _context.ArrivalPoints
                        .Where(x => x.Id == id)
                        .FirstOrDefaultAsync()
                    ?? throw new InvalidOperationException("ArrivalPoint not found!");
        
        return CustomSerializer.Serialize(point);
    }

    public Task<bool> CreateArrivalPoint(ArrivalPoint arrivalPoint)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteArrivalPoint(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateArrivalPoint(int id, ArrivalPoint newArrivalPoint)
    {
        throw new NotImplementedException();
    }
}