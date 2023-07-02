using InfrastructureService.Entities.CompanyEntities;

namespace RepositoryService.Interfaces.CompanyRepository;

public interface IClientRepository
{
    /// <summary>
    /// Получение клиента по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Клиент</returns>
    Task<string> GetClientById(int id);

    /// <summary>
    /// Создание клиента
    /// </summary>
    /// <param name="client">Клиент</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateClient(Client client);

    /// <summary>
    /// Удаление клиента
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteClient(int id);

    /// <summary>
    /// Обновление данных клиента
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newClient">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateClient(int id, Client newClient);
}