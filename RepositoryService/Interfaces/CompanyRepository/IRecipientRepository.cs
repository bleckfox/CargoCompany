using InfrastructureService.Entities.CompanyEntities;

namespace RepositoryService.Interfaces.CompanyRepository;

public interface IRecipientRepository
{
    /// <summary>
    /// Получение получателя по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Получатель</returns>
    Task<string> GetRecipientById(int id);

    /// <summary>
    /// Создание получателя
    /// </summary>
    /// <param name="recipient">Получатель</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateRecipient(Recipient recipient);

    /// <summary>
    /// Удаление получателя
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteRecipient(int id);

    /// <summary>
    /// Обновление данных получателя
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newRecipient">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateRecipient(int id, Recipient newRecipient);
}