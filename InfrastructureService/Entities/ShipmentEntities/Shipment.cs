using InfrastructureService.Entities.BaseEntities;
using InfrastructureService.Entities.CompanyEntities;
using InfrastructureService.Entities.DeliveryEntities;

namespace InfrastructureService.Entities.ShipmentEntities;

/// <summary>
/// Грузоперевозка
/// </summary>
public class Shipment : BaseEntity
{
    /// <summary>
    /// Агент
    /// </summary>
    public Agent Agent { get; set; } = null!;
    
    /// <summary>
    /// Брокер
    /// </summary>
    public Broker Broker { get; set; } = null!;
    
    /// <summary>
    /// Клиент
    /// </summary>
    public Client Client { get; set; } = null!;
    
    /// <summary>
    /// Экспедитор
    /// </summary>
    public Expediter Expediter { get; set; } = null!;
    
    /// <summary>
    /// Получатель
    /// </summary>
    public Recipient Recipient { get; set; } = null!;
    
    /// <summary>
    /// Отправитель
    /// </summary>
    public Supplier Supplier { get; set; } = null!;

    /// <summary>
    /// Заказ
    /// </summary>
    public Order Order { get; set; } = null!;

    /// <summary>
    /// Таможенный пост
    /// </summary>
    public CustomHouse CustomHouse { get; set; } = null!;

    /// <summary>
    /// Документы грузоперевозки
    /// </summary>
    public ShipmentDocument ShipmentDocument { get; set; } = null!;

    /// <summary>
    /// Детали грузоперевозки
    /// </summary>
    public ShipmentDetail ShipmentDetail { get; set; } = null!;
}