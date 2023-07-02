using InfrastructureService.Entities.BaseEntities;
using InfrastructureService.Entities.ShipmentEntities;

namespace InfrastructureService.Entities.DeliveryEntities;

/// <summary>
/// Склад
/// </summary>
public class Storage : BaseEntity
{
    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// Почтовый индекс
    /// </summary>
    public string PostCode { get; set; } = null!;
    
    /// <summary>
    /// Место расположения
    /// </summary>
    public Location Location { get; set; } = null!;

    /// <summary>
    /// Список контейнеров на складе
    /// </summary>
    public List<Container> Containers { get; set; } = null!;
}