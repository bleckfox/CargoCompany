using InfrastructureService.Entities.BaseEntities;

namespace InfrastructureService.Entities.DeliveryEntities;

/// <summary>
/// Страна
/// </summary>
public class Country : BaseDeliveryEntity
{
    /// <summary>
    /// Список расположений
    /// </summary>
    public List<Location> Locations { get; set; } = null!;

    /// <summary>
    /// Список таможенных постов в стране
    /// </summary>
    public List<CustomHouse> CustomHouses { get; set; } = null!;
}