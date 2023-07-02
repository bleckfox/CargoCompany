using InfrastructureService.Entities.CompanyEntities;

namespace RepositoryService.Interfaces.CompanyRepository;

public interface IBrokerRepository
{
    /// <summary>
    /// Получение брокера по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Брокер</returns>
    Task<string> GetBrokerById(int id);

    /// <summary>
    /// Создание брокера
    /// </summary>
    /// <param name="broker">Брокер</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateBroker(Broker broker);

    /// <summary>
    /// Удаление брокера
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteBroker(int id);

    /// <summary>
    /// Обновление данных брокера
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newBroker">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateBroker(int id, Broker newBroker);
}