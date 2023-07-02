using InfrastructureService.Entities.DeliveryEntities;

namespace RepositoryService.Interfaces.DeliveryRepository;

public interface ILocationRepository
{
    /// <summary>
    /// Получение локации по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Локация</returns>
    Task<Location> GetLocationById(int id);

    /// <summary>
    /// Создание локации
    /// </summary>
    /// <param name="location">Локация</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateLocation(Location location);

    /// <summary>
    /// Удаление локации
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteLocation(int id);

    /// <summary>
    /// Обновление данных локации
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newLocation">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateLocation(int id, Location newLocation);
}