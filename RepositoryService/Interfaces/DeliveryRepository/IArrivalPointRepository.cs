using InfrastructureService.Entities.DeliveryEntities;

namespace RepositoryService.Interfaces.DeliveryRepository;

public interface IArrivalPointRepository
{
    /// <summary>
    /// Получение пункта прибытия по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Пункт прибытия</returns>
    Task<ArrivalPoint> GetArrivalPointById(int id);

    /// <summary>
    /// Создание пункта прибытия
    /// </summary>
    /// <param name="arrivalPoint">Пункт прибытия</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateArrivalPoint(ArrivalPoint arrivalPoint);

    /// <summary>
    /// Удаление пункта прибытия
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteArrivalPoint(int id);

    /// <summary>
    /// Обновление данных пункта прибытия
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newArrivalPoint">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateArrivalPoint(int id, ArrivalPoint newArrivalPoint);
}