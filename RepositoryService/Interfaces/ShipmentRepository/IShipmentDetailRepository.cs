using InfrastructureService.Entities.ShipmentEntities;

namespace RepositoryService.Interfaces.ShipmentRepository;

public interface IShipmentDetailRepository
{
    /// <summary>
    /// Получение деталей отправления по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Детали отправления</returns>
    Task<ShipmentDetail> GetShipmentDetailById(int id);

    /// <summary>
    /// Создание деталей отправления
    /// </summary>
    /// <param name="shipmentDetail">Детали отправления</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateShipmentDetail(ShipmentDetail shipmentDetail);

    /// <summary>
    /// Удаление деталей отправления
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteShipmentDetail(int id);

    /// <summary>
    /// Обновление данных деталей отправления
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newShipmentDetail">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateShipmentDetail(int id, ShipmentDetail newShipmentDetail);
}