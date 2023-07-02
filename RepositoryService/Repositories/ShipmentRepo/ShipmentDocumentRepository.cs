using DatabaseService.Context;
using InfrastructureService.Entities.ShipmentEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.ShipmentRepository;

namespace RepositoryService.Repositories.ShipmentRepo;

public class ShipmentDocumentRepository : IShipmentDocumentRepository
{
    private readonly ApplicationContext _context;

    public ShipmentDocumentRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetShipmentDocumentById(int id)
    {
        var shipmentDocument = await _context.ShipmentDocuments
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync()
                            ?? throw new InvalidOperationException("ShipmentDocument not found!");
                
        return CustomSerializer.Serialize(shipmentDocument);
    }

    public Task<bool> CreateShipmentDocument(ShipmentDocument shipmentDocument)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteShipmentDocument(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateShipmentDocument(int id, ShipmentDocument newShipmentDocument)
    {
        throw new NotImplementedException();
    }
}