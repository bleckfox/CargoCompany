using InfrastructureService.Entities.ShipmentEntities;

namespace RepositoryService.Interfaces.ShipmentRepository;

public interface IProductRepository
{
    /// <summary>
    /// Получение продукта по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Продукт</returns>
    Task<string> GetProductById(int id);

    /// <summary>
    /// Создание продукта
    /// </summary>
    /// <param name="product">Продукт</param>
    /// <returns>Признак удалось ли создать</returns>
    Task<bool> CreateProduct(Product product);

    /// <summary>
    /// Удаление продукта
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Признак удалось ли удалить</returns>
    Task<bool> DeleteProduct(int id);

    /// <summary>
    /// Обновление данных продукта
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="newProduct">Новые данные</param>
    /// <returns>Признак удалось ли обновить</returns>
    Task<bool> UpdateProduct(int id, Product newProduct);
}