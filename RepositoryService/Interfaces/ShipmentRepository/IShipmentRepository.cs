using InfrastructureService.Entities.ShipmentEntities;

namespace RepositoryService.Interfaces.ShipmentRepository;

public interface IShipmentRepository
{
    /// <summary>
    /// Получение отправления по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Отправление</returns>
    Task<Shipment> GetShipmentById(int id);

    /// <summary>
    /// Создание отправления
    /// </summary>
    /// <param name="shipment">Отправление</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateShipment(Shipment shipment);

    /// <summary>
    /// Удаление отправления
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteShipment(int id);

    /// <summary>
    /// Обновление данных отправления
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newShipment">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateShipment(int id, Shipment newShipment);
}