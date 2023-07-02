using InfrastructureService.Entities.BaseEntities;

namespace InfrastructureService.Entities.ShipmentEntities;

/// <summary>
/// Товар/продукт
/// </summary>
public class Product : BaseEntity
{
    /// <summary>
    /// Название товара/продукта
    /// </summary>
    public string ProductName { get; set; } = null!;

    /// <summary>
    /// Количество мест
    /// </summary>
    public int ProductNumber { get; set; }
    
    /// <summary>
    /// Вес брутто
    /// </summary>
    public float GrossWeight { get; set; }
    
    /// <summary>
    /// Стоимость
    /// </summary>
    public decimal Cost { get; set; }
}