using InfrastructureService.Entities.CompanyEntities;

namespace RepositoryService.Interfaces.CompanyRepository;

public interface IExpediterRepository
{
    /// <summary>
    /// Получение экспедитера по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Экспедитер</returns>
    Task<string> GetExpediterById(int id);

    /// <summary>
    /// Создание экспедитера
    /// </summary>
    /// <param name="expediter">Экспедитер</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateExpediter(Expediter expediter);

    /// <summary>
    /// Удаление экспедитера
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteExpediter(int id);

    /// <summary>
    /// Обновление данных экспедитера
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newExpediter">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateExpediter(int id, Expediter newExpediter);
}