using DatabaseService.Context;
using InfrastructureService.Entities.DeliveryEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.DeliveryRepository;

namespace RepositoryService.Repositories.DeliveryRepo;

public class CustomHouseRepository : ICustomHouseRepository
{
    private readonly ApplicationContext _context;

    public CustomHouseRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetCustomHouseById(int id)
    {
        var customHouse = await _context.CustomHouses
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync()
                            ?? throw new InvalidOperationException("CustomHouse not found!");
                
        return CustomSerializer.Serialize(customHouse);
    }

    public Task<bool> CreateCustomHouse(CustomHouse customHouse)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCustomHouse(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateCustomHouse(int id, CustomHouse newCustomHouse)
    {
        throw new NotImplementedException();
    }
}