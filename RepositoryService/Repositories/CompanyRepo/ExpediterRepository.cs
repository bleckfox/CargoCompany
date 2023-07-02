using DatabaseService.Context;
using InfrastructureService.Entities.CompanyEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.CompanyRepository;

namespace RepositoryService.Repositories.CompanyRepo;

public class ExpediterRepository : IExpediterRepository
{
    private readonly ApplicationContext _context;

    public ExpediterRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetExpediterById(int id)
    {
        var expediter = await _context.Expediters
                            .Where(x => x.Id == id)
                            .FirstOrDefaultAsync()
                        ?? throw new InvalidOperationException("Expediter not found!");
        
        return CustomSerializer.Serialize(expediter);
    }

    public Task<bool> CreateExpediter(Expediter expediter)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteExpediter(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateExpediter(int id, Expediter newExpediter)
    {
        throw new NotImplementedException();
    }
}