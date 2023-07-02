using InfrastructureService.Entities.BaseEntities;

namespace InfrastructureService.Entities.ShipmentEntities;

/// <summary>
/// Заказ
/// </summary>
public class Order : BaseEntity
{
    /// <summary>
    /// Номер заказа
    /// </summary>
    public string OrderNumber { get; set; } = null!;
    
    /// <summary>
    /// Номер инвойса (счета)
    /// </summary>
    public string InvoiceNumber { get; set; } = null!;
    
    /// <summary>
    /// Объем
    /// </summary>
    public float Volume { get; set; }
    
    /// <summary>
    /// Стоимость
    /// </summary>
    public decimal Cost { get; set; }
    
    /// <summary>
    /// Условия поставки
    /// </summary>
    public string DeliveryCondition { get; set; } = null!;

    /// <summary>
    /// Особые условия погрузки
    /// </summary>
    public string SpecialLoadingConditions { get; set; } = null!;
    
    /// <summary>
    /// Дата создания заказа
    /// </summary>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Контейнеры в заказе
    /// </summary>
    public List<Container> Containers { get; set; } = null!;
}