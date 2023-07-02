using InfrastructureService.Entities.DeliveryEntities;

namespace RepositoryService.Interfaces.DeliveryRepository;

public interface IStorageRepository
{
    /// <summary>
    /// Получение хранилища по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Хранилище</returns>
    Task<Storage> GetStorageById(int id);

    /// <summary>
    /// Создание хранилища
    /// </summary>
    /// <param name="storage">Хранилище</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateStorage(Storage storage);

    /// <summary>
    /// Удаление хранилища
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteStorage(int id);

    /// <summary>
    /// Обновление данных хранилища
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newStorage">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateStorage(int id, Storage newStorage);
}