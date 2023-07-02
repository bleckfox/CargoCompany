using DatabaseService.Context;
using InfrastructureService.Entities.ShipmentEntities;
using InfrastructureService.Utils;
using Microsoft.EntityFrameworkCore;
using RepositoryService.Interfaces.ShipmentRepository;

namespace RepositoryService.Repositories.ShipmentRepo;

public class OrderRepository : IOrderRepository
{
    private readonly ApplicationContext _context;

    public OrderRepository(ApplicationContext context)
    {
        _context = context;
    }

    public async Task<string> GetOrderById(int id)
    {
        var order = await _context.Orders
                    .Where(x => x.Id == id)
                    .FirstOrDefaultAsync()
                            ?? throw new InvalidOperationException("Order not found!");
                
        return CustomSerializer.Serialize(order);
    }

    public Task<bool> CreateOrder(Order order)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteOrder(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateOrder(int id, Order newOrder)
    {
        throw new NotImplementedException();
    }
}