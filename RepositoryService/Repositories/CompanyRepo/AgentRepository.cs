using System.Text.Json;
using DatabaseService.Context;
using InfrastructureService.Entities.CompanyEntities;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.CompanyRepository;

namespace RepositoryService.Repositories.CompanyRepo;

public class AgentRepository : IAgentRepository
{
    private readonly ApplicationContext _context;

    public AgentRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetAgentById(int id)
    {
        var agent = await _context.Agents
            .FirstOrDefaultAsync()
                    ?? throw new InvalidOperationException("Agent not found!");
        
        return JsonSerializer.Serialize(agent);
    }

    public Task<bool> CreateAgent(Agent agent)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAgent(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAgent(int id, Agent newAgent)
    {
        throw new NotImplementedException();
    }
}