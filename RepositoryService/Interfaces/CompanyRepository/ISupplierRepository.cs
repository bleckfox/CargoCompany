using InfrastructureService.Entities.CompanyEntities;

namespace RepositoryService.Interfaces.CompanyRepository;

public interface ISupplierRepository
{
    /// <summary>
    /// Получение поставщика по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Поставщик</returns>
    Task<Supplier> GetSupplierById(int id);

    /// <summary>
    /// Создание поставщика
    /// </summary>
    /// <param name="supplier">Поставщик</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateSupplier(Supplier supplier);

    /// <summary>
    /// Удаление поставщика
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteSupplier(int id);

    /// <summary>
    /// Обновление данных поставщика
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newSupplier">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateSupplier(int id, Supplier newSupplier);
}