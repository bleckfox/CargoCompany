using DatabaseService.Context;
using InfrastructureService.Entities.CompanyEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.CompanyRepository;

namespace RepositoryService.Repositories.CompanyRepo;

public class BrokerRepository : IBrokerRepository
{
    private readonly ApplicationContext _context;

    public BrokerRepository(ApplicationContext context)
    {
        _context = context;
    }
    
    public async Task<string> GetBrokerById(int id)
    {
        var broker = await _context.Brokers
                        .Where(x => x.Id == id)
                        .FirstOrDefaultAsync()
                    ?? throw new InvalidOperationException("Broker not found!");
        
        return CustomSerializer.Serialize(broker);
    }

    public Task<bool> CreateBroker(Broker broker)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteBroker(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateBroker(int id, Broker newBroker)
    {
        throw new NotImplementedException();
    }
}