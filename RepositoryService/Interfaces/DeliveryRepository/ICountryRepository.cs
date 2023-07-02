using InfrastructureService.Entities.DeliveryEntities;

namespace RepositoryService.Interfaces.DeliveryRepository;

public interface ICountryRepository
{
    /// <summary>
    /// Получение страны по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Страна</returns>
    Task<Country> GetCountryById(int id);

    /// <summary>
    /// Создание страны
    /// </summary>
    /// <param name="country">Страна</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateCountry(Country country);

    /// <summary>
    /// Удаление страны
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteCountry(int id);

    /// <summary>
    /// Обновление данных страны
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newCountry">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateCountry(int id, Country newCountry);
}