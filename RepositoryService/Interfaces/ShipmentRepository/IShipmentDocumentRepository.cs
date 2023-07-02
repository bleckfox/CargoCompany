using InfrastructureService.Entities.ShipmentEntities;

namespace RepositoryService.Interfaces.ShipmentRepository;

public interface IShipmentDocumentRepository
{
    /// <summary>
    /// Получение документа отгрузки по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Документ отгрузки</returns>
    Task<ShipmentDocument> GetShipmentDocumentById(int id);

    /// <summary>
    /// Создание документа отгрузки
    /// </summary>
    /// <param name="shipmentDocument">Документ отгрузки</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateShipmentDocument(ShipmentDocument shipmentDocument);

    /// <summary>
    /// Удаление документа отгрузки
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteShipmentDocument(int id);

    /// <summary>
    /// Обновление данных документа отгрузки
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newShipmentDocument">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateShipmentDocument(int id, ShipmentDocument newShipmentDocument);
}