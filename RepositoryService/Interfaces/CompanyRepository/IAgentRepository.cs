using InfrastructureService.Entities.CompanyEntities;

namespace RepositoryService.Interfaces.CompanyRepository;

public interface IAgentRepository
{
    /// <summary>
    /// Получение агента по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Агент</returns>
    Task<Agent> GetAgentById(int id);
    
    /// <summary>
    /// Создание агента
    /// </summary>
    /// <param name="agent">Агент</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateAgent(Agent agent);

    /// <summary>
    /// Удаление агента
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteAgent(int id);

    /// <summary>
    /// Обновление данных агента
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newAgent">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateAgent(int id, Agent newAgent);
}