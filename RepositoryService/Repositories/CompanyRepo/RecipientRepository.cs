using DatabaseService.Context;
using InfrastructureService.Entities.CompanyEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.CompanyRepository;

namespace RepositoryService.Repositories.CompanyRepo;

public class RecipientRepository : IRecipientRepository
{
    private readonly ApplicationContext _context;

    public RecipientRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetRecipientById(int id)
    {
        var recipient = await _context.Recipients
                            .Where(x => x.Id == id)
                            .FirstOrDefaultAsync()
                        ?? throw new InvalidOperationException("Recipient not found!");
        
        return CustomSerializer.Serialize(recipient);
    }

    public Task<bool> CreateRecipient(Recipient recipient)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteRecipient(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateRecipient(int id, Recipient newRecipient)
    {
        throw new NotImplementedException();
    }
}