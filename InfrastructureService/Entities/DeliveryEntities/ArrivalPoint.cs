using InfrastructureService.Entities.BaseEntities;

namespace InfrastructureService.Entities.DeliveryEntities;

/// <summary>
/// Пункт прибытия/отправки
/// </summary>
public class ArrivalPoint : BaseDeliveryEntity
{
    /// <summary>
    /// Тип пункта отправления/прибытия
    /// (морской/речной порт, ж/д станция, вокзал и т.д.)
    /// </summary>
    public string PointType { get; set; } = null!;
    
    /// <summary>
    /// Дата прибытия
    /// </summary>
    public DateTime ArrivalDate { get; set; }
    
    /// <summary>
    /// Дата отправки
    /// </summary>
    public DateTime DispatchDate { get; set; }

    /// <summary>
    /// Место расположения
    /// </summary>
    public Location Location { get; set; } = null!;
}