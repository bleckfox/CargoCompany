using InfrastructureService.Entities.DeliveryEntities;

namespace RepositoryService.Interfaces.DeliveryRepository;

public interface ICustomHouseRepository
{
    /// <summary>
    /// Получение таможенного поста по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Таможенный пост</returns>
    Task<string> GetCustomHouseById(int id);

    /// <summary>
    /// Создание таможенного постп
    /// </summary>
    /// <param name="customHouse">Таможенный пост</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateCustomHouse(CustomHouse customHouse);

    /// <summary>
    /// Удаление таможенного поста
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteCustomHouse(int id);

    /// <summary>
    /// Обновление данных таможенного поста
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newCustomHouse">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateCustomHouse(int id, CustomHouse newCustomHouse);
}