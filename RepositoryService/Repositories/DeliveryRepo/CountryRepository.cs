using DatabaseService.Context;
using InfrastructureService.Entities.DeliveryEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.DeliveryRepository;

namespace RepositoryService.Repositories.DeliveryRepo;

public class CountryRepository : ICountryRepository
{
    private readonly ApplicationContext _context;

    public CountryRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetCountryById(int id)
    {
        var country = await _context.Countries
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync()
                            ?? throw new InvalidOperationException("Agent not found!");
                
        return CustomSerializer.Serialize(country);
    }

    public Task<bool> CreateCountry(Country country)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCountry(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateCountry(int id, Country newCountry)
    {
        throw new NotImplementedException();
    }
}