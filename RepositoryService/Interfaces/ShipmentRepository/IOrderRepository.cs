using InfrastructureService.Entities.ShipmentEntities;

namespace RepositoryService.Interfaces.ShipmentRepository;

public interface IOrderRepository
{
    /// <summary>
    /// Получение заказа по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Заказ</returns>
    Task<Order> GetOrderById(int id);

    /// <summary>
    /// Создание заказа
    /// </summary>
    /// <param name="order">Заказ</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateOrder(Order order);

    /// <summary>
    /// Удаление заказа
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteOrder(int id);

    /// <summary>
    /// Обновление данных заказа
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newOrder">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateOrder(int id, Order newOrder);
}