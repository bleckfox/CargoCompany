using InfrastructureService.Entities.BaseEntities;
using InfrastructureService.Entities.DeliveryEntities;

namespace InfrastructureService.Entities.ShipmentEntities;

/// <summary>
/// Детали грузоперевозки
/// </summary>
public class ShipmentDetail : BaseEntity
{
    /// <summary>                                       
    /// Грузоперевозка                                  
    /// </summary>                                      
    public Shipment Shipment { get; set; } = null!;

    /// <summary>
    /// Пункт прибытия/отправки
    /// </summary>
    public ArrivalPoint ArrivalPoint { get; set; } = null!;
    
    /// <summary>
    /// Дата проверки
    /// </summary>
    public DateTime CheckDate { get; set; }
    
    /// <summary>
    /// Дата получения груза
    /// </summary>
    public DateTime ReceiptDate { get; set; }
    
    /// <summary>
    /// Дата готовности
    /// </summary>
    public DateTime ReadyDate { get; set; }
    
    /// <summary>
    /// Дата загрузки
    /// </summary>
    public DateTime LoadDate { get; set; }
    
    /// <summary>
    /// Дата выгрузки
    /// </summary>
    public DateTime UnloadDate { get; set; }
    
    /// <summary>
    /// Примечание
    /// </summary>
    public string Note { get; set; } = null!;
}