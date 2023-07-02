using DatabaseService.Context;
using InfrastructureService.Entities.CompanyEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.CompanyRepository;

namespace RepositoryService.Repositories.CompanyRepo;

public class ClientRepository : IClientRepository
{
    private readonly ApplicationContext _context;

    public ClientRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetClientById(int id)
    {
        var client = await _context.Clients
                        .Where(x => x.Id == id)
                        .FirstOrDefaultAsync()
                    ?? throw new InvalidOperationException("Client not found!");
        
        return CustomSerializer.Serialize(client);
    }

    public Task<bool> CreateClient(Client client)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteClient(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateClient(int id, Client newClient)
    {
        throw new NotImplementedException();
    }
}