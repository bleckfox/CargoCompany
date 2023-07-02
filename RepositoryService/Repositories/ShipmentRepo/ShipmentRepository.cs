using DatabaseService.Context;
using InfrastructureService.Entities.ShipmentEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.ShipmentRepository;

namespace RepositoryService.Repositories.ShipmentRepo;

public class ShipmentRepository : IShipmentRepository
{
    private readonly ApplicationContext _context;

    public ShipmentRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetShipmentById(int id)
    {
        var shipment = await _context.Shipments
                        .Where(x => x.Id == id)
                        .FirstOrDefaultAsync()
                    ?? throw new InvalidOperationException("Shipment not found!");
        
        return CustomSerializer.Serialize(shipment);
    }

    public Task<bool> CreateShipment(Shipment shipment)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteShipment(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateShipment(int id, Shipment newShipment)
    {
        throw new NotImplementedException();
    }
}