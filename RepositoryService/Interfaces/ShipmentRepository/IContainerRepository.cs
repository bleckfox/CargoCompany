using InfrastructureService.Entities.ShipmentEntities;

namespace RepositoryService.Interfaces.ShipmentRepository;

public interface IContainerRepository
{
    /// <summary>
    /// Получение контейнера по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Контейнер</returns>
    Task<Container> GetContainerById(int id);

    /// <summary>
    /// Создание контейнера
    /// </summary>
    /// <param name="container">Контейнер</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateContainer(Container container);

    /// <summary>
    /// Удаление контейнера
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteContainer(int id);

    /// <summary>
    /// Обновление данных контейнера
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newContainer">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateContainer(int id, Container newContainer);
}