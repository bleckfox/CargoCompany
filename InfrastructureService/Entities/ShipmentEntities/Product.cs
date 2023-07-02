using System.ComponentModel.DataAnnotations;
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
    [Range(0, int.MaxValue, ErrorMessage = "Значение должно быть не меньше 0")]
    public int ProductNumber { get; set; }
    
    /// <summary>
    /// Вес брутто
    /// </summary>
    [Range(0, float.MaxValue, ErrorMessage = "Значение должно быть не меньше 0")]
    public float GrossWeight { get; set; }
    
    /// <summary>
    /// Стоимость
    /// </summary>
    [Range(0, (double) decimal.MaxValue, ErrorMessage = "Значение должно быть не меньше 0")]
    public decimal Cost { get; set; }
}