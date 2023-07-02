using DatabaseService.Context;
using InfrastructureService.Entities.ShipmentEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.ShipmentRepository;

namespace RepositoryService.Repositories.ShipmentRepo;

public class ShipmentDetailRepository : IShipmentDetailRepository
{
    private readonly ApplicationContext _context;

    public ShipmentDetailRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetShipmentDetailById(int id)
    {
        var shipmentDetail = await _context.ShipmentDetails
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync()
                            ?? throw new InvalidOperationException("ShipmentDetail not found!");
                
        return CustomSerializer.Serialize(shipmentDetail);
    }

    public Task<bool> CreateShipmentDetail(ShipmentDetail shipmentDetail)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteShipmentDetail(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateShipmentDetail(int id, ShipmentDetail newShipmentDetail)
    {
        throw new NotImplementedException();
    }
}